namespace Password_Generator_Forms
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Copy_SHA = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_Password = new System.Windows.Forms.TextBox();
            this.tBox_SHA = new System.Windows.Forms.TextBox();
            this.btn_Copy_Password = new System.Windows.Forms.Button();
            this.cBox_Low = new System.Windows.Forms.CheckBox();
            this.cBoxLength = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBox_Upper = new System.Windows.Forms.CheckBox();
            this.cBox_Numbers = new System.Windows.Forms.CheckBox();
            this.cBox_Special = new System.Windows.Forms.CheckBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Copy_SHA
            // 
            this.btn_Copy_SHA.Location = new System.Drawing.Point(593, 159);
            this.btn_Copy_SHA.Name = "btn_Copy_SHA";
            this.btn_Copy_SHA.Size = new System.Drawing.Size(55, 23);
            this.btn_Copy_SHA.TabIndex = 0;
            this.btn_Copy_SHA.Text = "Copy";
            this.btn_Copy_SHA.UseVisualStyleBackColor = true;
            this.btn_Copy_SHA.Click += new System.EventHandler(this.btn_Copy_SHA_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(573, 184);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(75, 23);
            this.btn_Generate.TabIndex = 1;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SHA256:";
            // 
            // tBox_Password
            // 
            this.tBox_Password.Location = new System.Drawing.Point(66, 132);
            this.tBox_Password.Name = "tBox_Password";
            this.tBox_Password.ReadOnly = true;
            this.tBox_Password.Size = new System.Drawing.Size(521, 20);
            this.tBox_Password.TabIndex = 4;
            // 
            // tBox_SHA
            // 
            this.tBox_SHA.Location = new System.Drawing.Point(66, 158);
            this.tBox_SHA.Name = "tBox_SHA";
            this.tBox_SHA.ReadOnly = true;
            this.tBox_SHA.Size = new System.Drawing.Size(521, 20);
            this.tBox_SHA.TabIndex = 5;
            // 
            // btn_Copy_Password
            // 
            this.btn_Copy_Password.Location = new System.Drawing.Point(593, 130);
            this.btn_Copy_Password.Name = "btn_Copy_Password";
            this.btn_Copy_Password.Size = new System.Drawing.Size(55, 23);
            this.btn_Copy_Password.TabIndex = 6;
            this.btn_Copy_Password.Text = "Copy";
            this.btn_Copy_Password.UseVisualStyleBackColor = true;
            this.btn_Copy_Password.Click += new System.EventHandler(this.btn_Copy_Password_Click);
            // 
            // cBox_Low
            // 
            this.cBox_Low.AutoSize = true;
            this.cBox_Low.Location = new System.Drawing.Point(15, 12);
            this.cBox_Low.Name = "cBox_Low";
            this.cBox_Low.Size = new System.Drawing.Size(163, 17);
            this.cBox_Low.TabIndex = 7;
            this.cBox_Low.Text = "Includes Lowcase (a,b,c,d,e)";
            this.cBox_Low.UseVisualStyleBackColor = true;
            // 
            // cBoxLength
            // 
            this.cBoxLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLength.FormattingEnabled = true;
            this.cBoxLength.Location = new System.Drawing.Point(65, 104);
            this.cBoxLength.Name = "cBoxLength";
            this.cBoxLength.Size = new System.Drawing.Size(80, 21);
            this.cBoxLength.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Length:";
            // 
            // cBox_Upper
            // 
            this.cBox_Upper.AutoSize = true;
            this.cBox_Upper.Location = new System.Drawing.Point(15, 35);
            this.cBox_Upper.Name = "cBox_Upper";
            this.cBox_Upper.Size = new System.Drawing.Size(178, 17);
            this.cBox_Upper.TabIndex = 10;
            this.cBox_Upper.Text = "Includes Uppercase (A,B,C,D,E)";
            this.cBox_Upper.UseVisualStyleBackColor = true;
            // 
            // cBox_Numbers
            // 
            this.cBox_Numbers.AutoSize = true;
            this.cBox_Numbers.Location = new System.Drawing.Point(15, 58);
            this.cBox_Numbers.Name = "cBox_Numbers";
            this.cBox_Numbers.Size = new System.Drawing.Size(207, 17);
            this.cBox_Numbers.TabIndex = 11;
            this.cBox_Numbers.Text = "Includes Numbers (0,1,2,3,4,5,6,7,8,9)";
            this.cBox_Numbers.UseVisualStyleBackColor = true;
            // 
            // cBox_Special
            // 
            this.cBox_Special.AutoSize = true;
            this.cBox_Special.Location = new System.Drawing.Point(15, 81);
            this.cBox_Special.Name = "cBox_Special";
            this.cBox_Special.Size = new System.Drawing.Size(285, 17);
            this.cBox_Special.TabIndex = 12;
            this.cBox_Special.Text = "Includes Special (! \" § $ % & / ( ) = ? , ; . : - _ # \' + * < > )";
            this.cBox_Special.UseVisualStyleBackColor = true;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(7, 193);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(75, 13);
            this.lbl_Error.TabIndex = 13;
            this.lbl_Error.Text = "Error Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 216);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.cBox_Special);
            this.Controls.Add(this.cBox_Numbers);
            this.Controls.Add(this.cBox_Upper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxLength);
            this.Controls.Add(this.cBox_Low);
            this.Controls.Add(this.btn_Copy_Password);
            this.Controls.Add(this.tBox_SHA);
            this.Controls.Add(this.tBox_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.btn_Copy_SHA);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Copy_SHA;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_Password;
        private System.Windows.Forms.TextBox tBox_SHA;
        private System.Windows.Forms.Button btn_Copy_Password;
        private System.Windows.Forms.CheckBox cBox_Low;
        private System.Windows.Forms.ComboBox cBoxLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cBox_Upper;
        private System.Windows.Forms.CheckBox cBox_Numbers;
        private System.Windows.Forms.CheckBox cBox_Special;
        private System.Windows.Forms.Label lbl_Error;
    }
}

