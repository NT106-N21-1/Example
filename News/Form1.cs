using HtmlAgilityPack;

namespace News
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			textBox1.Text = "https://vnexpress.net/the-gioi/tu-lieu";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			HtmlWeb web = new HtmlWeb();
			var htmlDoc = web.Load(textBox1.Text);

			var articles = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"automation_TV0\"]/div[2]/article");
			foreach (var article in articles)
			{
				var title = article.SelectSingleNode("./h2").InnerText.Trim();
				var description = article.SelectSingleNode("./p").InnerText.Trim();
				var imgUrl = article.SelectSingleNode("./div/a/picture/img").Attributes["src"].Value;
				var url = article.SelectSingleNode("./h2/a").Attributes["href"].Value;


			}
		}
	}
}