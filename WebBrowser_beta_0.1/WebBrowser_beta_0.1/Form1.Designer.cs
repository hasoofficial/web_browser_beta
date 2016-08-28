namespace WebBrowser_beta_0._1
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
            this.components = new System.ComponentModel.Container();
            this.Geri = new System.Windows.Forms.Button();
            this.İleri = new System.Windows.Forms.Button();
            this.AnaSayfa = new System.Windows.Forms.Button();
            this.Yenile = new System.Windows.Forms.Button();
            this.Git = new System.Windows.Forms.Button();
            this.Dur = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Geri
            // 
            this.Geri.Location = new System.Drawing.Point(25, 18);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(50, 50);
            this.Geri.TabIndex = 0;
            this.Geri.Text = "Geri\r\n";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // İleri
            // 
            this.İleri.Location = new System.Drawing.Point(77, 18);
            this.İleri.Name = "İleri";
            this.İleri.Size = new System.Drawing.Size(50, 50);
            this.İleri.TabIndex = 1;
            this.İleri.Text = "İleri";
            this.İleri.UseVisualStyleBackColor = true;
            this.İleri.Click += new System.EventHandler(this.İleri_Click);
            // 
            // AnaSayfa
            // 
            this.AnaSayfa.Location = new System.Drawing.Point(152, 18);
            this.AnaSayfa.Name = "AnaSayfa";
            this.AnaSayfa.Size = new System.Drawing.Size(50, 50);
            this.AnaSayfa.TabIndex = 2;
            this.AnaSayfa.Text = "Ana Sayfa\r\n";
            this.AnaSayfa.UseVisualStyleBackColor = true;
            this.AnaSayfa.Click += new System.EventHandler(this.AnaSayfa_Click);
            // 
            // Yenile
            // 
            this.Yenile.Location = new System.Drawing.Point(204, 18);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(50, 50);
            this.Yenile.TabIndex = 3;
            this.Yenile.Text = "\r\nYenile\r\n\r\n";
            this.Yenile.UseVisualStyleBackColor = true;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            // 
            // Git
            // 
            this.Git.Location = new System.Drawing.Point(768, 18);
            this.Git.Name = "Git";
            this.Git.Size = new System.Drawing.Size(50, 50);
            this.Git.TabIndex = 4;
            this.Git.Text = "Git";
            this.Git.UseVisualStyleBackColor = true;
            this.Git.Click += new System.EventHandler(this.Git_Click);
            // 
            // Dur
            // 
            this.Dur.Location = new System.Drawing.Point(820, 18);
            this.Dur.Name = "Dur";
            this.Dur.Size = new System.Drawing.Size(50, 50);
            this.Dur.TabIndex = 5;
            this.Dur.Text = "Dur";
            this.Dur.UseVisualStyleBackColor = true;
            this.Dur.Click += new System.EventHandler(this.Dur_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(287, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(461, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 74);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 74);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(894, 386);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.progress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(894, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Durum:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel2.Text = "Hazır";
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(100, 16);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Internet Explorer Tabanlıdır.\r\nHasan Ali Özdemir.";
            this.notifyIcon1.BalloonTipTitle = "Bilgi";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 460);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Dur);
            this.Controls.Add(this.Git);
            this.Controls.Add(this.Yenile);
            this.Controls.Add(this.AnaSayfa);
            this.Controls.Add(this.İleri);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Button İleri;
        private System.Windows.Forms.Button AnaSayfa;
        private System.Windows.Forms.Button Yenile;
        private System.Windows.Forms.Button Git;
        private System.Windows.Forms.Button Dur;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

