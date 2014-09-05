namespace CrawlSite
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        #region Constants and Fields

        public string _MATCH_REGEX = @"\b(word)\b";

        public string baseUrl;

        public int maxpages;

        public List<string> pagesToExamine;

        public List<string> scannedUrls = new List<string>();

        public string startUrl;
        public string onlyBelow;

        public bool stopMe;

        public List<string> urls = new List<string>();

        public List<string> urlsWithMatch = new List<string>();

        private const string _LINK_REGEX = "href=\"[a-zA-Z./:&\\d_-]+\"";

        private StringBuilder report;

        #endregion

        #region Constructors and Destructors

        public Form1()
        {
            this.InitializeComponent();
            this.stop.Visible = false;
        }

        #endregion

        #region Public Methods and Operators

        public void ParseLinks(string html)
        {
            MatchCollection matches = Regex.Matches(html, _LINK_REGEX);
            int mc = matches.Count;
            for (int i = 0; i <= matches.Count - 1; i++)
            {
                string url = matches[i].Value.Replace("href=\"", "");
                url = url.Replace("\"", "");
                if (url.Length > 2 && url.IndexOf("http://") == -1
                    && (url.IndexOf(".aspx") > -1 || url.IndexOf(".html") > -1))
                {
                    if (url.IndexOf("/") != 0)
                    {
                        url = "/" + url;
                    }
                    if (!this.urls.Contains(this.baseUrl + url))
                    {
                        if(url.ToLower().StartsWith(onlyBelow.ToLower())) this.urls.Add(this.baseUrl + url);
                    }
                }
            }
        }


        public void WriteLastMatch(string value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(this.WriteLastMatch), new object[] { value });
                return;
            }
            this.LastMatch.Text = value;
        }

        public void WriteLastScan(string value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(this.WriteLastScan), new object[] { value });
                return;
            }
            this.lastScanPage.Text = value;
        }

        public void WriteMatchesFound(string value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(this.WriteMatchesFound), new object[] { value });
                return;
            }
            this.MatchesFound.Text = value;
        }

        public void WriteProgressBar(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<int>(this.WriteProgressBar), new object[] { value });
                return;
            }
            this.progressBar1.Minimum = 1;
            this.progressBar1.Value = value;
            this.progresText.Text = value + "/" + this.maxpages;
        }

        public void WriteReport(string value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(this.WriteReport), new object[] { value });
                return;
            }
            this.ReportTxt.Text = value;
        }

        public void changeVisbilityStart(bool value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<bool>(this.changeVisbilityStart), new object[] { value });
                return;
            }
            this.start.Visible = value;
        }

        public void changeVisbilityStop(bool value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<bool>(this.changeVisbilityStop), new object[] { value });
                return;
            }
            this.stop.Visible = value;
        }

        #endregion

        #region Methods

        private void CrawlFunction()
        {
            this.changeVisbilityStart(false);
            this.changeVisbilityStop(true);
            this.WriteReport("Started");
            string htmlText = this.GetWebText(this.startUrl);
            //get links
            this.ParseLinks(htmlText);

            List<string> theseUrls;

            bool foundOne = true;

            while (this.scannedUrls.Count <= this.maxpages && foundOne && !this.stopMe)
            {
                theseUrls = new List<string>();
                foreach (string url in this.urls)
                {
                    theseUrls.Add(url);
                }
                foreach (string url in theseUrls)
                {
                    if (this.stopMe)
                    {
                        this.report.AppendLine("scan stopped");
                        break;
                    }
                    this.WriteLastScan(url);
                    foundOne = false;
                    if (this.scannedUrls.Count >= this.maxpages)
                    {
                        break;
                    }
                    if (!this.scannedUrls.Contains(url))
                    {
                        foundOne = true;
                        this.scannedUrls.Add(url);
                        htmlText = this.GetWebText(url);
                        this.ParseLinks(htmlText);

                        this.WriteProgressBar(this.scannedUrls.Count);
                        this.ScanPage(htmlText, url);
                    }
                }
            }

            this.report.AppendLine();
            this.WriteProgressBar(this.maxpages);
            this.changeVisbilityStart(true);
            this.changeVisbilityStop(false);

            this.report.AppendLine(this.scannedUrls.Count + " pages scanned");
            foreach (string url in this.scannedUrls)
            {
                this.report.AppendLine(url);
            }

            this.report.AppendLine(this.urlsWithMatch.Count + " pages with match");
            foreach (string url in this.urlsWithMatch)
            {
                this.report.AppendLine(url);
            }
            this.report.AppendLine("Finished crawl.");
            this.WriteReport(this.report.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private string GetWebText(string url)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = "A .NET Web Crawler";
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                var reader = new StreamReader(stream);
                string htmlText = reader.ReadToEnd();
                return htmlText;
            }
            catch (Exception ee)
            {
                return "";
            }
        }

        private void ScanPage(string htmlText, string url)
        {
            MatchCollection matches = Regex.Matches(htmlText, this._MATCH_REGEX);
            int mc = matches.Count;
            if (matches.Count > 0)
            {
                this.urlsWithMatch.Add(url);
                this.WriteMatchesFound(this.urlsWithMatch.Count.ToString());
                this.WriteLastMatch(url);
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            this.stopMe = true;
        }

        private void start_Click(object sender, EventArgs e)
        {
            this.stopMe = false;
            this.maxpages = Convert.ToInt16(this.maxPages.Text);
            this.onlyBelow = OnlyBelow.Text;
            this.urls = new List<string>();
            this.scannedUrls = new List<string>();
            this.urlsWithMatch = new List<string>();
            this.report = new StringBuilder("");
            this._MATCH_REGEX = this.theRegex.Text;
            this.startUrl = this.starturl.Text;
            this.baseUrl = this.BaseUrl.Text;
            this.progressBar1.Minimum = 0;
            this.progressBar1.Value = 0;
            this.MatchesFound.Text = 0.ToString();
            this.progressBar1.Maximum = this.maxpages;

            new Thread(this.CrawlFunction).Start();
        }

        #endregion
    }
}