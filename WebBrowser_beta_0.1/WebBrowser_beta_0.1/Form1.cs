using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowser_beta_0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
            progress.Visible = false;
            notifyIcon1.ShowBalloonTip(500000);

        }

        private void AnaSayfa_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();

        }

        private void İleri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Dur_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void Git_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(comboBox1.Text);
            this.Text = webBrowser1.DocumentTitle.ToString();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            comboBox1.Text = webBrowser1.Url.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = webBrowser1.StatusText;
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                progress.Visible = true;
                progress.Maximum = Convert.ToInt32(e.MaximumProgress);
                progress.Value = Convert.ToInt32(e.CurrentProgress);
                
                    
            }
            catch {
                progress.Value = 0;
                progress.Visible = false;
            }

        }

      
    }
}
