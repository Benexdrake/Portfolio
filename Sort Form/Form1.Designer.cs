namespace Sort_Form_Demo
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
            this.lbl_Time = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.cBox_Sort = new System.Windows.Forms.ComboBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.trackBar_MaxNumber = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tBox_MaxNumber = new System.Windows.Forms.TextBox();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.panel_Color = new System.Windows.Forms.Panel();
            this.lbl_MaxSpeed = new System.Windows.Forms.Label();
            this.tBox_MaxSpeed = new System.Windows.Forms.TextBox();
            this.trackBar_MaxSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_MaxNumber)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_MaxSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(394, 85);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(34, 15);
            this.lbl_Time.TabIndex = 32;
            this.lbl_Time.Text = "00:00";
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(346, 5);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(87, 49);
            this.btn_Stop.TabIndex = 30;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // cBox_Sort
            // 
            this.cBox_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Sort.FormattingEnabled = true;
            this.cBox_Sort.Items.AddRange(new object[] {
            "Bubble Sort",
            "Quick Sort",
            "Selection Sort",
            "Insertion Sort",
            "Heap Sort",
            "Shell Sort",
            "Cocktail Shaker Sort",
            "Gnome Sort"});
            this.cBox_Sort.Location = new System.Drawing.Point(12, 9);
            this.cBox_Sort.Name = "cBox_Sort";
            this.cBox_Sort.Size = new System.Drawing.Size(159, 23);
            this.cBox_Sort.TabIndex = 29;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(253, 5);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(87, 49);
            this.btn_Start.TabIndex = 25;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // trackBar_MaxNumber
            // 
            this.trackBar_MaxNumber.Location = new System.Drawing.Point(12, 85);
            this.trackBar_MaxNumber.Maximum = 300;
            this.trackBar_MaxNumber.Minimum = 50;
            this.trackBar_MaxNumber.Name = "trackBar_MaxNumber";
            this.trackBar_MaxNumber.Size = new System.Drawing.Size(359, 45);
            this.trackBar_MaxNumber.TabIndex = 27;
            this.trackBar_MaxNumber.Value = 50;
            this.trackBar_MaxNumber.ValueChanged += new System.EventHandler(this.trackBar_MaxNumber_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.tBox_MaxNumber);
            this.panel1.Controls.Add(this.lbl_Color);
            this.panel1.Controls.Add(this.panel_Color);
            this.panel1.Controls.Add(this.lbl_MaxSpeed);
            this.panel1.Controls.Add(this.tBox_MaxSpeed);
            this.panel1.Controls.Add(this.trackBar_MaxSpeed);
            this.panel1.Controls.Add(this.btn_Stop);
            this.panel1.Controls.Add(this.lbl_Time);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Start);
            this.panel1.Controls.Add(this.trackBar_MaxNumber);
            this.panel1.Controls.Add(this.cBox_Sort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 142);
            this.panel1.TabIndex = 33;
            // 
            // tBox_MaxNumber
            // 
            this.tBox_MaxNumber.Location = new System.Drawing.Point(91, 63);
            this.tBox_MaxNumber.Name = "tBox_MaxNumber";
            this.tBox_MaxNumber.Size = new System.Drawing.Size(34, 23);
            this.tBox_MaxNumber.TabIndex = 28;
            this.tBox_MaxNumber.Text = "50";
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(812, 12);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(39, 15);
            this.lbl_Color.TabIndex = 37;
            this.lbl_Color.Text = "Color:";
            // 
            // panel_Color
            // 
            this.panel_Color.Location = new System.Drawing.Point(812, 30);
            this.panel_Color.Name = "panel_Color";
            this.panel_Color.Size = new System.Drawing.Size(100, 100);
            this.panel_Color.TabIndex = 36;
            this.panel_Color.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Color_MouseClick);
            // 
            // lbl_MaxSpeed
            // 
            this.lbl_MaxSpeed.AutoSize = true;
            this.lbl_MaxSpeed.Location = new System.Drawing.Point(447, 63);
            this.lbl_MaxSpeed.Name = "lbl_MaxSpeed";
            this.lbl_MaxSpeed.Size = new System.Drawing.Size(68, 15);
            this.lbl_MaxSpeed.TabIndex = 34;
            this.lbl_MaxSpeed.Text = "Max Speed:";
            // 
            // tBox_MaxSpeed
            // 
            this.tBox_MaxSpeed.Location = new System.Drawing.Point(521, 63);
            this.tBox_MaxSpeed.Name = "tBox_MaxSpeed";
            this.tBox_MaxSpeed.Size = new System.Drawing.Size(34, 23);
            this.tBox_MaxSpeed.TabIndex = 35;
            this.tBox_MaxSpeed.Text = "0";
            // 
            // trackBar_MaxSpeed
            // 
            this.trackBar_MaxSpeed.Location = new System.Drawing.Point(447, 85);
            this.trackBar_MaxSpeed.Maximum = 1000;
            this.trackBar_MaxSpeed.Name = "trackBar_MaxSpeed";
            this.trackBar_MaxSpeed.Size = new System.Drawing.Size(359, 45);
            this.trackBar_MaxSpeed.TabIndex = 33;
            this.trackBar_MaxSpeed.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Max Length:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(924, 466);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 600);
            this.MinimumSize = new System.Drawing.Size(940, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_MaxNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_MaxSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lbl_Time;
        private Button btn_Stop;
        private ComboBox cBox_Sort;
        private Button btn_Start;
        private TrackBar trackBar_MaxNumber;
        private Panel panel1;
        private Label lbl_MaxSpeed;
        private TextBox tBox_MaxSpeed;
        private TrackBar trackBar_MaxSpeed;
        private Label label1;
        private TextBox tBox_MaxNumber;
        private Panel panel_Color;
        private Label lbl_Color;
    }
}