using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			form1.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Vui Nhap So Nguyen");
		}
	}
}
