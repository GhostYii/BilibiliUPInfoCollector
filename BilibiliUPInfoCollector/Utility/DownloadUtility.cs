using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.Collections.Generic;
using BilibiliUPInfoCollector.Model;

namespace BilibiliUPInfoCollector.Utility
{
    static public class DownloadUtility
    {
        static public void DownloadImage(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            Stream s = res.GetResponseStream();

            string[] spilts = url.Split('/');
            string path = Path.Combine(Path.FacesDirectory, spilts[spilts.Length - 1]);
            if (!File.Exists(path))
                Image.FromStream(s).Save(path);

            s.Close();
            res.Close();
        }

        static public void DownloadImage(string url, string filename)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            Stream s = res.GetResponseStream();
            if (!File.Exists(filename))
                Image.FromStream(s).Save(filename);

            s.Close();
            res.Close();
        }

        static public void DownloadUpInfo(UpInfo up)
        {
            string faceFile = Path.Combine(Path.FacesDirectory, Path.GetFileName(up.faceImg));
            if (!File.Exists(faceFile))
                DownloadImage(up.faceImg);
            string coverFilename = Path.Combine(Path.CoversDirectory, Path.GetFileName(up.roomCover).Split('?')[0]);
            if (!File.Exists(coverFilename))
                DownloadImage(up.roomCover, coverFilename);            
        }
    }
}
