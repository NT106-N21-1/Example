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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectAvatar(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image file|*.png;*.jpg;*.jpeg|All files|*.*";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbAvatar.Text = dialog.FileName;
                dialog.Dispose();
            }
        }

        private void ConnectServer()
        {
            int serverPort = 1024;
            try
            {
                TcpClient client = new TcpClient();

                client.Connect("127.0.0.1", serverPort);
                Stream stream = client.GetStream();

                while (true)
                {
                    var reader = new StreamReader(stream);
                    var writer = new StreamWriter(stream);

                    writer.AutoFlush = true;

                    writer.WriteLine("Connect");
                    string str = reader.ReadLine();

                    MessageBox.Show(str, "Client");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            };
        }

        private void SubmitForm(object sender, EventArgs e)
        {
            string fullname = tbName.Text;
            string gender = rbMale.Checked ? "Nam" : "Nữ";
            string birthday = dtpBirthday.Text;
            string avt = tbAvatar.Text;
            string password = tbPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;
            string combobox = comboBox1.Text;

            MessageBox.Show(combobox);
            
        }
    } 
}
