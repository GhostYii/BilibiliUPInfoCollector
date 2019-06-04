using System;
using BilibiliUPInfoCollector.Utility;
using BilibiliUPInfoCollector.Model;

namespace BilibiliUPInfoCollector.Data
{
    public class AutoCollectAsync
    {
        public StringDelegate StatuUpdate;
        public VoidDelegate Accomplish;

        public void Invoke()
        {
            StatuUpdate(string.Format("正在进行第{0}次自动采集任务。", General.Instance.collectCount));
            General.Instance.rooms = CollectUtility.GetCurrentRooms(Setting.Default.LiveType, Setting.Default.AreaID);
            General.Instance.ups = General.Instance.GetUpsByRooms(General.Instance.rooms);
            StatuUpdate(string.Format("本次采集已完成5%，数据抓取完成，正在进行采集…"));
            for (int i = 0; i < General.Instance.rooms.Count; i++)
            {
                StatuUpdate(string.Format("本次采集已完成{1}%，正在采集{0}的信息…", General.Instance.ups[i].nickname, 89 * i / General.Instance.rooms.Count + 5));
                DownloadUtility.DownloadUpInfo(General.Instance.ups[i]);
                string sysCoverFilename = Path.Combine(Path.CacheDirectory, Path.GetFileName(General.Instance.rooms[i].system_cover.Split('?')[0]));
                if (!string.IsNullOrEmpty(General.Instance.rooms[i].system_cover))
                    DownloadUtility.DownloadImage(General.Instance.rooms[i].system_cover, sysCoverFilename);
            }

            StatuUpdate(string.Format("所有数据采集完成，正在保存数据…"));
            General.Instance.ups = General.Instance.UpsOnline2Local(General.Instance.ups);
            General.Instance.SaveInfo();
            General.Instance.SaveAllInfos2File();
            StatuUpdate(string.Format("第{0}次自动采集任务完成。", General.Instance.collectCount));            

            Accomplish();
        }
    }
}
