using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;

namespace NT219_Lab04
{
    public partial class HexPage : UserControl
    {
        private static string hexChars = "0123456789ABCDEF";
        public HexPage()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                var input = ConvertHex(txtInput.Text.Trim().ToUpper());
                txtMD5.Text = ComputeMd5Hash(input);
                txtSHA1.Text = ComputeSha1Hash(input);
                txtSHA256.Text = ComputeSha256Hash(input);
                txtSHA384.Text = ComputeSha384Hash(input);
                txtSHA512.Text = ComputeSha512Hash(input);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtInput, ex.ToString());
            }
        }

        private static int GetHex(char hex)
        {
            return hex <= '9' ? hex - '0' : hex - 'A' + 10;
        }

        private static byte[] ConvertHex(string hex)
        {
            if (hex.Any(c => !hexChars.Contains(c))) 
                throw new ArgumentException("Incorrect hex format");

            if (hex.Length % 2 is not 0)
                throw new ArgumentException("The hexadecimal data cannot have an odd number of digits!");

            var size = hex.Length / 2;
            var result = new byte[size];

            var input = 0;
            for (var i = 0; i < size; ++i)
                result[i] = (byte)((GetHex(hex[input++]) << 4) + GetHex(hex[input++]));

            return result;
        }

        private static string ComputeMd5Hash(byte[] data)
        {
            var md5 = MD5.Create();
            var bytes = md5.ComputeHash(data);
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private static string ComputeSha1Hash(byte[] data)
        {
            var sha1 = SHA1.Create();
            var bytes = sha1.ComputeHash(data);
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private static string ComputeSha256Hash(byte[] data)
        {
            var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(data);
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private static string ComputeSha384Hash(byte[] data)
        {
            var sha384 = SHA384.Create();
            var bytes = sha384.ComputeHash(data);
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private static string ComputeSha512Hash(byte[] data)
        {
            var sha512 = SHA512.Create();
            var bytes = sha512.ComputeHash(data);
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
