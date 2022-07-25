namespace Notizen_Forms
{
    partial class MainForms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childPanel = new System.Windows.Forms.Panel();
            this.panelSearchBar = new System.Windows.Forms.Panel();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dTimeLast = new System.Windows.Forms.DateTimePicker();
            this.dTimeFirst = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxSort = new System.Windows.Forms.ComboBox();
            this.rButtonASC = new System.Windows.Forms.RadioButton();
            this.rButtonDESC = new System.Windows.Forms.RadioButton();
            this.cBoxSearch = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.cBoxSearchItems = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.childPanel.SuspendLayout();
            this.panelSearchBar.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteToolStripMenuItem,
            this.oldNotesToolStripMenuItem,
            this.exportNotesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 23);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.newNoteToolStripMenuItem.Text = "New Note";
            this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.newNoteToolStripMenuItem_Click);
            // 
            // oldNotesToolStripMenuItem
            // 
            this.oldNotesToolStripMenuItem.Name = "oldNotesToolStripMenuItem";
            this.oldNotesToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.oldNotesToolStripMenuItem.Text = "Old Notes";
            this.oldNotesToolStripMenuItem.Click += new System.EventHandler(this.oldNotesToolStripMenuItem_Click);
            // 
            // exportNotesToolStripMenuItem
            // 
            this.exportNotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsExcelToolStripMenuItem});
            this.exportNotesToolStripMenuItem.Name = "exportNotesToolStripMenuItem";
            this.exportNotesToolStripMenuItem.Size = new System.Drawing.Size(87, 19);
            this.exportNotesToolStripMenuItem.Text = "Export Notes";
            // 
            // saveAsExcelToolStripMenuItem
            // 
            this.saveAsExcelToolStripMenuItem.Name = "saveAsExcelToolStripMenuItem";
            this.saveAsExcelToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveAsExcelToolStripMenuItem.Text = "Save as Excel";
            this.saveAsExcelToolStripMenuItem.Click += new System.EventHandler(this.saveAsExcelToolStripMenuItem_Click);
            // 
            // childPanel
            // 
            this.childPanel.AutoScroll = true;
            this.childPanel.Controls.Add(this.button1);
            this.childPanel.Controls.Add(this.label6);
            this.childPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childPanel.Location = new System.Drawing.Point(0, 79);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(834, 502);
            this.childPanel.TabIndex = 1;
            // 
            // panelSearchBar
            // 
            this.panelSearchBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSearchBar.Controls.Add(this.panelDateTime);
            this.panelSearchBar.Controls.Add(this.label2);
            this.panelSearchBar.Controls.Add(this.label1);
            this.panelSearchBar.Controls.Add(this.cBoxSort);
            this.panelSearchBar.Controls.Add(this.rButtonASC);
            this.panelSearchBar.Controls.Add(this.rButtonDESC);
            this.panelSearchBar.Controls.Add(this.cBoxSearch);
            this.panelSearchBar.Controls.Add(this.btn_Clear);
            this.panelSearchBar.Controls.Add(this.tBoxSearch);
            this.panelSearchBar.Controls.Add(this.cBoxSearchItems);
            this.panelSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchBar.Location = new System.Drawing.Point(0, 23);
            this.panelSearchBar.Name = "panelSearchBar";
            this.panelSearchBar.Size = new System.Drawing.Size(834, 56);
            this.panelSearchBar.TabIndex = 0;
            // 
            // panelDateTime
            // 
            this.panelDateTime.Controls.Add(this.label5);
            this.panelDateTime.Controls.Add(this.label4);
            this.panelDateTime.Controls.Add(this.label3);
            this.panelDateTime.Controls.Add(this.dTimeLast);
            this.panelDateTime.Controls.Add(this.dTimeFirst);
            this.panelDateTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDateTime.Location = new System.Drawing.Point(0, 0);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(499, 56);
            this.panelDateTime.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(116, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            // 
            // dTimeLast
            // 
            this.dTimeLast.CustomFormat = "";
            this.dTimeLast.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTimeLast.Location = new System.Drawing.Point(150, 28);
            this.dTimeLast.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dTimeLast.Name = "dTimeLast";
            this.dTimeLast.Size = new System.Drawing.Size(95, 23);
            this.dTimeLast.TabIndex = 1;
            this.dTimeLast.Value = new System.DateTime(2022, 3, 1, 8, 9, 40, 0);
            this.dTimeLast.ValueChanged += new System.EventHandler(this.dTimeLast_ValueChanged);
            // 
            // dTimeFirst
            // 
            this.dTimeFirst.CustomFormat = "";
            this.dTimeFirst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTimeFirst.Location = new System.Drawing.Point(12, 27);
            this.dTimeFirst.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dTimeFirst.Name = "dTimeFirst";
            this.dTimeFirst.Size = new System.Drawing.Size(98, 23);
            this.dTimeFirst.TabIndex = 0;
            this.dTimeFirst.Value = new System.DateTime(2022, 3, 1, 0, 0, 0, 0);
            this.dTimeFirst.ValueChanged += new System.EventHandler(this.dTimeFirst_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sort By:";
            // 
            // cBoxSort
            // 
            this.cBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSort.FormattingEnabled = true;
            this.cBoxSort.Items.AddRange(new object[] {
            "ID",
            "Note",
            "Text",
            "Course_Name",
            "Professor_Name",
            "Date"});
            this.cBoxSort.Location = new System.Drawing.Point(646, 30);
            this.cBoxSort.Name = "cBoxSort";
            this.cBoxSort.Size = new System.Drawing.Size(137, 23);
            this.cBoxSort.TabIndex = 10;
            this.cBoxSort.SelectionChangeCommitted += new System.EventHandler(this.cBoxSort_SelectionChangeCommitted);
            // 
            // rButtonASC
            // 
            this.rButtonASC.AutoSize = true;
            this.rButtonASC.Checked = true;
            this.rButtonASC.Location = new System.Drawing.Point(505, 8);
            this.rButtonASC.Name = "rButtonASC";
            this.rButtonASC.Size = new System.Drawing.Size(47, 19);
            this.rButtonASC.TabIndex = 7;
            this.rButtonASC.TabStop = true;
            this.rButtonASC.Text = "ASC";
            this.rButtonASC.UseVisualStyleBackColor = true;
            this.rButtonASC.Click += new System.EventHandler(this.rButtonASC_Click);
            // 
            // rButtonDESC
            // 
            this.rButtonDESC.AutoSize = true;
            this.rButtonDESC.Location = new System.Drawing.Point(505, 32);
            this.rButtonDESC.Name = "rButtonDESC";
            this.rButtonDESC.Size = new System.Drawing.Size(53, 19);
            this.rButtonDESC.TabIndex = 6;
            this.rButtonDESC.Text = "DESC";
            this.rButtonDESC.UseVisualStyleBackColor = true;
            this.rButtonDESC.Click += new System.EventHandler(this.rButtonDESC_Click);
            // 
            // cBoxSearch
            // 
            this.cBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSearch.FormattingEnabled = true;
            this.cBoxSearch.Items.AddRange(new object[] {
            "Note",
            "Text",
            "Course",
            "Professor",
            "Date"});
            this.cBoxSearch.Location = new System.Drawing.Point(646, 4);
            this.cBoxSearch.Name = "cBoxSearch";
            this.cBoxSearch.Size = new System.Drawing.Size(137, 23);
            this.cBoxSearch.TabIndex = 5;
            this.cBoxSearch.SelectionChangeCommitted += new System.EventHandler(this.cBoxSearch_SelectionChangeCommitted);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Clear.Location = new System.Drawing.Point(789, 0);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(45, 56);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.Location = new System.Drawing.Point(12, 27);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.PlaceholderText = "Search Here...";
            this.tBoxSearch.Size = new System.Drawing.Size(487, 23);
            this.tBoxSearch.TabIndex = 8;
            this.tBoxSearch.TextChanged += new System.EventHandler(this.tBoxSearch_TextChanged);
            // 
            // cBoxSearchItems
            // 
            this.cBoxSearchItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSearchItems.FormattingEnabled = true;
            this.cBoxSearchItems.Location = new System.Drawing.Point(12, 4);
            this.cBoxSearchItems.Name = "cBoxSearchItems";
            this.cBoxSearchItems.Size = new System.Drawing.Size(487, 23);
            this.cBoxSearchItems.TabIndex = 9;
            this.cBoxSearchItems.SelectionChangeCommitted += new System.EventHandler(this.cBoxSearchItems_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 197);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 581);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.panelSearchBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(850, 1620);
            this.MinimumSize = new System.Drawing.Size(850, 620);
            this.Name = "MainForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForms_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.childPanel.ResumeLayout(false);
            this.childPanel.PerformLayout();
            this.panelSearchBar.ResumeLayout(false);
            this.panelSearchBar.PerformLayout();
            this.panelDateTime.ResumeLayout(false);
            this.panelDateTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newNoteToolStripMenuItem;
        private ToolStripMenuItem oldNotesToolStripMenuItem;
        private ToolStripMenuItem exportNotesToolStripMenuItem;
        private ToolStripMenuItem saveAsExcelToolStripMenuItem;
        private Panel childPanel;
        private Panel panelSearchBar;
        private Button btn_Clear;
        private TextBox tBoxSearch;
        private RadioButton rButtonASC;
        private RadioButton rButtonDESC;
        private ComboBox cBoxSearch;
        private ComboBox cBoxSearchItems;
        private Label label2;
        private Label label1;
        private ComboBox cBoxSort;
        private Panel panelDateTime;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dTimeLast;
        private DateTimePicker dTimeFirst;
        private Button button1;
        private Label label6;
    }
}