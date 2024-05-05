using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Server
{
    public partial class Lab3_Bai4_S : Form
    {
       
        TcpListener serverSocket = new TcpListener(IPAddress.Any, 8080);
        List<TcpClient> clientsList = new List<TcpClient>();

        public Lab3_Bai4_S()
        {
            InitializeComponent();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread acceptThread = new Thread(AcceptClients);
            acceptThread.Start();
        }

        private void AcceptClients()
        {
            try
            {
                lv_Message.AppendText("Server running on 127.0.0.1:8080" + "\r\n");
                serverSocket.Start();
                while (true)
                {
                    TcpClient clientSocket = serverSocket.AcceptTcpClient();
                    clientsList.Add(clientSocket);
                    if (clientSocket.Connected)
                    {
                        lv_Message.AppendText("New client connected" + "\r\n");
                    }
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                    clientThread.IsBackground = true;
                    clientThread.Start(clientSocket);
                }
                serverSocket.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void HandleClient(Object _client)
        {
            TcpClient client = (TcpClient)_client;
            try
            {
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                writer.AutoFlush = true;
                while (true)
                {
                    string message = reader.ReadLine();
                    if (message != null)
                    {
                        BroadcastMessage(message);
                        lv_Message.AppendText(message + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Close();
            }
        }

        private void BroadcastMessage(string message)
        {
            foreach (TcpClient client in clientsList)
            {
                StreamWriter writer = new StreamWriter(client.GetStream());
                writer.AutoFlush = true;
                writer.WriteLine(message);
            }
        }
    }
}



