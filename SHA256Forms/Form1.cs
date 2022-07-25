using System.Security.Cryptography;
using System.Text;

namespace SHA256Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            tBox_SHA.Text = Compute256(tBox_Password.Text);
        }


        public static string Compute256(string rawdata)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(rawdata));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tBox_SHA.Text);
        }
    }
}