using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notizen_Forms
{
    public partial class NewProtocolForms : Form
    {
        List<Protocol> protocols;
        Protocol pro;
        SqlDB sqlDB;
        public NewProtocolForms()
        {
            InitializeComponent();
            FillBox();
            cBox_Course.SelectedIndex = 0;
            cBox_Professor.SelectedIndex = 0;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if(tBox_Note.Text != String.Empty && tBox_Text.Text != String.Empty)
            {
                sqlDB = new SqlDB();
                pro = new Protocol();

                pro.note = tBox_Note.Text.Replace("'", "''");
                pro.text = tBox_Text.Text.Replace("'", "''");
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                DateTime time;
                DateTime.TryParse(date, out time);

                pro.course = cBox_Course.SelectedIndex + 1 ;
                pro.professor = cBox_Professor.SelectedIndex + 1;
                pro.day = DateTime.Now.ToString("dddd");
                string sql = $"call Insert_Notes('{pro.note}','{pro.text}',now(),'{pro.day}',{pro.course},{pro.professor});";

                sqlDB.SqlConnection(sql);
                tBox_Note.Text = String.Empty;
                tBox_Text.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Note und Text nicht ausgefüllt.");
            }
        }

        private void FillBox()
        {
            // Befüllt die Dropbox für Professors, indem die SQL abgefragt wird und jeder Professor add
            sqlDB = new SqlDB();
            sqlDB.ReadSql("Select * from Professor", 0);
            protocols = sqlDB.protocols;
            cBox_Professor.Items.Clear();
            foreach (var item in this.protocols)
            {
                cBox_Professor.Items.Add(item.professorName);
            }
            cBox_Course.Items.Clear();
            sqlDB.ReadSql("Select * From Course", 1);
            protocols = sqlDB.protocols;
            foreach (var item in this.protocols)
            {
                cBox_Course.Items.Add(item.courseName);
            }
        }
    }
}
