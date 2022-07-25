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
    public partial class MainForms : Form
    {
        SqlDB sqlDB;
        List<Protocol> protocols;
        public MainForms()
        {
            InitializeComponent();
            sqlDB = new SqlDB();
            this.MaximumSize = new Size(MaximumSize.Width, Screen.PrimaryScreen.WorkingArea.Height);
            panelSearchBar.Visible = false;
            cBoxSort.SelectedIndex = 0;
            cBoxSearch.SelectedIndex = 0;
            panelDateTime.Visible = false;
            dTimeFirst.MaxDate = DateTime.Today;
            dTimeLast.MaxDate = DateTime.Today;
            newNoteToolStripMenuItem_Click(null, null);
        }

        private void ClearChildPanel()
        {
            childPanel.Controls.Clear();
        }

        private void MainForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Clear_Click(sender,e);
            panelSearchBar.Visible=false;
            exportNotesToolStripMenuItem.Enabled = false;
            ClearChildPanel();
            NewProtocolForms newProtocolForms = new NewProtocolForms();
            newProtocolForms.TopLevel = false;
            childPanel.Controls.Clear();
            childPanel.Controls.Add(newProtocolForms);
            newProtocolForms.Dock = DockStyle.Fill;
            newProtocolForms.Show();
        }

        private void oldNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HasChanges();
            SendQuere(cBoxSearch.SelectedIndex);
            exportNotesToolStripMenuItem.Enabled = true;
        }

        private void OpenNotes(string sql)
        {
            panelSearchBar.Visible = true;
            sqlDB.ReadSql(sql, 2);

            childPanel.Controls.Clear();
            NotesForms note;
            protocols = sqlDB.protocols;
            foreach (var item in protocols)
            {
                note = new NotesForms();
                childPanel.Controls.Add(note);
                note.protocol = item;
                note.FillNotes();
                note.Dock = DockStyle.Top;
                note.Show();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tBoxSearch.Clear();
            rButtonASC.Checked = true;
            rButtonDESC.Checked = false;
            cBoxSort.SelectedIndex = 0;
            cBoxSearch.SelectedIndex = 0;
            tBoxSearch.Visible = true;
            cBoxSearchItems.Visible = false;
            panelDateTime.Visible = false;
            HasChanges();
            SendQuere(cBoxSearch.SelectedIndex);
        }


        private void HasChanges()
        {
            switch (cBoxSearch.SelectedIndex)
            {
                case 0: case 1:
                    tBoxSearch.Visible = true;
                    cBoxSearchItems.Visible = false;
                    panelDateTime.Visible = false;
                    
                    break;
                case 2:
                    // Muss eine änderung her, da dies jedesmal ausgeführt wird, wenn SearchItem Index geändert wird.
                    cBoxSearchItems.Items.Clear();
                    tBoxSearch.Visible = false;
                    cBoxSearchItems.Visible = true;
                    panelDateTime.Visible = false;
                    sqlDB.ReadSql("Select * from Course", 1);
                    
                    foreach (var item in sqlDB.protocols)
                    {
                        cBoxSearchItems.Items.Add(item.courseName);
                    }
                    cBoxSearchItems.SelectedIndex = 0;
                    break;
                case 3:
                    cBoxSearchItems.Items.Clear();
                    tBoxSearch.Visible = false;
                    cBoxSearchItems.Visible = true;
                    panelDateTime.Visible = false;
                    sqlDB.ReadSql("Select * from Professor", 0);
                    foreach (var item in sqlDB.protocols)
                    {
                        cBoxSearchItems.Items.Add(item.professorName);
                    }
                    cBoxSearchItems.SelectedIndex = 0;
                    break;
                case 4:
                    cBoxSearchItems.Visible=false;
                    tBoxSearch.Visible = false;
                    panelDateTime.Visible = true;
                    exportNotesToolStripMenuItem.Visible = true;
                    break;
            }
        }

        private void SendQuere(int variant)
        {
            switch(variant)
            {
                case 0:
                    if (rButtonASC.Checked)
                    {
                        OpenNotes($"Select * from SeeNotes where Note like '%{tBoxSearch.Text}%' order by {cBoxSort.Text} desc;");
                    }
                    else
                    {
                        OpenNotes($"Select * from SeeNotes where Note like '%{tBoxSearch.Text}%' order by {cBoxSort.Text} asc;");
                    }
                    break;
                case 1:
                    if (rButtonASC.Checked)
                    {
                        OpenNotes($"Select * from SeeNotes where Text like '%{tBoxSearch.Text}%' order by {cBoxSort.Text} desc;");
                    }
                    else
                    {
                        OpenNotes($"Select * from SeeNotes where Text like '%{tBoxSearch.Text}%' order by {cBoxSort.Text} asc;");
                    }
                    break;
                case 2:
                    if (rButtonASC.Checked)
                    {
                        OpenNotes($"Select * from SeeNotes where Course_Name = '{cBoxSearchItems.Text}' order by {cBoxSort.Text} desc;");
                    }
                    else
                    {
                        OpenNotes($"Select * from SeeNotes where Course_Name = '{cBoxSearchItems.Text}' order by {cBoxSort.Text} asc;");
                    }
                    break;
                case 3:
                    if (rButtonASC.Checked)
                    {
                        OpenNotes($"Select * from SeeNotes where Professor_Name = '{cBoxSearchItems.Text}' order by {cBoxSort.Text} desc;");
                    }
                    else
                    {
                        OpenNotes($"Select * from SeeNotes where Professor_Name = '{cBoxSearchItems.Text}' order by {cBoxSort.Text} asc;");
                    }
                    break;
                case 4:
                    if (rButtonASC.Checked)
                    {
                        OpenNotes($"Select * from SeeNotes where Date between '{dTimeLast.Value.ToString("yyyy-MM-dd")}' AND '{dTimeFirst.Value.ToString("yyyy-MM-dd")}' order by {cBoxSort.Text} desc;");
                    }
                    else
                    {
                        OpenNotes($"Select * from SeeNotes where Date between '{dTimeLast.Value.ToString("yyyy-MM-dd")}' AND '{dTimeFirst.Value.ToString("yyyy-MM-dd")}' order by {cBoxSort.Text} asc;");
                    }
                    break;
            }
        }

        private void saveAsExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCloseRequest = Application.OpenForms.OfType<ExportViewForms>().FirstOrDefault();

            if (formCloseRequest != null)
            {
                formCloseRequest.Close();
            }
            formCloseRequest = Application.OpenForms.OfType<ExportViewForms>().FirstOrDefault();

            ExportViewForms exportViewForms = new ExportViewForms(protocols);

            exportViewForms.Show();

            exportViewForms.SaveAsExcel();
        }

        private void cBoxSort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HasChanges();
            SendQuere(cBoxSearch.SelectedIndex);
        }

        private void cBoxSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HasChanges();
            SendQuere(cBoxSearch.SelectedIndex);
            tBoxSearch.Text = String.Empty;
        }

        private void rButtonASC_Click(object sender, EventArgs e)
        {
            SendQuere(cBoxSearch.SelectedIndex);
        }

        private void rButtonDESC_Click(object sender, EventArgs e)
        {
            SendQuere(cBoxSearch.SelectedIndex);
        }

        private void tBoxSearch_TextChanged(object sender, EventArgs e)
        {
            HasChanges();
            SendQuere(cBoxSearch.SelectedIndex);
        }

        private void dTimeLast_ValueChanged(object sender, EventArgs e)
        {
            SendQuere(cBoxSearch.SelectedIndex);
        }

        private void dTimeFirst_ValueChanged(object sender, EventArgs e)
        {
            SendQuere(cBoxSearch.SelectedIndex);
        }

        private void cBoxSearchItems_SelectionChangeCommitted(object sender, EventArgs e)
        { 
            SendQuere(cBoxSearch.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
