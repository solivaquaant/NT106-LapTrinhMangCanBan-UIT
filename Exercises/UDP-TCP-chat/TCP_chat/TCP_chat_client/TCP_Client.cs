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
using System.Net.Sockets;

namespace TCP_chat_client
{
    public partial class TCP_Client : Form
    {
        public TCP_Client()
        {
            InitializeComponent();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(textBox_port.Text);
            IPAddress ipadd = IPAddress.Parse(textBox_IP.Text);

            try
            {
                TcpClient tcpClient = new TcpClient(textBox_IP.Text, port);
                NetworkStream stream = tcpClient.GetStream();
                byte[] stringBytes = Encoding.UTF8.GetBytes(richTextBox_msg.Text);
                stream.Write(stringBytes, 0, stringBytes.Length);
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
