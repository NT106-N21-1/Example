using System.Net;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace UserView
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		class User
		{
			[JsonPropertyName("id")]
			public int Id { get; set; }
			[JsonPropertyName("first_name")]
			public string FirstName { get; set; }
			[JsonPropertyName("last_name")]
			public string LastName { get; set; }
			[JsonPropertyName("email")]
			public string Email { get; set; }
			[JsonPropertyName("avatar")]
			public string Avatar { get; set; }
		}

		class UserPagination
		{
			[JsonPropertyName("page")]
			public int Page { get; set; }
			[JsonPropertyName("total")]
			public int Total { get; set; }
			[JsonPropertyName("per_page")]
			public int PerPage { get; set; }
			[JsonPropertyName("total_pages")]
			public int TotalPages { get; set; }
			[JsonPropertyName("data")]
			public List<User> Data { get; set; }
		}

		private string GetHTML(string szURL)
		{
			// Create a request for the URL.
			WebRequest request = WebRequest.Create(szURL);
			// Get the response. 
			WebResponse response = request.GetResponse();
			// Get the stream containing content returned by the server. 
			Stream dataStream = response.GetResponseStream();
			// Open the stream using a StreamReader for easy access. 
			StreamReader reader = new StreamReader(dataStream);
			// Read the content. 
			string responseFromServer = reader.ReadToEnd();
			// Close the response. 
			response.Close();
			return responseFromServer;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var url = "https://reqres.in/api/users?page=1";
			var res = GetHTML(url);

			var data = JsonSerializer.Deserialize<UserPagination>(res);

			int i = 0;
			foreach (var user in data.Data)
			{
				i++;
				Label label = new Label();
				label.Text = user.FirstName + " " + user.LastName;
				label.Location = new Point(0, i * 50);

				panel1.Controls.Add(label);
			}
		}
	}
}