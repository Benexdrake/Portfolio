namespace Notizen_Forms
{
    public partial class LoginForm : Form
    {
        SqlDB sqlDB;
        bool isLoginOk;
        bool seePassword = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            sqlDB = new SqlDB();
            Save.username = tBox_Username.Text;
            Save.password = tBox_Password.Text;
            if(Save.username == "Test")
            {
                Save.mode = "Test_Protocol";
            }
            else
            {
                Save.mode = "Protocol";
            }
            isLoginOk = sqlDB.SqlConnection("Select * From Course");
            if(tBox_Username.Text != String.Empty && isLoginOk )
            {
            MainForms main = new MainForms();
            main.Show();
            this.Enabled = false;
            this.Visible = false;
            }
        }

        private void tBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, null);
            }
        }

        private void pBox_Password_Click(object sender, EventArgs e)
        {
            if(seePassword == false)
            {
                pBox_Password.Image = Properties.Resources.nothidden;
                pBox_Password.Refresh();
                tBox_Password.PasswordChar = '\0';
                seePassword = true;
            }
            else
            {
                pBox_Password.Image = Properties.Resources.hidden;
                pBox_Password.Refresh();
                tBox_Password.PasswordChar = '*';
                seePassword = false;
            }
        }
    }
}