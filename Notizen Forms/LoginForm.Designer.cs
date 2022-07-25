namespace Notizen_Forms
{
    partial class LoginForm
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_Password = new System.Windows.Forms.TextBox();
            this.tBox_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pBox_Password = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Password)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(265, 79);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            // 
            // tBox_Password
            // 
            this.tBox_Password.Location = new System.Drawing.Point(77, 50);
            this.tBox_Password.Name = "tBox_Password";
            this.tBox_Password.PasswordChar = '*';
            this.tBox_Password.PlaceholderText = "Password";
            this.tBox_Password.Size = new System.Drawing.Size(263, 23);
            this.tBox_Password.TabIndex = 1;
            this.tBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBox_Password_KeyDown);
            // 
            // tBox_Username
            // 
            this.tBox_Username.Location = new System.Drawing.Point(77, 21);
            this.tBox_Username.Name = "tBox_Username";
            this.tBox_Username.PlaceholderText = "Username";
            this.tBox_Username.Size = new System.Drawing.Size(263, 23);
            this.tBox_Username.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // pBox_Password
            // 
            this.pBox_Password.Image = global::Notizen_Forms.Properties.Resources.hidden;
            this.pBox_Password.Location = new System.Drawing.Point(344, 50);
            this.pBox_Password.Name = "pBox_Password";
            this.pBox_Password.Size = new System.Drawing.Size(22, 23);
            this.pBox_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_Password.TabIndex = 4;
            this.pBox_Password.TabStop = false;
            this.pBox_Password.Click += new System.EventHandler(this.pBox_Password_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 117);
            this.Controls.Add(this.pBox_Password);
            this.Controls.Add(this.tBox_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBox_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(386, 156);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(386, 156);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Login;
        private Label label1;
        private TextBox tBox_Password;
        private TextBox tBox_Username;
        private Label label2;
        private PictureBox pBox_Password;
    }
}