namespace CrawlSite
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.starturl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.theRegex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.maxPages = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReportTxt = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.MatchesFound = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LastMatch = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lastScanPage = new System.Windows.Forms.Label();
            this.lastScan = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.progresText = new System.Windows.Forms.TextBox();
            this.BaseUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OnlyBelow = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // starturl
            // 
            this.starturl.Location = new System.Drawing.Point(16, 64);
            this.starturl.Name = "starturl";
            this.starturl.Size = new System.Drawing.Size(263, 20);
            this.starturl.TabIndex = 0;
            this.starturl.Text = "http://www.someurl.com/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starturl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Regex";
            // 
            // theRegex
            // 
            this.theRegex.Location = new System.Drawing.Point(288, 64);
            this.theRegex.Name = "theRegex";
            this.theRegex.Size = new System.Drawing.Size(263, 20);
            this.theRegex.TabIndex = 2;
            this.theRegex.Text = "\\b(word)\\b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Progress";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(558, 25);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // maxPages
            // 
            this.maxPages.Location = new System.Drawing.Point(16, 112);
            this.maxPages.Name = "maxPages";
            this.maxPages.Size = new System.Drawing.Size(57, 20);
            this.maxPages.TabIndex = 2;
            this.maxPages.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MaxPages";
            // 
            // ReportTxt
            // 
            this.ReportTxt.Location = new System.Drawing.Point(19, 223);
            this.ReportTxt.Multiline = true;
            this.ReportTxt.Name = "ReportTxt";
            this.ReportTxt.Size = new System.Drawing.Size(617, 325);
            this.ReportTxt.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(111, 112);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(399, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Matches";
            // 
            // MatchesFound
            // 
            this.MatchesFound.AutoSize = true;
            this.MatchesFound.Location = new System.Drawing.Point(196, 194);
            this.MatchesFound.Name = "MatchesFound";
            this.MatchesFound.Size = new System.Drawing.Size(13, 13);
            this.MatchesFound.TabIndex = 3;
            this.MatchesFound.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Last match";
            // 
            // LastMatch
            // 
            this.LastMatch.AutoSize = true;
            this.LastMatch.Location = new System.Drawing.Point(196, 172);
            this.LastMatch.Name = "LastMatch";
            this.LastMatch.Size = new System.Drawing.Size(31, 13);
            this.LastMatch.TabIndex = 3;
            this.LastMatch.Text = "none";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Last scan";
            // 
            // lastScanPage
            // 
            this.lastScanPage.AutoSize = true;
            this.lastScanPage.Location = new System.Drawing.Point(196, 150);
            this.lastScanPage.Name = "lastScanPage";
            this.lastScanPage.Size = new System.Drawing.Size(31, 13);
            this.lastScanPage.TabIndex = 3;
            this.lastScanPage.Text = "none";
            // 
            // lastScan
            // 
            this.lastScan.AutoSize = true;
            this.lastScan.Location = new System.Drawing.Point(439, 171);
            this.lastScan.Name = "lastScan";
            this.lastScan.Size = new System.Drawing.Size(0, 13);
            this.lastScan.TabIndex = 3;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(558, 25);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 7;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // progresText
            // 
            this.progresText.BackColor = System.Drawing.SystemColors.Control;
            this.progresText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progresText.Location = new System.Drawing.Point(516, 119);
            this.progresText.Name = "progresText";
            this.progresText.Size = new System.Drawing.Size(100, 13);
            this.progresText.TabIndex = 8;
            // 
            // BaseUrl
            // 
            this.BaseUrl.Location = new System.Drawing.Point(16, 25);
            this.BaseUrl.Name = "BaseUrl";
            this.BaseUrl.Size = new System.Drawing.Size(263, 20);
            this.BaseUrl.TabIndex = 0;
            this.BaseUrl.Text = "http://www.someurl.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Baseurl";
            // 
            // OnlyBelow
            // 
            this.OnlyBelow.Location = new System.Drawing.Point(285, 25);
            this.OnlyBelow.Name = "OnlyBelow";
            this.OnlyBelow.Size = new System.Drawing.Size(263, 20);
            this.OnlyBelow.TabIndex = 0;
            this.OnlyBelow.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Only pages below";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 576);
            this.Controls.Add(this.progresText);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ReportTxt);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastScan);
            this.Controls.Add(this.lastScanPage);
            this.Controls.Add(this.LastMatch);
            this.Controls.Add(this.MatchesFound);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxPages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.theRegex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BaseUrl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OnlyBelow);
            this.Controls.Add(this.starturl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox starturl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox theRegex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox maxPages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReportTxt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MatchesFound;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LastMatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lastScanPage;
        private System.Windows.Forms.Label lastScan;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox progresText;
        private System.Windows.Forms.TextBox BaseUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OnlyBelow;
        private System.Windows.Forms.Label label9;
    }
}

