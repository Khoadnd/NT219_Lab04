using System.Security.Cryptography;
using System.Text;

namespace NT219_Lab04
{
    public partial class FilePage : UserControl
    {
        public FilePage()
        {
            InitializeComponent();
        }

        private void btnOFD_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = @"Select file";
            ofd.ShowDialog();
            txtFilePath.Text = ofd.FileName;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                var path = CheckPath(txtFilePath.Text.Trim());
                txtMD5.Text = ComputeMd5Hash(path);
                txtSHA1.Text = ComputeSha1Hash(path);
                txtSHA256.Text = ComputeSha256Hash(path);
                txtSHA384.Text = ComputeSha384Hash(path);
                txtSHA512.Text = ComputeSha512Hash(path);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFilePath, ex.ToString());
            }
        }

        private void txtFilePath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Enter)
                btnCalculate.PerformClick();
        }

        private static string CheckPath(string path)
        {
            if (path.IndexOfAny(Path.GetInvalidPathChars()) > -1)
                throw new ArgumentException("Invalid path");

            if (!File.Exists(path))
                throw new ArgumentException("File not exists");

            return path;
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            if (!chbLive.Checked)
                return;

            btnCalculate.PerformClick();
        }

        private static string ComputeMd5Hash(string dataPath)
        {
            var md5 = MD5.Create();
            var dataStream = File.OpenRead(dataPath);
            var bytes = md5.ComputeHash(dataStream);
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private static string ComputeSha1Hash(string dataPath)
        {
            var sha1 = SHA1.Create();
            var dataStream = File.OpenRead(dataPath);
            var bytes = sha1.ComputeHash(dataStream);
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private static string ComputeSha256Hash(string dataPath)
        {
            var sha256 = SHA256.Create();
            var dataStream = File.OpenRead(dataPath);
            var bytes = sha256.ComputeHash(dataStream);
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private static string ComputeSha384Hash(string dataPath)
        {
            var sha384 = SHA384.Create();
            var dataStream = File.OpenRead(dataPath);
            var bytes = sha384.ComputeHash(dataStream);
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }

        private static string ComputeSha512Hash(string dataPath)
        {
            var sha512 = SHA512.Create();
            var dataStream = File.OpenRead(dataPath);
            var bytes = sha512.ComputeHash(dataStream);
            var builder = new StringBuilder();
            foreach (var b in bytes)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }
    }
}
