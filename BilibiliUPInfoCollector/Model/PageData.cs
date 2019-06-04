using System;

namespace BilibiliUPInfoCollector.Model
{
    [Serializable]
    public class PageData
    {
        public int code;
        public string msg;
        public string message;
        public RoomData data;

        public PageData() { }
    }
}
