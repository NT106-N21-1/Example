namespace EmailClient
{
	partial class SendMail
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tbFrom = new TextBox();
			label1 = new Label();
			tbTo = new TextBox();
			label2 = new Label();
			tbSubject = new TextBox();
			label3 = new Label();
			label4 = new Label();
			rtbBody = new RichTextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// tbFrom
			// 
			tbFrom.Location = new Point(78, 12);
			tbFrom.Name = "tbFrom";
			tbFrom.Size = new Size(334, 23);
			tbFrom.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 20);
			label1.Name = "label1";
			label1.Size = new Size(35, 15);
			label1.TabIndex = 1;
			label1.Text = "From";
			// 
			// tbTo
			// 
			tbTo.Location = new Point(78, 41);
			tbTo.Name = "tbTo";
			tbTo.Size = new Size(334, 23);
			tbTo.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 49);
			label2.Name = "label2";
			label2.Size = new Size(19, 15);
			label2.TabIndex = 1;
			label2.Text = "To";
			// 
			// tbSubject
			// 
			tbSubject.Location = new Point(78, 70);
			tbSubject.Name = "tbSubject";
			tbSubject.Size = new Size(334, 23);
			tbSubject.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 78);
			label3.Name = "label3";
			label3.Size = new Size(46, 15);
			label3.TabIndex = 1;
			label3.Text = "Subject";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 107);
			label4.Name = "label4";
			label4.Size = new Size(34, 15);
			label4.TabIndex = 1;
			label4.Text = "Body";
			// 
			// rtbBody
			// 
			rtbBody.Location = new Point(78, 107);
			rtbBody.Name = "rtbBody";
			rtbBody.Size = new Size(334, 207);
			rtbBody.TabIndex = 2;
			rtbBody.Text = "";
			// 
			// button1
			// 
			button1.Location = new Point(337, 320);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 3;
			button1.Text = "Send";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// SendMail
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(422, 350);
			Controls.Add(button1);
			Controls.Add(rtbBody);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbSubject);
			Controls.Add(tbTo);
			Controls.Add(tbFrom);
			Name = "SendMail";
			Text = "SendMail";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbFrom;
		private Label label1;
		private TextBox tbTo;
		private Label label2;
		private TextBox tbSubject;
		private Label label3;
		private Label label4;
		private RichTextBox rtbBody;
		private Button button1;
	}
}