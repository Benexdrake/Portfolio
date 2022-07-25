using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notizen_Forms
{
    public partial class ExportViewForms : Form
    {
        List<Protocol> protocols;
        Hashtable myHashtable;

        public ExportViewForms(List<Protocol> p)
        {
            InitializeComponent();
            protocols = p;
            LoadView();
        }


        private void LoadView()
        {
            for (int i = protocols.Count-1; i >= 0; i--)
            {
                ListViewItem lv = new ListViewItem(protocols[i].id.ToString());
                lv.SubItems.Add(protocols[i].note);
                lv.SubItems.Add(protocols[i].text);
                lv.SubItems.Add(protocols[i].dateTime.ToString());
                lv.SubItems.Add(protocols[i].day);
                lv.SubItems.Add(protocols[i].courseName);
                lv.SubItems.Add(protocols[i].professorName);
                listView.Items.Add(lv);
            }
        }

        public void SaveAsExcel()
        {
            try
            {
                CheckExcellProcesses();

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel File|*.xlsx", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/Protocol-List.xlsx";

                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)app.ActiveSheet;
                        app.Visible = false;

                        ws.Columns["A"].ColumnWidth = 2;
                        ws.Columns["B"].ColumnWidth = 50;
                        ws.Columns["C"].ColumnWidth = 100;
                        ws.Columns["D"].ColumnWidth = 20;
                        ws.Columns["E"].ColumnWidth = 10;
                        ws.Columns["F"].ColumnWidth = 50;
                        ws.Columns["G"].ColumnWidth = 30;

                        ws.Cells[1, 1] = "ID";
                        ws.Cells[1, 2] = "Note";
                        ws.Cells[1, 3] = "Text";
                        ws.Cells[1, 4] = "Date";
                        ws.Cells[1, 5] = "Day";
                        ws.Cells[1, 6] = "Course";
                        ws.Cells[1, 7] = "Professor";
                        int i = 2;
                        foreach (ListViewItem item in listView.Items)
                        {
                            ws.Cells[i, 1] = item.SubItems[0].Text;
                            ws.Cells[i, 2] = item.SubItems[1].Text;
                            ws.Cells[i, 3] = item.SubItems[2].Text;
                            ws.Cells[i, 4] = item.SubItems[3].Text;
                            ws.Cells[i, 5] = item.SubItems[4].Text;
                            ws.Cells[i, 6] = item.SubItems[5].Text;
                            ws.Cells[i, 7] = item.SubItems[6].Text;
                            i++;
                        }
                        app.DisplayAlerts = false;
                        wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        wb.Close();
                        app.Quit();
                        KillExcel();
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        private void CheckExcellProcesses()
        {
            Process[] AllProcesses = Process.GetProcessesByName("excel");
            myHashtable = new Hashtable();
            int iCount = 0;

            foreach (Process ExcelProcess in AllProcesses)
            {
                myHashtable.Add(ExcelProcess.Id, iCount);
                iCount = iCount + 1;
            }
        }
        private void KillExcel()
        {
            Process[] AllProcesses = Process.GetProcessesByName("excel");

            // check to kill the right process
            foreach (Process ExcelProcess in AllProcesses)
            {
                if (myHashtable.ContainsKey(ExcelProcess.Id) == false)
                    ExcelProcess.Kill();
            }

            AllProcesses = null;
        }
    }
}
