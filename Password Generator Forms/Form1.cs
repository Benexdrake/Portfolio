using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBoxLength();
            cBoxLength.SelectedIndex = 0;
            lbl_Error.Text = "";
        }

        private void ComboBoxLength()
        {
            for (int i = 6; i <= 30; i++)
            {
                cBoxLength.Items.Add(i);
            }
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if(cBox_Low.Checked == false && cBox_Upper.Checked == false && cBox_Numbers.Checked == false && cBox_Special.Checked == false)
            {
                lbl_Error.Text = "You have to Check minumum one Option !!!";
            }
            else
            {
                lbl_Error.Text = "";
                int length = int.Parse(cBoxLength.Text);
                PasswordGenerator.combineChar(cBox_Low.Checked,cBox_Upper.Checked,cBox_Numbers.Checked,cBox_Special.Checked);
                String p = PasswordGenerator.Generator(length);
                tBox_Password.Text = p;
                tBox_SHA.Text = SHA256Generator.Compute256(p);
            }
        }

        private void btn_Copy_Password_Click(object sender, EventArgs e)
        {
            if(tBox_Password.Text != String.Empty)
            {
                Clipboard.Clear();
                Clipboard.SetText(tBox_Password.Text);
            }
            else
            {
                lbl_Error.Text = "First Generate to Copy the Password...";
            }
        }

        private async void btn_Copy_SHA_Click(object sender, EventArgs e)
        {
            if(tBox_SHA.Text != String.Empty)
            {
                Clipboard.Clear();
                Clipboard.SetText(tBox_SHA.Text);
            }
            else
            {
                lbl_Error.Text = "First Generate to Copy the SHA Password...";
            }
        }

       
    }
}
