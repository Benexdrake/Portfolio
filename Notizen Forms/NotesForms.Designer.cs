namespace Notizen_Forms
{
    partial class NotesForms
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tBox_Notes = new System.Windows.Forms.TextBox();
            this.tBox_Text = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Professor = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.btnSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 5);
            this.panel1.TabIndex = 1;
            // 
            // tBox_Notes
            // 
            this.tBox_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_Notes.Location = new System.Drawing.Point(240, 8);
            this.tBox_Notes.Name = "tBox_Notes";
            this.tBox_Notes.ReadOnly = true;
            this.tBox_Notes.Size = new System.Drawing.Size(556, 23);
            this.tBox_Notes.TabIndex = 1;
            // 
            // tBox_Text
            // 
            this.tBox_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_Text.Location = new System.Drawing.Point(240, 37);
            this.tBox_Text.Multiline = true;
            this.tBox_Text.Name = "tBox_Text";
            this.tBox_Text.ReadOnly = true;
            this.tBox_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBox_Text.Size = new System.Drawing.Size(556, 52);
            this.tBox_Text.TabIndex = 2;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(3, 8);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(79, 15);
            this.lbl_Date.TabIndex = 5;
            this.lbl_Date.Text = "26.02.2022      ";
            // 
            // lbl_Professor
            // 
            this.lbl_Professor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Professor.AutoSize = true;
            this.lbl_Professor.Location = new System.Drawing.Point(3, 26);
            this.lbl_Professor.Name = "lbl_Professor";
            this.lbl_Professor.Size = new System.Drawing.Size(56, 15);
            this.lbl_Professor.TabIndex = 6;
            this.lbl_Professor.Text = "Professor";
            this.lbl_Professor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Location = new System.Drawing.Point(3, 44);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(44, 15);
            this.lbl_Course.TabIndex = 7;
            this.lbl_Course.Text = "Course";
            this.lbl_Course.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSize
            // 
            this.btnSize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSize.Location = new System.Drawing.Point(0, 72);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(75, 23);
            this.btnSize.TabIndex = 8;
            this.btnSize.Text = "expand";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // NotesForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Professor);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.tBox_Text);
            this.Controls.Add(this.tBox_Notes);
            this.Controls.Add(this.panel1);
            this.Name = "NotesForms";
            this.Size = new System.Drawing.Size(800, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox tBox_Notes;
        private TextBox tBox_Text;
        private Label lbl_Date;
        private Label lbl_Professor;
        private Label lbl_Course;
        private Button btnSize;
    }
}
