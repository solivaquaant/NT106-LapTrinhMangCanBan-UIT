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

namespace UDP_chat
{
    public partial class UDP_Client : Form
    {
        public UDP_Client()
        {
            InitializeComponent();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient();
            IPAddress ipadd = IPAddress.Parse(textBox_IP.Text);
            int port = Convert.ToInt32(textBox_port.Text);
            IPEndPoint ipendpoint = new IPEndPoint(ipadd, port);
            byte[] stringByte = Encoding.UTF8.GetBytes(richTextBox_msg.Text);
            client.Send(stringByte, stringByte.Length, ipendpoint);
            richTextBox_msg.Text = "";
        }
    }
}
