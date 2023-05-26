namespace EmailClient
{
	partial class GetMail
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
			tbUsername = new TextBox();
			label1 = new Label();
			tbPassword = new TextBox();
			label2 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// tbUsername
			// 
			tbUsername.Location = new Point(112, 12);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(347, 23);
			tbUsername.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 20);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 1;
			label1.Text = "Username";
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(112, 41);
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '*';
			tbPassword.Size = new Size(347, 23);
			tbPassword.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 49);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// button1
			// 
			button1.Location = new Point(465, 12);
			button1.Name = "button1";
			button1.Size = new Size(75, 52);
			button1.TabIndex = 2;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// GetMail
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(552, 116);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbPassword);
			Controls.Add(tbUsername);
			Name = "GetMail";
			Text = "GetMail";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbUsername;
		private Label label1;
		private TextBox tbPassword;
		private Label label2;
		private Button button1;
	}
}