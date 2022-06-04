using System.Security.Cryptography;
using System.Text;

namespace NT219_Lab04
{
    public partial class TextPage : UserControl
    {
        public TextPage()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var input = txtInput.Text;
            txtMD5.Text = ComputeMd5Hash(input);
            txtSHA1.Text = ComputeSha1Hash(input);
            txtSHA256.Text = ComputeSha256Hash(input);
            txtSHA384.Text = ComputeSha384Hash(input);
            txtSHA512.Text = ComputeSha512Hash(input);
        }

        private static string ComputeMd5Hash(string data)
        {
            var md5 = MD5.Create();
            var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(data));
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private static string ComputeSha1Hash(string data)
        {
            var sha1 = SHA1.Create();
            var bytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(data));
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private static string ComputeSha256Hash(string data)
        {
            var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(data));
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private static string ComputeSha384Hash(string data)
        {
            var sha384 = SHA384.Create();
            var bytes = sha384.ComputeHash(Encoding.UTF8.GetBytes(data));
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private static string ComputeSha512Hash(string data)
        {
            var sha512 = SHA512.Create();
            var bytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(data));
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCalculate.PerformClick();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (chbLive.Checked)
                btnCalculate.PerformClick();
        }
    }
}
