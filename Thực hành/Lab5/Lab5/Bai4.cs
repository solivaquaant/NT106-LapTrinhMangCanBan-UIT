using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MailKit.Net.Imap;
using MailKit.Security;
using MailKit;
using System.Reflection.Emit;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MimeKit;
using System.Text.RegularExpressions;


namespace Lab5
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        public bool IsGmailAddressValid(string emailAddress)
        {
            string gmailPattern = @"^[a-zA-Z0-9_.+-]+@gmail.com$";
            return Regex.IsMatch(emailAddress, gmailPattern);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            listView1.Columns.Add("Email", 400);
            listView1.Columns.Add("From", 200);
            listView1.Columns.Add("Thời gian", 200);
            listView1.View = View.Details;

            using (var client = new ImapClient())
            {
                client.Connect("imap.gmail.com", 993, true);

                client.Authenticate(textBoxMail.Text, textBoxPsw.Text);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);


                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);

                    ListViewItem name = new ListViewItem(message.Subject);
                    ListViewItem.ListViewSubItem from = new
                    ListViewItem.ListViewSubItem(name, message.From.ToString());
                    name.SubItems.Add(from);
                    ListViewItem.ListViewSubItem date = new
                    ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                    name.SubItems.Add(date);
                    listView1.Items.Add(name);
                    total.Text = inbox.Count.ToString();
                    recent.Text = inbox.Recent.ToString();
                }
                client.Disconnect(true);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string mailfrom = textBoxMail.Text.Trim();
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
        private void CleanUp()
        {
            textBoxToMail.Text = "";
            textBoxSubject.Text = "";
            richTextBoxBody.Text = "";
            richTextBoxAttach.Text = "";

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

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            if (IsGmailAddressValid(textBoxMail.Text))
            {
                isMail.Text = "";
            }
            else
            {
                isMail.Text = "Không đúng định dạng Mail";
            }
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
