using System;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace TextConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            InputText.Select();
            OutputText.ReadOnly = true;
        }

        private void Base64EncodeBtn_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(InputText.Text);
            OutputText.Text = Convert.ToBase64String(bytes);
        }

        private void Base64DncodeBtn_Click(object sender, EventArgs e)
        {
            byte[] bytes = Convert.FromBase64String(InputText.Text);
            OutputText.Text = Encoding.UTF8.GetString(bytes);
        }

        private void Md5EncodeBtn_Click(object sender, EventArgs e)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = Encoding.Default.GetBytes(InputText.Text);
            byte[] crypto = md5.ComputeHash(bytes);
            OutputText.Text = Convert.ToBase64String(crypto);
        }

        private void Sha1EncodeBtn_Click(object sender, EventArgs e)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytes = Encoding.Default.GetBytes(InputText.Text);
            byte[] crypto = sha1.ComputeHash(bytes);
            OutputText.Text = Convert.ToBase64String(crypto);
        }

        private void Sha256EncodeBtn_Click(object sender, EventArgs e)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            byte[] bytes = Encoding.Default.GetBytes(InputText.Text);
            byte[] crypto = sha256.ComputeHash(bytes);
            OutputText.Text = Convert.ToBase64String(crypto);
        }

        private void Sha384EncodeBtn_Click(object sender, EventArgs e)
        {
            SHA384 sha384 = new SHA384CryptoServiceProvider();
            byte[] bytes = Encoding.Default.GetBytes(InputText.Text);
            byte[] crypto = sha384.ComputeHash(bytes);
            OutputText.Text = Convert.ToBase64String(crypto);
        }

        private void Sha512EncodeBtn_Click(object sender, EventArgs e)
        {
            SHA512 sha512 = new SHA512CryptoServiceProvider();
            byte[] bytes = Encoding.Default.GetBytes(InputText.Text);
            byte[] crypto = sha512.ComputeHash(bytes);
            OutputText.Text = Convert.ToBase64String(crypto);
        }

        private void UrlEncodeBtn_Click(object sender, EventArgs e)
        {
            OutputText.Text = HttpUtility.UrlEncode(InputText.Text);
        }

        private void UrlDecodeBtn_Click(object sender, EventArgs e)
        {
            OutputText.Text = HttpUtility.UrlDecode(InputText.Text);
        }

        private void UnicodeEncodeBtn_Click(object sender, EventArgs e)
        {
            OutputText.Text = UnicodeEncode(InputText.Text);
        }

        private void UnicodeDecodeBtn_Click(object sender, EventArgs e)
        {
            OutputText.Text = UnicodeDecode(InputText.Text);
        }

        public string UnicodeEncode(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                sb.Append("\\u");
                sb.Append(string.Format("{0:x4}", (int)c));
            }
            return sb.ToString();
        }

        public string UnicodeDecode(string unicode)
        {
            string[] words = unicode.Split(new string[] { "\\u" }, StringSplitOptions.None);

            StringBuilder sb = new StringBuilder();
            for (int i=1; i<words.Length; i++)
            {
                string word = words[i];

                if (word.Length != 4) continue;

                byte[] bytes = new byte[2];
                bytes[1] = Convert.ToByte(word.Substring(0, 2), 16);
                bytes[0] = Convert.ToByte(word.Substring(2, 2), 16);
                string text = Encoding.Unicode.GetString(bytes);
                sb.Append(text);
            }
            return sb.ToString();
        }
    }
}
