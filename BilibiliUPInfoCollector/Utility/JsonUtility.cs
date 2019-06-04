using LitJson;

namespace BilibiliUPInfoCollector.Utility
{
    public static class JsonUtility
    {
        static public string ToJson(object obj)
        {
            return JsonMapper.ToJson(obj);
        }

        static public T ToObject<T>(string json)
        {
            return JsonMapper.ToObject<T>(json);
        }       
    }
}
