using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
namespace Homework9_Winform
{
    public delegate void Load(String url);
    class Crawler
    {
        public static string startUrl { get; set; }
        public static string hostUrl { get; set; }
        public event Load PageDownloaded;
        //(url,bool)
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public void Crawl()
        {
            this.urls.Add(startUrl, false);
            Uri uri = new Uri(startUrl);
            hostUrl = uri.Host;
            //Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                string html = DownLoad(current); // 下载
                //触发事件,添加到listbox中
                PageDownloaded("爬取成功："+current);
                urls[current] = true;
                count++;
                if (isHtml(html))
                {
                    Parse(html, current);//解析,并加入新的链接
                }
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
                PageDownloaded("爬取错误：" + url);
                return "";
            }
        }
        //current记录相对路径的父路径，以便将相对路径转化为绝对路径
        private void Parse(string html, string current)
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

