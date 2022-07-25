namespace LoginMySqlForm
{
    public partial class Form1 : Form
    {
        MySql sql;

        public Form1()
        {
            InitializeComponent();
            label1.Text = String.Empty;
        }


        private void tBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(tBox_Username.Text != "" && tBox_Password.Text != "")
            {
                string p = SHA256Generator.Compute256(tBox_Password.Text);
                sql = new MySql(tBox_Username.Text, p, "localhost", "3306", "Datenbank die nicht mehr existiert");
                if(sql.IsLoginOk)
                {
                    sql.sqlRead($"select * from Personal where username = '{tBox_Username.Text}' and password = '{p}';");
                    //sql.sqlRead($"select * from Personal where username = 'Java' and password = 'bcb15f821479b4d5772bd0ca866c00ad5f926e3580720659cc80d39c9d09802a';");
                    if(sql.FoundUsers)
                    {
                        MessageBox.Show($"Welcome {sql.Person.Firstname} {sql.Person.Lastname}");
                    }
                    else
                    {
                        label1.Text = "Username or Password false";
                    }
                }
            }
            else
            {
                label1.Text = "Please Enter Username and Password";
            }
        }

        private void cBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxPassword.Checked)
            {
                tBox_Password.PasswordChar = '\0';
            }
            else
            {
                tBox_Password.PasswordChar = '*';
            }
        }
    }
}