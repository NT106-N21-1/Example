namespace WebBrowser
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
			tbURL = new TextBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
			SuspendLayout();
			// 
			// webView21
			// 
			webView21.AllowExternalDrop = true;
			webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			webView21.CreationProperties = null;
			webView21.DefaultBackgroundColor = Color.White;
			webView21.Location = new Point(12, 41);
			webView21.Name = "webView21";
			webView21.Size = new Size(804, 549);
			webView21.TabIndex = 0;
			webView21.ZoomFactor = 1D;
			// 
			// tbURL
			// 
			tbURL.Location = new Point(12, 12);
			tbURL.Name = "tbURL";
			tbURL.Size = new Size(564, 23);
			tbURL.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(582, 12);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 2;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(663, 12);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 3;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(744, 12);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 4;
			button3.Text = "button3";
			button3.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(828, 602);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(tbURL);
			Controls.Add(webView21);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)webView21).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
		private TextBox tbURL;
		private Button button1;
		private Button button2;
		private Button button3;
	}
}