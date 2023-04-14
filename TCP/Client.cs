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
    public partial class Client : Form
    {
        TcpClient tcpClient = new TcpClient();
        NetworkStream ns;

        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = IPAddress.Parse(textBox1.Text);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, (int)numericUpDown1.Value);

            tcpClient.Connect(ipEndPoint);
            ns = tcpClient.GetStream();

            
            if (tcpClient.Connected)
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
            }
            Socket client = tcpClient.Client;
            Thread acceptConnection = new Thread(() => ReceiveMessage(client));
            acceptConnection.Start();
        }

        private void ReceiveMessage(Socket client)
        {
            while (true)
            {
                try
                {
                    byte[] recv = new byte[1024];
                    client.Receive(recv);
                    string message = Encoding.UTF8.GetString(recv).Replace("\0", "").Replace("\r", "").Replace("\n", "");

                    for (int i = 0; i < message.Split('#').Length-1; i++)
                    {
                        string[] clientInfo = { message.Split('#')[i].Split(':')[0], message.Split('#')[i].Split(':')[1] };
                        bool addItem = true;

                        for (int j = 0; j < listView1.Items.Count; j++)
                        {
                            if (listView1.Items[j].SubItems[0].Text == message.Split('#')[i].Split(':')[0] && listView1.Items[j].SubItems[1].Text == message.Split('#')[i].Split(':')[1])
                            {
                                addItem = false;
                            }
                        }
                        if (addItem)
                        {
                            var listViewItem = new ListViewItem(clientInfo);
                            listView1.Items.Add(listViewItem);
                            //richTextBox1.Text += message + "\n";
                        }
                    }
                    
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }


        private void listView1_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = listView1.SelectedItems[0];
            MessageBox.Show(firstSelectedItem.SubItems[0].Text + ":" + firstSelectedItem.SubItems[1].Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(textBox2.Text);
            ns.Write(data, 0, data.Length);
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcpClient.Close();
        }
    }
}
