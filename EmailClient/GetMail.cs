using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailClient
{
	public partial class GetMail : Form
	{
		public GetMail()
		{
			InitializeComponent();
			tbUsername.Text = "nvbao4566@gmail.com";
			tbPassword.Text = "ybaucbcbjvogwbyo";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var imapClient = new ImapClient();
			imapClient.Connect("imap.gmail.com", 993, true);
			imapClient.Authenticate(tbUsername.Text, tbPassword.Text);

			var inbox = imapClient.Inbox;
			inbox.Open(FolderAccess.ReadOnly);
			for (int i = inbox.Count - 1; i >= inbox.Count - 1 - 10; i--)
			{
				var message = inbox.GetMessage(i);
				var subject = message.Subject;
				var date = message.Date;
				var from = message.From;
			}
		}
	}
}
