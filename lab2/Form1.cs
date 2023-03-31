using System.Runtime.Serialization.Formatters.Binary;

namespace lab2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		[Serializable]
		class Student
		{
			public string Name { get; set; }
			public string ID { get; set; }
			public string Phone { get; set; }
			public double Course1 { get; set; }
			public double Course2 { get; set; }
			public double Course3 { get; set; }
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text file|*.txt";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = openFileDialog.FileName;

				FileStream fs = new FileStream(filePath, FileMode.Open);
				StreamReader sr = new StreamReader(fs);
				int lineCount = 0;
				while (sr.ReadLine() != null)
				{
					lineCount++;
				}
				fs.Close();
				MessageBox.Show(lineCount.ToString());
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text file|*.txt";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.CreateNew);
				BinaryWriter bw = new BinaryWriter(fs);
				int[] myArray = new int[1000];
				for (int i = 0; i < myArray.Length; i++)
				{
					myArray[i] = i;
					bw.Write(myArray[i]);
				}
				bw.Close();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text file|*.txt";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = openFileDialog.FileName;
				FileInfo fileInfo = new FileInfo(filePath);
				long size = fileInfo.Length;
				string fileName = fileInfo.Name;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			List<Student> students = new List<Student>(){
				new Student(){ID="ABC12312", Name="Nguyen Van A", Course1=5, Course2=6, Course3=7},
				new Student(){ID="ABC123232", Name="Nguyen Van B", Course1=5.5, Course2=6.3, Course3=8},
				new Student(){ID="ABC123232", Name="Nguyen Van C", Course1=8, Course2=9, Course3=2},
			};

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text file|*.txt";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				FileStream file = File.Create(saveFileDialog.FileName);

				binaryFormatter.Serialize(file, students);
				file.Close();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text file|*.txt";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				BinaryFormatter binFormatter = new BinaryFormatter();
				FileStream file = File.OpenRead(openFileDialog.FileName);

				List<Student> students = binFormatter.Deserialize(file) as List<Student>;
				foreach (var student in students)
				{
				}
			}
		}
	}
}