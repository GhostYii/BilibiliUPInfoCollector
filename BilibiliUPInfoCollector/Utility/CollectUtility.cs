using System.Collections.Generic;
using BilibiliUPInfoCollector.Model;

namespace BilibiliUPInfoCollector.Utility
{
    public static class CollectUtility
    {
        static public List<RoomInfo> GetCurrentRooms(int lt, int areaId)
        {
            List<RoomInfo> rooms = new List<RoomInfo>();
            PageData pd = new PageData();
            int page = 1;
            do
            {
                string query = string.Format("https://api.live.bilibili.com/room/v3/area/getRoomList?platform=web&parent_area_id={0}&cate_id=0&area_id={1}&sort_type=income&page={2}&page_size=30&tag_version=1", lt, areaId, page++);
                string json = SpiderUtility.GetHtmlText(query);
                pd = JsonUtility.ToObject<PageData>(json);
                rooms.AddRange(pd.data.list);

            } while (pd.data.list.Count > 0);

            return rooms;
        }         
    }
}
