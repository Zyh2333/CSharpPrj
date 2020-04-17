using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace SimpleCrawler
{
    class SimpleCrawler
    {
        public static string startUrl { get; set; }
        public static string hostUrl { get; set; }
        //(url,bool)
        private Hashtable urls = new Hashtable();
        private int count = 0;
        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            startUrl = "http://www.cnblogs.com/dstang2000/";
            //获取url的域名
            Uri uri = new Uri(startUrl);
            hostUrl = uri.Host;
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                                                 //判断是否为html文本
                urls[current] = true;
                count++;
                if(isHtml(html)){
                Parse(html,current);//解析,并加入新的链接
                }
                Console.WriteLine("爬行结束");
            }
        }
        //下载该url对应的文本内容

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
        //current记录相对路径的父路径，以便将相对路径转化为绝对路径
        private void Parse(string html,string current)
        {
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";
            string isAbsolute = "^http";
            Regex regexAbsolute = new Regex(isAbsolute);
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                String absoluteValue = match.Value;
                //查找新链接
                strRef = absoluteValue.Substring(absoluteValue.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                //若是相对路径
                if (!regexAbsolute.IsMatch(strRef))
                {
                    strRef = current + strRef;
                }
                if (urls[strRef] == null && strRef.Contains(hostUrl)) urls[strRef] = false;
            }
        }
        //检查是否为html文本，若不是则不进行进一步爬取
        private bool isHtml(string html)
        {
            string isHtmlRex = @"^(<!DOCTYPE html>)";
            Regex regex = new Regex(isHtmlRex);
            return regex.IsMatch(html);
        }
    }
}
