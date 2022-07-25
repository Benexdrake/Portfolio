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
    public partial class NotesForms : UserControl
    {
        bool isGreater = false;
        public Protocol protocol;
        public NotesForms()
        {
            InitializeComponent();
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            if(isGreater == false)
            {
                this.Size = new Size(800, 200);
                isGreater = true;
            }
            else
            {
                this.Size = new Size(800, 100);
                isGreater = false;
            }
        }

        public void FillNotes()
        {
            tBox_Notes.Text = protocol.note;
            tBox_Text.Text = protocol.text;

            lbl_Date.Text = protocol.dateTime.ToString("dd.MM.yyyy");
            lbl_Professor.Text = protocol.professorName;
            lbl_Course.Text = protocol.courseName;

        }
    }
}
