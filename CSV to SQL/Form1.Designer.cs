namespace CSV_to_SQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btn_LoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGridView
            // 
            this.dGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.dGridView.Location = new System.Drawing.Point(0, 0);
            this.dGridView.Name = "dGridView";
            this.dGridView.RowTemplate.Height = 25;
            this.dGridView.Size = new System.Drawing.Size(699, 657);
            this.dGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Upload);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn_Check);
            this.panel1.Controls.Add(this.lbl_FileName);
            this.panel1.Controls.Add(this.btn_OpenFile);
            this.panel1.Controls.Add(this.btn_LoadData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(705, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 657);
            this.panel1.TabIndex = 1;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Upload.Location = new System.Drawing.Point(0, 200);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(220, 59);
            this.btn_Upload.TabIndex = 4;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Close.Location = new System.Drawing.Point(0, 598);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(220, 59);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Check.Location = new System.Drawing.Point(0, 141);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(220, 59);
            this.btn_Check.TabIndex = 2;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_FileName.Location = new System.Drawing.Point(0, 118);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(220, 23);
            this.lbl_FileName.TabIndex = 1;
            this.lbl_FileName.Text = "File Name";
            this.lbl_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_OpenFile.Location = new System.Drawing.Point(0, 59);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(220, 59);
            this.btn_OpenFile.TabIndex = 0;
            this.btn_OpenFile.Text = "Open File...";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btn_LoadData
            // 
            this.btn_LoadData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LoadData.Location = new System.Drawing.Point(0, 0);
            this.btn_LoadData.Name = "btn_LoadData";
            this.btn_LoadData.Size = new System.Drawing.Size(220, 59);
            this.btn_LoadData.TabIndex = 5;
            this.btn_LoadData.Text = "Load Data from SQL";
            this.btn_LoadData.UseVisualStyleBackColor = true;
            this.btn_LoadData.Click += new System.EventHandler(this.btn_LoadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dGridView;
        private Panel panel1;
        private Button btn_Close;
        private Button btn_Check;
        private Label lbl_FileName;
        private Button btn_OpenFile;
        private Button btn_Upload;
        private Button btn_LoadData;
    }
}