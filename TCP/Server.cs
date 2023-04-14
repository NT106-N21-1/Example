using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP
{
    public partial class Server : Form
    {

        TcpListener tcpListener;
        IPEndPoint ipepServer;
        List<NetworkStream> networStreams = new List<NetworkStream>();
        public Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), (int)numericUpDown1.Value);
            tcpListener = new TcpListener(ipepServer);
            tcpListener.Start();

            StartUnsafeThread();
            //Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            //serverThread.Start();
        }

        private void AddConnectionDetail(string[] row)
        {
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
        }

        private void StartUnsafeThread()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            //AcceptConnection();
            Thread acceptConnection = new Thread(new ThreadStart(AcceptConnection));
            acceptConnection.Start();
        }

        private void ReceiveMessage(Socket client)
        {
            while (client.Connected)
            {
                byte[] recv = new byte[1024];
                client.Receive(recv);
                SendAll(Encoding.UTF8.GetString(recv).Replace("\0", ""));
                richTextBox1.Text += Encoding.UTF8.GetString(recv).Replace("\0", "") + "\n";
            }
        }

        private void SendRoomInfo()
        {
            string message = "";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                message += listView1.Items[i].SubItems[0].Text + ":" + listView1.Items[i].SubItems[1].Text + "#";
            }
            SendAll(message);
        }

        private void SendAll(string mess)
        {
            foreach (NetworkStream ns in networStreams)
            {
                byte[] data = Encoding.UTF8.GetBytes(mess);
                ns.Flush();
                ns.Write(data, 0, data.Length);
            }
        }

        private void AcceptConnection()
        {
            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                Socket client = tcpClient.Client;
                NetworkStream ns = tcpClient.GetStream();
                networStreams.Add(ns);
                
                string[] clientInfo = { ((IPEndPoint)client.RemoteEndPoint).Address.ToString(), ((IPEndPoint)client.RemoteEndPoint).Port.ToString() };
                //SendAll(((IPEndPoint)client.RemoteEndPoint).Address.ToString() + ((IPEndPoint)client.RemoteEndPoint).Port.ToString());
                AddConnectionDetail(clientInfo);
                SendRoomInfo();
                Thread acceptConnection = new Thread(() => ReceiveMessage(client));
                acceptConnection.Start();
            }
        }
    }
}
