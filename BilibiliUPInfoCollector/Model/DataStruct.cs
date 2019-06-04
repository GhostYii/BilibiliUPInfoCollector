using System;
using System.Collections.Generic;
using BilibiliUPInfoCollector.Utility;

namespace BilibiliUPInfoCollector.Model
{
    [Serializable]
    public struct RoomInfo
    {
        public int roomid;  //房间号
        public int uid; //账号ID
        public string title;    //直播间标题
        public string uname;    //账户名
        public int online;  //在线人数
        public string user_cover;   //直播间封面（指定）
        public int user_cover_flag;
        public string system_cover; //直播间封面（截图）
        public string show_cover;
        public string link;
        public string face; //头像
        public int parent_id;
        public string parent_name;
        public int area_id;
        public string area_name;
        public int area_v2_parent_id;
        public string area_v2_parent_name;
        public int area_v2_id;
        public string area_v2_name;
        public string web_pendent;
        public int pk_id;
        public string session_id;
        public int group_id;

        public UpInfo ToOnlineUpInfo()
        {
            UpInfo up = new UpInfo();
            up.uid = uid;
            up.nickname = uname;
            up.faceImg = face;
            up.roomUrl = string.Format("live.bilibili.com{0}", link);
            up.roomCover = user_cover;
            return up;
        }

        public UpInfo ToLocalUpInfo()
        {
            UpInfo up = new UpInfo();
            up.uid = uid;
            up.nickname = uname;
            up.faceImg = Path.Combine(Path.FacesDirectory, Path.GetFileName(face));
            up.roomUrl = string.Format("live.bilibili.com{0}", link);
            up.roomCover = Path.Combine(Path.CoversDirectory, Path.GetFileName(user_cover));            
            return up;
        }                       

        public SavableInfo ToSavableInfo()
        {
            SavableInfo info = new SavableInfo();
            info.uid = uid;
            info.nickname = uname;
            info.faceImg = face;
            info.roomUrl = string.Format("live.bilibili.com{0}", link);
            info.roomCover = user_cover;
            info.roomTitle = title;
            return info;
        }
    }

    [Serializable]
    public struct TagInfo
    {
        public int id;
        public string name;
        public string sort_type;
    }

    [Serializable]
    public struct NewTagInfo
    {
        public int id;
        public string name;
        public string icon;
        public string sort_type;
        public int type;
        public List<object> sub;
        public List<object> hero_list;
    }

    [Serializable]
    public struct RoomData
    {
        public int count;
        public List<RoomInfo> list;
        public List<object> banner;
        public List<TagInfo> tags;
        public List<NewTagInfo> new_tags;
    }

    [Serializable]
    public struct SavableInfo
    {
        public int uid; //账号uid
        public string nickname; //账号昵称
        public string faceImg;  //头像
        public string roomUrl;  //直播间地址
        public string roomCover;    //直播间封面
        public string roomTitle;    //直播间标题
    }

    public struct UpInfo
    {
        public int uid; //账号uid
        public string nickname; //账号昵称
        public string faceImg;  //头像
        public string roomUrl;  //直播间地址
        public string roomCover;    //直播间封面
    }
    
    public enum CollectType
    {
        Manual,
        Auto
    }

    //大类
    public enum LiveType
    {
        Entertainment = 1,  //娱乐
        OnlineGame = 2, //网游
        Rubbish = 3,    //手游
        Drawing = 4,    //绘画
        Radio = 5,  //电台
        StandAloneGame = 6, //单机
    }
    
    //小类
    public enum AreaType
    {        
        All = 0,    //全部
        //以下为娱乐区
        ChangJian = 21,   //视频唱见
        WuJian = 207,    //舞见
        VideoChat = 145,    //视频聊天
        Talent = 143,   //才艺
        VirtualAnchor = 199,    //虚拟主播
        Food = 136, //美食
        Outdoor = 123,  //户外
        Manual = 25,    //手工
        Pet = 28,   //萌宠
        Study = 27, //学习
        VideoComment = 33,  //映评馆
        Music = 34, //音乐台
        //以下为网游区
        LOL = 86,   //英雄联盟
        APEX = 240, //APEX
        PUBG = 80,  //吃鸡
        OW = 87,    //守望先锋
        Dota2 = 92,
        DotaAutoChess = 239,    //自走棋
        Lushi = 91, //炉石
        DNF = 78,
        CSGO = 89,
        WOW = 83,
        //以下为手游区
        WZRY = 35,  //王者荣耀
        CJZC = 153, //刺激战场
        //以下为单机区
        ConsoleGame = 236,  //主机游戏
        Minecraft = 216,   //我的世界
    }

    public delegate void IntDelegate(int step);
    public delegate void StringDelegate(string str);
    public delegate void VoidDelegate();

    #region ObsoleteEnum
    ////娱乐分区
    //public enum EntertainmentType
    //{
    //    All = 0,    //全部
    //    ChangJian = 21,   //视频唱见
    //    WuJian = 207,    //舞见
    //    VideoChat = 145,    //视频聊天
    //    Talent = 143,   //才艺
    //    VirtualAnchor = 199,    //虚拟主播
    //    Food = 136, //美食
    //    Outdoor = 123,  //户外
    //    Manual = 25,    //手工
    //    Pet = 28,   //萌宠
    //    Study = 27, //学习
    //    VideoComment = 33,  //映评馆
    //    Music = 34, //音乐台
    //}

    ////网游分区
    //public enum OnlineGameType
    //{
    //    All = 0,    //全部
    //    LOL = 86,   //英雄联盟
    //    APEX = 240, //APEX
    //    PUBG = 80,  //吃鸡
    //    OW = 87,    //守望先锋
    //    Dota2 = 92,
    //    DataAutoChess = 239,    //自走棋
    //    Lushi = 91, //炉石
    //    DNF = 78,
    //    CSGO = 89,
    //    WOW = 83,
    //}

    ////手游分区
    //public enum RubbishType
    //{
    //    All = 0,    //全部
    //    WZRY = 35,  //王者荣耀
    //    CJZC = 153, //刺激战场
    //}

    ////画画分区
    //public enum DrawingType
    //{
    //    All = 0,
    //}

    ////电台分区
    //public enum RadioType
    //{
    //    All = 0,
    //}

    ////单机分区
    //public enum StandAloneGameType
    //{
    //    All = 0,
    //    ConsoleGame = 236,  //主机游戏
    //    MC = 216,   //我的世界
    //}
    #endregion
}
