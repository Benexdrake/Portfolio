namespace Quiz_Forms
{
    partial class Game
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
            this.tBox_Question = new System.Windows.Forms.TextBox();
            this.btn_AnswerA = new System.Windows.Forms.Button();
            this.btn_AnswerB = new System.Windows.Forms.Button();
            this.btn_AnswerD = new System.Windows.Forms.Button();
            this.btn_AnswerC = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.checkA = new System.Windows.Forms.RadioButton();
            this.checkB = new System.Windows.Forms.RadioButton();
            this.checkC = new System.Windows.Forms.RadioButton();
            this.checkD = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tBox_Question
            // 
            this.tBox_Question.BackColor = System.Drawing.Color.DimGray;
            this.tBox_Question.ForeColor = System.Drawing.SystemColors.Window;
            this.tBox_Question.Location = new System.Drawing.Point(12, 36);
            this.tBox_Question.Multiline = true;
            this.tBox_Question.Name = "tBox_Question";
            this.tBox_Question.ReadOnly = true;
            this.tBox_Question.Size = new System.Drawing.Size(941, 130);
            this.tBox_Question.TabIndex = 0;
            this.tBox_Question.Text = "Hier könnte eine Frage stehen";
            this.tBox_Question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_AnswerA
            // 
            this.btn_AnswerA.BackColor = System.Drawing.Color.IndianRed;
            this.btn_AnswerA.FlatAppearance.BorderSize = 0;
            this.btn_AnswerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnswerA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AnswerA.Location = new System.Drawing.Point(12, 219);
            this.btn_AnswerA.Name = "btn_AnswerA";
            this.btn_AnswerA.Size = new System.Drawing.Size(450, 100);
            this.btn_AnswerA.TabIndex = 1;
            this.btn_AnswerA.Text = "A";
            this.btn_AnswerA.UseVisualStyleBackColor = false;
            this.btn_AnswerA.Click += new System.EventHandler(this.btn_AnswerA_Click);
            // 
            // btn_AnswerB
            // 
            this.btn_AnswerB.BackColor = System.Drawing.Color.IndianRed;
            this.btn_AnswerB.FlatAppearance.BorderSize = 0;
            this.btn_AnswerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnswerB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AnswerB.Location = new System.Drawing.Point(503, 219);
            this.btn_AnswerB.Name = "btn_AnswerB";
            this.btn_AnswerB.Size = new System.Drawing.Size(450, 100);
            this.btn_AnswerB.TabIndex = 3;
            this.btn_AnswerB.Text = "B";
            this.btn_AnswerB.UseVisualStyleBackColor = false;
            this.btn_AnswerB.Click += new System.EventHandler(this.btn_AnswerB_Click);
            // 
            // btn_AnswerD
            // 
            this.btn_AnswerD.BackColor = System.Drawing.Color.IndianRed;
            this.btn_AnswerD.FlatAppearance.BorderSize = 0;
            this.btn_AnswerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnswerD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AnswerD.Location = new System.Drawing.Point(503, 325);
            this.btn_AnswerD.Name = "btn_AnswerD";
            this.btn_AnswerD.Size = new System.Drawing.Size(450, 100);
            this.btn_AnswerD.TabIndex = 5;
            this.btn_AnswerD.Text = "D";
            this.btn_AnswerD.UseVisualStyleBackColor = false;
            this.btn_AnswerD.Click += new System.EventHandler(this.btn_AnswerD_Click);
            // 
            // btn_AnswerC
            // 
            this.btn_AnswerC.BackColor = System.Drawing.Color.IndianRed;
            this.btn_AnswerC.FlatAppearance.BorderSize = 0;
            this.btn_AnswerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnswerC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AnswerC.Location = new System.Drawing.Point(12, 325);
            this.btn_AnswerC.Name = "btn_AnswerC";
            this.btn_AnswerC.Size = new System.Drawing.Size(450, 100);
            this.btn_AnswerC.TabIndex = 4;
            this.btn_AnswerC.Text = "C";
            this.btn_AnswerC.UseVisualStyleBackColor = false;
            this.btn_AnswerC.Click += new System.EventHandler(this.btn_AnswerC_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Next.Location = new System.Drawing.Point(686, 431);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(267, 100);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "Next >>>";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Back.Location = new System.Drawing.Point(12, 431);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(267, 100);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "<<< Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Visible = false;
            // 
            // checkA
            // 
            this.checkA.AutoSize = true;
            this.checkA.Location = new System.Drawing.Point(368, 194);
            this.checkA.Name = "checkA";
            this.checkA.Size = new System.Drawing.Size(94, 19);
            this.checkA.TabIndex = 8;
            this.checkA.TabStop = true;
            this.checkA.Text = "radioButton1";
            this.checkA.UseVisualStyleBackColor = true;
            this.checkA.Visible = false;
            // 
            // checkB
            // 
            this.checkB.AutoSize = true;
            this.checkB.Location = new System.Drawing.Point(503, 194);
            this.checkB.Name = "checkB";
            this.checkB.Size = new System.Drawing.Size(94, 19);
            this.checkB.TabIndex = 9;
            this.checkB.TabStop = true;
            this.checkB.Text = "radioButton2";
            this.checkB.UseVisualStyleBackColor = true;
            this.checkB.Visible = false;
            // 
            // checkC
            // 
            this.checkC.AutoSize = true;
            this.checkC.Location = new System.Drawing.Point(368, 431);
            this.checkC.Name = "checkC";
            this.checkC.Size = new System.Drawing.Size(94, 19);
            this.checkC.TabIndex = 10;
            this.checkC.TabStop = true;
            this.checkC.Text = "radioButton3";
            this.checkC.UseVisualStyleBackColor = true;
            this.checkC.Visible = false;
            // 
            // checkD
            // 
            this.checkD.AutoSize = true;
            this.checkD.Location = new System.Drawing.Point(503, 431);
            this.checkD.Name = "checkD";
            this.checkD.Size = new System.Drawing.Size(94, 19);
            this.checkD.TabIndex = 11;
            this.checkD.TabStop = true;
            this.checkD.Text = "radioButton4";
            this.checkD.UseVisualStyleBackColor = true;
            this.checkD.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.checkD);
            this.Controls.Add(this.checkC);
            this.Controls.Add(this.checkB);
            this.Controls.Add(this.checkA);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_AnswerD);
            this.Controls.Add(this.btn_AnswerC);
            this.Controls.Add(this.btn_AnswerB);
            this.Controls.Add(this.btn_AnswerA);
            this.Controls.Add(this.tBox_Question);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(967, 545);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tBox_Question;
        private Button btn_AnswerA;
        private Button btn_AnswerB;
        private Button btn_AnswerD;
        private Button btn_AnswerC;
        private Button btn_Next;
        private Button btn_Back;
        private RadioButton checkA;
        private RadioButton checkB;
        private RadioButton checkC;
        private RadioButton checkD;
    }
}
