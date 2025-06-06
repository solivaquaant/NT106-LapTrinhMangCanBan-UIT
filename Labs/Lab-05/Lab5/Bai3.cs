using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;



namespace Lab5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void textBoxPsw_TextChanged(object sender, EventArgs e)
        {

        }
        public bool IsGmailAddressValid(string emailAddress)
        {
            // Định dạng email Gmail: username@gmail.com
            string gmailPattern = @"^[a-zA-Z0-9_.+-]+@gmail.com$";

            // Kiểm tra định dạng email sử dụng biểu thức chính quy
            return Regex.IsMatch(emailAddress, gmailPattern);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string mailfrom = textBoxFromMail.Text.Trim();
            string mailto = textBoxToMail.Text.Trim();
            string password = textBoxPsw.Text.Trim();
            string subject = textBoxSubject.Text.Trim();
            string body = richTextBoxBody.Text.Trim();

            SendMail(subject, body, mailto, mailfrom, password);
        }

        private void SendMail(string subject, string body, string mailto, string mailfrom, string password)
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(mailfrom, password);

                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    message.From = fromAddress;
                    message.Subject = subject;
                    //  message.IsBodyHtml = true;
                    message.To.Add(mailto);
                    message.Body = body;

                    string[] fileNames = richTextBoxAttach.Text.Split(';');
                    foreach (string fileName in fileNames)
                    {
                        if (!string.IsNullOrWhiteSpace(fileName))
                        {
                            Attachment attachment = new Attachment(fileName);
                            message.Attachments.Add(attachment);
                        }
                    }

                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Send Mail Successfully!");
                        CleanUp();

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }

        private void buttonAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Phân tách đường dẫn của mỗi file bằng dấu ;
                string[] fileNames = ofd.FileNames;
                richTextBoxAttach.Text = string.Join(";", fileNames);
            }
        }
        private void CleanUp()
        {
            textBoxFromMail.Text = "";
            textBoxToMail.Text = "";
            textBoxPsw.Text = "";
            textBoxSubject.Text = "";
            richTextBoxBody.Text = "";
            richTextBoxAttach.Text = "";

        }

        private void textBoxFromMail_TextChanged(object sender, EventArgs e)
        {
            if (IsGmailAddressValid(textBoxFromMail.Text))
            {
                isMail.Text = "";
            }
            else
            {
                isMail.Text = "Không đúng định dạng Mail";
            }
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void textBoxToMail_TextChanged(object sender, EventArgs e)
        {
            if (IsGmailAddressValid(textBoxToMail.Text))
            {
                isMail2.Text = "";
            }
            else
            {
                isMail2.Text = "Không đúng định dạng Mail";
            }
        }
    }
}
