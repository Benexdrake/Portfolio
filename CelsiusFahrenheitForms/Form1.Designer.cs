namespace CelsiusFahrenheitForms
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
            this.tBox_Anzeige = new System.Windows.Forms.TextBox();
            this.tBox_Eingabe = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.rButton_Fahrenheit = new System.Windows.Forms.RadioButton();
            this.rButton_Celsius = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tBox_Anzeige
            // 
            this.tBox_Anzeige.Location = new System.Drawing.Point(36, 12);
            this.tBox_Anzeige.Name = "tBox_Anzeige";
            this.tBox_Anzeige.ReadOnly = true;
            this.tBox_Anzeige.Size = new System.Drawing.Size(275, 23);
            this.tBox_Anzeige.TabIndex = 2;
            // 
            // tBox_Eingabe
            // 
            this.tBox_Eingabe.Location = new System.Drawing.Point(36, 50);
            this.tBox_Eingabe.Name = "tBox_Eingabe";
            this.tBox_Eingabe.PlaceholderText = "Bitte eine Ganzzahl eingeben";
            this.tBox_Eingabe.Size = new System.Drawing.Size(275, 23);
            this.tBox_Eingabe.TabIndex = 3;
            this.tBox_Eingabe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBox_Eingabe_KeyDown);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(236, 79);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 4;
            this.btn_Change.Text = "Umwandeln";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // rButton_Fahrenheit
            // 
            this.rButton_Fahrenheit.AutoSize = true;
            this.rButton_Fahrenheit.Checked = true;
            this.rButton_Fahrenheit.Location = new System.Drawing.Point(36, 83);
            this.rButton_Fahrenheit.Name = "rButton_Fahrenheit";
            this.rButton_Fahrenheit.Size = new System.Drawing.Size(81, 19);
            this.rButton_Fahrenheit.TabIndex = 5;
            this.rButton_Fahrenheit.TabStop = true;
            this.rButton_Fahrenheit.Text = "Fahrenheit";
            this.rButton_Fahrenheit.UseVisualStyleBackColor = true;
            this.rButton_Fahrenheit.CheckedChanged += new System.EventHandler(this.rButton_Fahrenheit_CheckedChanged);
            // 
            // rButton_Celsius
            // 
            this.rButton_Celsius.AutoSize = true;
            this.rButton_Celsius.Location = new System.Drawing.Point(36, 108);
            this.rButton_Celsius.Name = "rButton_Celsius";
            this.rButton_Celsius.Size = new System.Drawing.Size(62, 19);
            this.rButton_Celsius.TabIndex = 6;
            this.rButton_Celsius.TabStop = true;
            this.rButton_Celsius.Text = "Celsius";
            this.rButton_Celsius.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 147);
            this.Controls.Add(this.rButton_Celsius);
            this.Controls.Add(this.rButton_Fahrenheit);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.tBox_Eingabe);
            this.Controls.Add(this.tBox_Anzeige);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Celsius Fahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tBox_Anzeige;
        private TextBox tBox_Eingabe;
        private Button btn_Change;
        private RadioButton rButton_Fahrenheit;
        private RadioButton rButton_Celsius;
    }
}