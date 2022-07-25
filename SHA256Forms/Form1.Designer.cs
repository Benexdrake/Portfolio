namespace SHA256Forms
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
            this.button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_Password = new System.Windows.Forms.TextBox();
            this.tBox_SHA = new System.Windows.Forms.TextBox();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(482, 64);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 0;
            this.button.Text = "Change";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "SSHA256:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBox_Password
            // 
            this.tBox_Password.Location = new System.Drawing.Point(73, 5);
            this.tBox_Password.Name = "tBox_Password";
            this.tBox_Password.Size = new System.Drawing.Size(484, 23);
            this.tBox_Password.TabIndex = 3;
            // 
            // tBox_SHA
            // 
            this.tBox_SHA.Location = new System.Drawing.Point(73, 35);
            this.tBox_SHA.Name = "tBox_SHA";
            this.tBox_SHA.ReadOnly = true;
            this.tBox_SHA.Size = new System.Drawing.Size(484, 23);
            this.tBox_SHA.TabIndex = 4;
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(401, 64);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(75, 23);
            this.btn_Copy.TabIndex = 5;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 97);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.tBox_SHA);
            this.Controls.Add(this.tBox_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHA256 Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button;
        private Label label1;
        private Label label2;
        private TextBox tBox_Password;
        private TextBox tBox_SHA;
        private Button btn_Copy;
    }
}