namespace Quiz_Forms
{
    partial class End
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
            this.lbl_End = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_End
            // 
            this.lbl_End.AutoSize = true;
            this.lbl_End.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_End.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_End.Location = new System.Drawing.Point(101, 103);
            this.lbl_End.Name = "lbl_End";
            this.lbl_End.Size = new System.Drawing.Size(728, 65);
            this.lbl_End.TabIndex = 4;
            this.lbl_End.Text = "Sie haben 5/6 punkten erreicht";
            this.lbl_End.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Navy;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Start.Location = new System.Drawing.Point(293, 323);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(363, 155);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Press for new Game";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_End);
            this.Name = "End";
            this.Size = new System.Drawing.Size(967, 581);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label lbl_End;
        private Button btn_Start;
    }
}
