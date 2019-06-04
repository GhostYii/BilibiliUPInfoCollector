using System;
using System.Net;
using System.IO;
using System.Drawing;

namespace BilibiliUPInfoCollector.Utility
{
    public static class SpiderUtility
    {
        static public string GetHtmlText(string url)
        {
            WebRequest req = WebRequest.Create(url);
            //req.Method = "GET";
            WebResponse res = req.GetResponse();
            Stream s = res.GetResponseStream();
            StreamReader sr = new StreamReader(s);
            
            string html = sr.ReadToEnd();
            s.Close();
            sr.Close();
            res.Close();
            return html;
        }

        

    }
}
