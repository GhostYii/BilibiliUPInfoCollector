using System;
using IOPath = System.IO.Path;

namespace BilibiliUPInfoCollector.Utility
{
    static public class Path
    {
        static public string CurrentDirectory
        { get { return Environment.CurrentDirectory; } }
        static public string InfosDirectory
        { get { return Combine(Environment.CurrentDirectory, "Infos"); } }
        static public string CacheDirectory
        { get { return Combine(Environment.CurrentDirectory, "Cache"); } }
        static public string LogsDirectory
        { get { return Combine(Environment.CurrentDirectory, "Logs"); } }
        static public string CoversDirectory
        { get { return Combine(InfosDirectory, "Covers"); } }
        static public string FacesDirectory
        { get { return Combine(InfosDirectory, "Faces"); } }
        static public string InfoFile
        { get { return Combine(InfosDirectory, "info.manifest"); } }
        static public string INIFile
        { get { return Combine(CurrentDirectory, "setting.ini"); } }

        static public string Combine(params string[] paths)
        {
            return IOPath.Combine(paths);
        }

        static public string GetFileName(string path)
        {
            return IOPath.GetFileName(path);
        }

        static public string GetFileNameWitoutExtension(string path)
        {
            return IOPath.GetFileNameWithoutExtension(path);
        }

        static public string GetExtension(string path)
        {
            return IOPath.GetExtension(path);
        }
    }
}
