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

namespace UDP_chat_server
{
    public partial class UDP_Server : Form
    {
        public UDP_Server()
        {
            InitializeComponent();
        }

        private async void button_listen_Click(object sender, EventArgs e)
        {
            try
            {
                int port;
                if (!int.TryParse(textBox_port_server.Text, out port))
                {
                    MessageBox.Show("Port không hợp lệ");
                    return;
                }
                UdpClient udpClient = new UdpClient(port);

                while (true)
                {
                    UdpReceiveResult result = await udpClient.ReceiveAsync();
                    string data = Encoding.UTF8.GetString(result.Buffer);
                    string message = result.RemoteEndPoint.Address.ToString() + ":" + result.RemoteEndPoint.Port.ToString() + ":" + data;
                    richTextBox_rmsg.Text = message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
