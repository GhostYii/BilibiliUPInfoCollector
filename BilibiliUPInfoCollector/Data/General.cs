using System;
using System.IO;
using System.Collections.Generic;
using BilibiliUPInfoCollector.Model;
using BilibiliUPInfoCollector.Utility;
using Path = BilibiliUPInfoCollector.Utility.Path;

namespace BilibiliUPInfoCollector.Data
{
    public class General
    {
        private static General instance;

        public static General Instance
        {
            get
            {
                if (instance == null)
                    instance = new General();
                return instance;
            }
        }

        public List<RoomInfo> rooms = new List<RoomInfo>();
        public List<UpInfo> ups;
        public int collectCount = 0;
        public DateTime prevTime = DateTime.Now;

        public void Init()
        {
            Directory.CreateDirectory(Path.CacheDirectory);
            Directory.CreateDirectory(Path.InfosDirectory);
            Directory.CreateDirectory(Path.FacesDirectory);
            Directory.CreateDirectory(Path.CoversDirectory);
            Directory.CreateDirectory(Path.LogsDirectory);
            StreamWriter sr = File.CreateText(Path.INIFile);
        }

        public List<UpInfo> GetUpsByFile()
        {
            string json = File.ReadAllText(Path.InfoFile);
            return JsonUtility.ToObject<List<UpInfo>>(json);
        }

        public List<UpInfo> GetUpsByRooms(List<RoomInfo> rooms)
        {
            List<UpInfo> ups = new List<UpInfo>();
            foreach (var r in rooms)
                ups.Add(r.ToOnlineUpInfo());

            return ups;
        }

        public List<UpInfo> UpsOnline2Local(List<UpInfo> online)
        {
            for (int i = 0; i < online.Count; i++)
            {
                UpInfo tmp = online[i];
                tmp.faceImg = Path.GetFileName(tmp.faceImg);
                tmp.roomCover = Path.GetFileName(tmp.roomCover);
                online[i] = tmp;
            }

            return online;
        }

        public void SaveInfo()
        {
            File.Delete(Path.InfoFile);
            File.AppendAllText(Path.InfoFile, JsonUtility.ToJson(ups));
        }

        public void SaveAllInfos2File(string filename)
        {
            List<SavableInfo> fileInfos = new List<SavableInfo>();
            foreach (var item in rooms)
            {
                fileInfos.Add(item.ToSavableInfo());
            }

            string path = Path.Combine(Path.LogsDirectory, filename);
            int copy = 0;
            while (File.Exists(path))
                path = string.Format("{0}\\{1}\\{2}\\{3}", Path.LogsDirectory, Path.GetFileNameWitoutExtension(path), copy++, Path.GetExtension(path));
            File.AppendAllText(path, JsonUtility.ToJson(fileInfos));
        }

        public void SaveAllInfos2File()
        {
            List<SavableInfo> fileInfos = new List<SavableInfo>();
            foreach (var item in rooms)
            {
                fileInfos.Add(item.ToSavableInfo());
            }

            string path = Path.Combine(Path.LogsDirectory, string.Format("{0}.txt", DateTime.Now.ToString("yyMMddHHmmss")));
            File.AppendAllText(path, JsonUtility.ToJson(fileInfos));
        }

        public string CollectInfoManual()
        {
            rooms.Clear();
            rooms = CollectUtility.GetCurrentRooms(Setting.Default.LiveType, Setting.Default.AreaID);
            ups = GetUpsByRooms(rooms);
            foreach (var up in ups)
                DownloadUtility.DownloadUpInfo(up);

            return string.Format("[{0}]: 第{1}次手动采集信息成功！共采集到{2}条信息。", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), ++collectCount, rooms.Count);
        }

        public void CollectInfoAuto()
        {
            rooms = CollectUtility.GetCurrentRooms(Setting.Default.LiveType, Setting.Default.AreaID);
            if (File.Exists(Path.InfoFile))
                ups = GetUpsByFile();
            else
            {
                ups = GetUpsByRooms(rooms);
                foreach (var up in ups)
                    DownloadUtility.DownloadUpInfo(up);
                ups = UpsOnline2Local(ups);
                SaveInfo();
            }
        }

        public string UpdateCollectTime()
        {
            prevTime = DateTime.Now;
            prevTime = prevTime.AddHours(Setting.Default.IntervalHour).AddMinutes(Setting.Default.IntervalMin).AddSeconds(Setting.Default.IntervalSecond);

            return prevTime.ToString("yy/MM/dd hh:mm:ss");
        }

        public static AreaType ToAreaTypeByName(string name)
        {
            switch (name)
            {
                case "全部": return AreaType.All;
                case "视频唱见": return AreaType.ChangJian;
                case "舞见": return AreaType.WuJian;
                case "视频聊天": return AreaType.VideoChat;
                case "才艺": return AreaType.Talent;
                case "虚拟主播": return AreaType.VirtualAnchor;
                case "美食": return AreaType.Food;
                case "户外": return AreaType.Outdoor;
                case "手工": return AreaType.Manual;
                case "萌宠": return AreaType.Pet;
                case "学习": return AreaType.Study;
                case "映评馆": return AreaType.VideoComment;
                case "音乐台": return AreaType.Music;
                case "英雄联盟": return AreaType.LOL;
                case "APEX": return AreaType.APEX;
                case "绝地求生": return AreaType.PUBG;
                case "守望先锋": return AreaType.OW;
                case "Dota2": return AreaType.Dota2;
                case "Dota自走棋": return AreaType.DotaAutoChess;
                case "炉石传说": return AreaType.Lushi;
                case "地下城与勇士": return AreaType.DNF;
                case "CS:GO": return AreaType.CSGO;
                case "魔兽世界": return AreaType.WOW;
                case "王者荣耀": return AreaType.WZRY;
                case "绝地求生：刺激战场": return AreaType.CJZC;
                case "主机游戏": return AreaType.ConsoleGame;
                case "我的世界": return AreaType.Minecraft;
                default: throw new FormatException("字符串无匹配项");
            }
        }
    }
}
