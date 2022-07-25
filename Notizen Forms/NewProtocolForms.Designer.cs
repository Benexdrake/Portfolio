namespace Notizen_Forms
{
    partial class NewProtocolForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tBox_Note = new System.Windows.Forms.TextBox();
            this.cBox_Course = new System.Windows.Forms.ComboBox();
            this.cBox_Professor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Note:";
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.Location = new System.Drawing.Point(703, 522);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tBox_Note
            // 
            this.tBox_Note.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_Note.Location = new System.Drawing.Point(30, 67);
            this.tBox_Note.Name = "tBox_Note";
            this.tBox_Note.Size = new System.Drawing.Size(748, 23);
            this.tBox_Note.TabIndex = 1;
            // 
            // cBox_Course
            // 
            this.cBox_Course.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBox_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Course.FormattingEnabled = true;
            this.cBox_Course.Items.AddRange(new object[] {
            "-"});
            this.cBox_Course.Location = new System.Drawing.Point(540, 38);
            this.cBox_Course.Name = "cBox_Course";
            this.cBox_Course.Size = new System.Drawing.Size(238, 23);
            this.cBox_Course.TabIndex = 3;
            this.cBox_Course.TabStop = false;
            // 
            // cBox_Professor
            // 
            this.cBox_Professor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Professor.FormattingEnabled = true;
            this.cBox_Professor.Items.AddRange(new object[] {
            "-"});
            this.cBox_Professor.Location = new System.Drawing.Point(286, 38);
            this.cBox_Professor.Name = "cBox_Professor";
            this.cBox_Professor.Size = new System.Drawing.Size(238, 23);
            this.cBox_Professor.TabIndex = 4;
            this.cBox_Professor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Professor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course:";
            // 
            // tBox_Text
            // 
            this.tBox_Text.AcceptsTab = true;
            this.tBox_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_Text.Location = new System.Drawing.Point(30, 113);
            this.tBox_Text.Multiline = true;
            this.tBox_Text.Name = "tBox_Text";
            this.tBox_Text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBox_Text.Size = new System.Drawing.Size(748, 403);
            this.tBox_Text.TabIndex = 2;
            // 
            // NewProtocolForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.tBox_Text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBox_Professor);
            this.Controls.Add(this.cBox_Course);
            this.Controls.Add(this.tBox_Note);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewProtocolForms";
            this.Text = "NewProtocolForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_Send;
        private TextBox tBox_Note;
        private ComboBox cBox_Course;
        private ComboBox cBox_Professor;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tBox_Text;
    }
}