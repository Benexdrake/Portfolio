namespace Notizen_Forms
{
    partial class ExportViewForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Note = new System.Windows.Forms.ColumnHeader();
            this.Text_View = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Day = new System.Windows.Forms.ColumnHeader();
            this.Course_Name = new System.Windows.Forms.ColumnHeader();
            this.Professor_Name = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Note,
            this.Text_View,
            this.Date,
            this.Day,
            this.Course_Name,
            this.Professor_Name});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1038, 624);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Note
            // 
            this.Note.Text = "Note";
            this.Note.Width = 120;
            // 
            // Text_View
            // 
            this.Text_View.Text = "Text";
            this.Text_View.Width = 300;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 120;
            // 
            // Day
            // 
            this.Day.Text = "Day";
            // 
            // Course_Name
            // 
            this.Course_Name.Text = "Course Name";
            this.Course_Name.Width = 120;
            // 
            // Professor_Name
            // 
            this.Professor_Name.Text = "Professor Name";
            this.Professor_Name.Width = 120;
            // 
            // ExportViewForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 624);
            this.Controls.Add(this.listView);
            this.Name = "ExportViewForms";
            this.Text = "ExportViewForms";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView;
        private ColumnHeader ID;
        private ColumnHeader Note;
        private ColumnHeader Text_View;
        private ColumnHeader Date;
        private ColumnHeader Day;
        private ColumnHeader Course_Name;
        private ColumnHeader Professor_Name;
    }
}