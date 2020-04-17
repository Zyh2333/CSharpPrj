using System;
using System.Threading;
using System.Windows.Forms;
namespace Homework9_Winform
{
    public partial class Form1 : Form
    {
        Crawler crawler = new Crawler();
        public Form1()
        {
            InitializeComponent();
            //设计线程问题
            crawler.PageDownloaded += Crawler_PageDownloaded;
        }

        private void Crawler_PageDownloaded(string url)
        {
            if (this.listBox1.InvokeRequired)
            {
                Action<String> action = this.AddUrl;
                this.Invoke(action, new object[] { url });
            }
            else
            {
                AddUrl(url);
            }
        }

        private void AddUrl(string url)
        {
            listBox1.Items.Add(url);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Crawler.startUrl = UrlText.Text;
            listBox1.Items.Clear();
            new Thread(crawler.Crawl).Start();
        }
    }
}
