using BilibiliUPInfoCollector.Utility;
using BilibiliUPInfoCollector.Model;

namespace BilibiliUPInfoCollector.Data
{
    public class ManualCollectAsync
    {
        public IntDelegate UIStepDelegate, UIProgressBarValueSetDelegate;
        public StringDelegate UITipTextDelegate, UICountTextDelegate;
        public VoidDelegate TaskCallBack;

        public void Invoke()
        {
            //采集信息            
            UIStepDelegate(0);
            UITipTextDelegate("正在抓取数据……");
            UICountTextDelegate(string.Empty);
            General.Instance.rooms.Clear();
            General.Instance.rooms = CollectUtility.GetCurrentRooms(Setting.Default.LiveType, Setting.Default.AreaID);
            UIProgressBarValueSetDelegate(General.Instance.rooms.Count);
            UICountTextDelegate(string.Format("0/{0}", General.Instance.rooms.Count));

            //更新与下载信息
            General.Instance.ups = General.Instance.GetUpsByRooms(General.Instance.rooms);
            for (int i = 0; i < General.Instance.ups.Count; i++)
            {
                UITipTextDelegate(string.Format("采集{0}的信息中…", General.Instance.ups[i].nickname));
                UICountTextDelegate(string.Format("{0}/{1}", i + 1, General.Instance.rooms.Count));
                DownloadUtility.DownloadUpInfo(General.Instance.ups[i]);
                string sysCoverFilename = Path.Combine(Path.CacheDirectory, Path.GetFileName(General.Instance.rooms[i].system_cover.Split('?')[0]));
                if (!string.IsNullOrEmpty(General.Instance.rooms[i].system_cover))
                    DownloadUtility.DownloadImage(General.Instance.rooms[i].system_cover, sysCoverFilename);
                UIStepDelegate(i + 1);
            }

            //保存信息
            UITipTextDelegate("正在保存数据……");
            General.Instance.ups = General.Instance.UpsOnline2Local(General.Instance.ups);
            General.Instance.SaveInfo();
            General.Instance.SaveAllInfos2File();
            UIStepDelegate(100);

            TaskCallBack();
        }
    }
}
