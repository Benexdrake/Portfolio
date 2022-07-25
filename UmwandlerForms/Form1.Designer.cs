namespace UmwandlerForms
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
            this.btn_Change = new System.Windows.Forms.Button();
            this.cBoxMenu = new System.Windows.Forms.ComboBox();
            this.cBox2 = new System.Windows.Forms.ComboBox();
            this.cBox1 = new System.Windows.Forms.ComboBox();
            this.tBox_Output = new System.Windows.Forms.TextBox();
            this.tBox_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(308, 120);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(121, 40);
            this.btn_Change.TabIndex = 0;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // cBoxMenu
            // 
            this.cBoxMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMenu.FormattingEnabled = true;
            this.cBoxMenu.Location = new System.Drawing.Point(12, 12);
            this.cBoxMenu.Name = "cBoxMenu";
            this.cBoxMenu.Size = new System.Drawing.Size(237, 23);
            this.cBoxMenu.TabIndex = 1;
            this.cBoxMenu.SelectedIndexChanged += new System.EventHandler(this.cBoxMenu_SelectedIndexChanged);
            // 
            // cBox2
            // 
            this.cBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox2.FormattingEnabled = true;
            this.cBox2.Location = new System.Drawing.Point(255, 91);
            this.cBox2.Name = "cBox2";
            this.cBox2.Size = new System.Drawing.Size(174, 23);
            this.cBox2.TabIndex = 2;
            this.cBox2.SelectedIndexChanged += new System.EventHandler(this.cBox2_SelectedIndexChanged);
            // 
            // cBox1
            // 
            this.cBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox1.FormattingEnabled = true;
            this.cBox1.Location = new System.Drawing.Point(18, 91);
            this.cBox1.Name = "cBox1";
            this.cBox1.Size = new System.Drawing.Size(174, 23);
            this.cBox1.TabIndex = 3;
            this.cBox1.SelectedIndexChanged += new System.EventHandler(this.cBox1_SelectedIndexChanged);
            // 
            // tBox_Output
            // 
            this.tBox_Output.Location = new System.Drawing.Point(255, 62);
            this.tBox_Output.Name = "tBox_Output";
            this.tBox_Output.ReadOnly = true;
            this.tBox_Output.Size = new System.Drawing.Size(174, 23);
            this.tBox_Output.TabIndex = 4;
            // 
            // tBox_Input
            // 
            this.tBox_Input.Location = new System.Drawing.Point(18, 62);
            this.tBox_Input.Name = "tBox_Input";
            this.tBox_Input.Size = new System.Drawing.Size(174, 23);
            this.tBox_Input.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = ">>>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_Input);
            this.Controls.Add(this.tBox_Output);
            this.Controls.Add(this.cBox1);
            this.Controls.Add(this.cBox2);
            this.Controls.Add(this.cBoxMenu);
            this.Controls.Add(this.btn_Change);
            this.MaximumSize = new System.Drawing.Size(471, 211);
            this.MinimumSize = new System.Drawing.Size(471, 211);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Change;
        private ComboBox cBoxMenu;
        private ComboBox cBox2;
        private ComboBox cBox1;
        private TextBox tBox_Output;
        private TextBox tBox_Input;
        private Label label1;
    }
}