namespace LoginMySqlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pBoxAvatar = new System.Windows.Forms.PictureBox();
            this.tBox_Username = new System.Windows.Forms.TextBox();
            this.tBox_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.cBoxPassword = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxAvatar
            // 
            this.pBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pBoxAvatar.Image")));
            this.pBoxAvatar.Location = new System.Drawing.Point(70, 12);
            this.pBoxAvatar.Name = "pBoxAvatar";
            this.pBoxAvatar.Size = new System.Drawing.Size(207, 200);
            this.pBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxAvatar.TabIndex = 1;
            this.pBoxAvatar.TabStop = false;
            // 
            // tBox_Username
            // 
            this.tBox_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tBox_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_Username.Location = new System.Drawing.Point(12, 233);
            this.tBox_Username.Name = "tBox_Username";
            this.tBox_Username.PlaceholderText = "Username";
            this.tBox_Username.Size = new System.Drawing.Size(322, 29);
            this.tBox_Username.TabIndex = 2;
            // 
            // tBox_Password
            // 
            this.tBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tBox_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_Password.Location = new System.Drawing.Point(12, 269);
            this.tBox_Password.Name = "tBox_Password";
            this.tBox_Password.PasswordChar = '*';
            this.tBox_Password.PlaceholderText = "Password";
            this.tBox_Password.Size = new System.Drawing.Size(322, 29);
            this.tBox_Password.TabIndex = 3;
            this.tBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBox_Password_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Error Text";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Teal;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Login.Location = new System.Drawing.Point(210, 309);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(124, 43);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // cBoxPassword
            // 
            this.cBoxPassword.AutoSize = true;
            this.cBoxPassword.Location = new System.Drawing.Point(12, 309);
            this.cBoxPassword.Name = "cBoxPassword";
            this.cBoxPassword.Size = new System.Drawing.Size(147, 19);
            this.cBoxPassword.TabIndex = 6;
            this.cBoxPassword.Text = "Check to See Password";
            this.cBoxPassword.UseVisualStyleBackColor = true;
            this.cBoxPassword.CheckedChanged += new System.EventHandler(this.cBoxPassword_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Location = new System.Drawing.Point(12, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 5);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Location = new System.Drawing.Point(12, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 5);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(346, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cBoxPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_Password);
            this.Controls.Add(this.tBox_Username);
            this.Controls.Add(this.pBoxAvatar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pBoxAvatar;
        private TextBox tBox_Username;
        private TextBox tBox_Password;
        private Label label1;
        private Button btn_Login;
        private CheckBox cBoxPassword;
        private Panel panel1;
        private Panel panel2;
    }
}