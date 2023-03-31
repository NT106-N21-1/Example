namespace lab2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text file|*.txt";
			if (openFileDialog.ShowDialog() == DialogResult.OK){
				string filePath = openFileDialog.FileName;
				
				FileStream fs = new FileStream(filePath, FileMode.Open);
				StreamReader sr = new StreamReader(fs);
				int lineCount = 0;
				while(sr.ReadLine() != null){
					lineCount++;
				}
				fs.Close();
				MessageBox.Show(lineCount.ToString());
			}
		}
	}
}