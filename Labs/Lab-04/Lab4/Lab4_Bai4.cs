using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;


namespace Lab4
{
    public partial class Lab4_Bai4 : Form
    {
        public Lab4_Bai4()
        {
            InitializeComponent();
        }

        private void downBut_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            string url = url_textBox.Text;

            using (WebClient myClient = new WebClient())
            {
                string content = myClient.DownloadString(url);
                //WebContent.Text = content;
                myClient.DownloadFile(url, sfd.FileName);
            }

            try
            {
                if (webView != null && webView.CoreWebView2 != null)
                {
                    webView.CoreWebView2.Navigate(url_textBox.Text);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Đường dẫn không hợp lệ!");
            }
        }

        private void buttonViewSource_Click(object sender, EventArgs e)
        {
            string url = url_textBox.Text;

            try
            {
                using (WebClient myClient = new WebClient())
                {
                    string sourceCode = myClient.DownloadString(url);

                    Lab4_Bai4_ViewSource sourceForm = new Lab4_Bai4_ViewSource();
                    sourceForm.SourceCode = sourceCode;
                    sourceForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
