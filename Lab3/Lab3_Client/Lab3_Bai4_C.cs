using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Net.Http;

namespace Lab3_Client
{
    public partial class Lab3_Bai4_C : Form
    {

        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private Thread receiveThread;
        private string username;

        public Lab3_Bai4_C()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        StreamWriter streamWriter;
        StreamReader streamReader;
        TcpClient tcpClient = new TcpClient();
        private void ReceiveMessage()
        {
            try
            {
                while (tcpClient.Connected)
                {
                    String receiveMessage = streamReader.ReadLine();
                    if (receiveMessage != null)
                    {
                        richTextBox1.AppendText(receiveMessage + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                streamReader.Close();
                streamWriter.Close();
                tcpClient.Close();
            }
        }


       

        private void CBut_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBox1.Text;
                if (String.IsNullOrEmpty(name))
                {
                    throw new Exception("Nhập tên client");
                }
                if (!tcpClient.Connected)
                {
                    CheckForIllegalCrossThreadCalls = false;
                    tcpClient.Connect(iPEndPoint);
                    textBox1.Enabled = false;
                    CBut.Enabled = false;
                    streamReader = new StreamReader(tcpClient.GetStream());
                    streamWriter = new StreamWriter(tcpClient.GetStream());
                    streamWriter.AutoFlush = true;
                    Thread thread = new Thread(new ThreadStart(ReceiveMessage));
                    thread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

            private void button1_Click_1(object sender, EventArgs e)
            {
            try
            {
                String name = textBox1.Text;
                String messaage = textBox2.Text;
                if (String.IsNullOrEmpty(messaage))
                {
                    throw new Exception("Nhập tin nhắn");
                }
                streamWriter.WriteLine(name + ": " + messaage);
                streamWriter.Flush();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
    }




}
