using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EmailClient
{
	public partial class SendMail : Form
	{
		public SendMail()
		{
			InitializeComponent();
			tbFrom.Text = "nvbao4566@gmail.com";
			tbFrom.ReadOnly = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var smtpClient = new SmtpClient();
			smtpClient.Connect("smtp.gmail.com", 465, true);
			smtpClient.Authenticate("nvbao4566@gmail.com", "");

			var message = new MimeMessage();
			message.From.Add(new MailboxAddress("Nguyen Van A", tbFrom.Text));
			message.To.Add(new MailboxAddress("", tbTo.Text));
			message.Subject = tbSubject.Text;
			message.Body = new TextPart("plain")
			{
				Text = rtbBody.Text
			};

			smtpClient.Send(message);
		}
	}
}
