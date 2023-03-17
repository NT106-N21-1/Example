namespace Lab1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int soA = int.Parse(tbSoA.Text);
			int soB = int.Parse(tbSoB.Text);
			int sum = soA + soB;

			tbTong.Text = sum.ToString();
		}
	}
}