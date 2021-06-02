using System;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace UNICC_Parser
{
    public static class AntiGate
    {
        private const int TryCount = 20;

        private const int WaitMillisecBeforeRequest = 3000;

        public static string AntiGateServer = "rucaptcha.com";

        public static string AntiGateKey;

        public static string LastCaptchaId;

        public static string GetBalance(string antiGateKey = null)
        {
            antiGateKey = (antiGateKey ?? AntiGateKey);
            using (WebClient webClient = new WebClient())
            {
                return webClient.DownloadString($"http://{AntiGateServer}/res.php?key={antiGateKey}&action=getbalance");
            }
        }

        public static string ReportBad(string captchaId, string antiGateKey = null)
        {
            antiGateKey = (antiGateKey ?? AntiGateKey);
            using (WebClient webClient = new WebClient())
            {
                return webClient.DownloadString($"http://{AntiGateServer}/res.php?key={antiGateKey}&action=reportbad&id={captchaId}");
            }
        }

        public static string Recognize(Stream imageStream, int minLen = 0, int maxLen = 0, bool isNumeric = false, bool isPhrase = false, bool isRegSense = false, bool isCalc = false, bool isRussian = false, string antiGateKey = null)
        {
            antiGateKey = (antiGateKey ?? AntiGateKey);
            byte[] array = new byte[16384];
            byte[] imageData;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                int count;
                while ((count = imageStream.Read(array, 0, array.Length)) > 0)
                {
                    memoryStream.Write(array, 0, count);
                }
                imageData = memoryStream.ToArray();
            }
            return Recognize(imageData, minLen, maxLen, isNumeric, isPhrase, isRegSense, isCalc, isRussian, antiGateKey);
        }

        public static string Recognize(Image image, int minLen = 0, int maxLen = 0, bool isNumeric = false, bool isPhrase = false, bool isRegSense = false, bool isCalc = false, bool isRussian = false, string antiGateKey = null)
        {
            antiGateKey = (antiGateKey ?? AntiGateKey);
            byte[] imageData;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                imageData = memoryStream.ToArray();
            }
            return Recognize(imageData, minLen, maxLen, isNumeric, isPhrase, isRegSense, isCalc, isRussian, antiGateKey);
        }

        public static string Recognize(string imageUrlOrFile, string cookies = null, int minLen = 0, int maxLen = 0, bool isNumeric = false, bool isPhrase = false, bool isRegSense = false, bool isCalc = false, bool isRussian = false, string antiGateKey = null)
        {
            antiGateKey = (antiGateKey ?? AntiGateKey);
            byte[] imageData;
            if (imageUrlOrFile.Contains("://"))
            {
                using (WebClient webClient = new WebClient())
                {
                    if (cookies != null)
                    {
                        webClient.Headers.Add("Cookie", cookies);
                    }
                    imageData = webClient.DownloadData(imageUrlOrFile);
                }
            }
            else
            {
                if (!File.Exists(imageUrlOrFile))
                {
                    return "ERROR_FILE_NOT_FOUND";
                }
                imageData = File.ReadAllBytes(imageUrlOrFile);
            }
            return Recognize(imageData, minLen, maxLen, isNumeric, isPhrase, isRegSense, isCalc, isRussian, antiGateKey);
        }

        public static string Recognize(byte[] imageData, int minLen = 0, int maxLen = 0, bool isNumeric = false, bool isPhrase = false, bool isRegSense = false, bool isCalc = false, bool isRussian = false, string antiGateKey = null)
        {
            antiGateKey = (antiGateKey ?? AntiGateKey);
            NameValueCollection nameValueCollection = new NameValueCollection
            {
                {
                    "key",
                    antiGateKey
                },
                {
                    "method",
                    "base64"
                },
                {
                    "soft_id",
                    "597"
                },
                {
                    "body",
                    Convert.ToBase64String(imageData)
                }
            };
            if (minLen > 0)
            {
                nameValueCollection.Add("min_len", minLen.ToString());
            }
            if (maxLen > 0)
            {
                nameValueCollection.Add("max_len", maxLen.ToString());
            }
            if (isNumeric)
            {
                nameValueCollection.Add("numeric", "1");
            }
            if (isPhrase)
            {
                nameValueCollection.Add("phrase", "1");
            }
            if (isRegSense)
            {
                nameValueCollection.Add("regsense", "1");
            }
            if (isCalc)
            {
                nameValueCollection.Add("calc", "1");
            }
            if (isRussian)
            {
                nameValueCollection.Add("is_russian", "1");
            }
            string text = "";
            using (WebClient webClient = new WebClient())
            {
                for (int i = 0; i < 20; i++)
                {
                    text = Encoding.UTF8.GetString(webClient.UploadValues("http://" + AntiGateServer + "/in.php", nameValueCollection));
                    if (text.Contains("OK|"))
                    {
                        break;
                    }
                    if (text.Contains("ERROR_NO_SLOT_AVAILABLE"))
                    {
                        Thread.Sleep(3000);
                        continue;
                    }
                    if (text.Contains("ERROR_"))
                    {
                        return text;
                    }
                    if (!text.Contains("OK|"))
                    {
                        return "UNKNOWN_ERROR: " + text;
                    }
                }
                if (text.Contains("ERROR_"))
                {
                    return text;
                }
                string arg = LastCaptchaId = text.Replace("OK|", "").Trim();
                for (int j = 0; j < 20; j++)
                {
                    Thread.Sleep(3000);
                    text = webClient.DownloadString($"http://{AntiGateServer}/res.php?key={antiGateKey}&action=get&id={arg}");
                    if (!text.Contains("ERROR_NO_SLOT_AVAILABLE"))
                    {
                        if (text.Contains("ERROR_"))
                        {
                            return text;
                        }
                        if (text.Contains("OK|"))
                        {
                            return text.Replace("OK|", "").Trim();
                        }
                    }
                }
                return text;
            }
        }
    }
}
