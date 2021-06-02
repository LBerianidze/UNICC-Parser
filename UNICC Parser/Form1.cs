using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNICC_Parser.Properties;

namespace UNICC_Parser
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			rucaptchaApiKeyTextBox.Text = Settings.Default.apikey;
			domain = File.ReadAllText("domain.txt");
		}
		public string domain { get; }
		List<string> files = new List<string>();
		object locker1 = new object(), locker2 = new object(), locker3 = new object(), locker4 = new object();
		string filename = "";
		private async void start_Click(object sender, EventArgs e)
		{
			try
			{
				File.Delete("logs.txt");
			}
			catch
			{

			}
			showInExplorerButton.Enabled = false;
			files.Clear();
			filename = "";
			label8.Text = label4.Text = label6.Text = "0";
			var users = accountsRichTextBox.Lines.Where(t => !string.IsNullOrWhiteSpace(t)).Select(t => t.Split(':')).ToList();
			var proxies = richTextBox2.Lines.Where(t => !string.IsNullOrWhiteSpace(t)).Select(t => t.Split(':')).ToList();
			AntiGate.AntiGateKey = rucaptchaApiKeyTextBox.Text;
			List<Task> results = new List<Task>();
			DateTime dt = default(DateTime);
			if (parseForLastNDaysRadio.Checked)
			{
				dt = DateTime.Now.Subtract(new TimeSpan((int)numericUpDown1.Value, 0, 0, 0));
			}
			else if (parseFromRadio.Checked)
			{
				dt = dateTimePicker1.Value;
			}
			string folder = Application.StartupPath + $"\\result_{DateTime.Now.ToString("MM.dd.yyyy HH-mm-ss")}";
			string separated_folder = folder + "\\all_files";

			Directory.CreateDirectory(separated_folder);
			for (int i = 0; i < users.Count; i++)
			{
				int j = i;
				results.Add(Task.Run(() => new Parser(users[j][0], users[j][1], proxies[j][0], proxies[j][1],dt, separated_folder, this).Run()));
			}
			await Task.WhenAll(results.ToArray());
			File.WriteAllText(folder + "\\files.txt", string.Join("", files.SelectMany(t => t.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Skip(2))));
			File.WriteAllLines(folder + "\\good.txt", richTextBox3.Lines);
			File.WriteAllLines(folder + "\\bad.txt", richTextBox4.Lines);
			showInExplorerButton.Enabled = true;
			MessageBox.Show("Обработка завершена");
		}

		private void rucaptchaApiKeyTextBox_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.apikey = rucaptchaApiKeyTextBox.Text;
			Settings.Default.Save();
		}

		private void accountsRichTextBox_TextChanged(object sender, EventArgs e)
		{
			label3.Text = accountsRichTextBox.Lines.Where(t => !string.IsNullOrWhiteSpace(t)).Count().ToString();
		}
		public void AddSuccessAccount(string text)
		{
			this.BeginInvoke(new ThreadStart(() =>
				{
					richTextBox3.AppendText(text);
					label8.Text = (Convert.ToInt32(label8.Text) + 1).ToString();
					label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
				}));
		}
		public void AddFailedAccount(string text)
		{
			this.BeginInvoke(new ThreadStart(() =>
			{
				richTextBox4.AppendText(text);
				label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
				label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
			}));
		}

		private void showInExplorerButton_Click(object sender, EventArgs e)
		{
			string argument = "/select, \"" + filename + "\"";

			System.Diagnostics.Process.Start("explorer.exe", argument);
		}
		public void IncrementFilesCount(List<string> newFiles)
		{
			lock (locker1)
			{
				this.BeginInvoke(new ThreadStart(() =>
				{
					label10.Text = (Convert.ToInt32(label10.Text) + newFiles.Count).ToString();
				}));
				files.AddRange(newFiles);
			}
		}
	}
}