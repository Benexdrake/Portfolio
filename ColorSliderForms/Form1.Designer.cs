namespace ColorSliderForms
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
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelColorArea = new System.Windows.Forms.Panel();
            this.lblHex = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.panelChild.SuspendLayout();
            this.panelColorArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChild
            // 
            this.panelChild.Controls.Add(this.panelColorArea);
            this.panelChild.Controls.Add(this.trackBarBlue);
            this.panelChild.Controls.Add(this.trackBarGreen);
            this.panelChild.Controls.Add(this.label3);
            this.panelChild.Controls.Add(this.label2);
            this.panelChild.Controls.Add(this.label1);
            this.panelChild.Controls.Add(this.trackBarRed);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(0, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(852, 141);
            this.panelChild.TabIndex = 0;
            // 
            // panelColorArea
            // 
            this.panelColorArea.Controls.Add(this.lblHex);
            this.panelColorArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelColorArea.Location = new System.Drawing.Point(691, 0);
            this.panelColorArea.Name = "panelColorArea";
            this.panelColorArea.Size = new System.Drawing.Size(161, 141);
            this.panelColorArea.TabIndex = 6;
            // 
            // lblHex
            // 
            this.lblHex.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHex.Location = new System.Drawing.Point(0, 0);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(161, 31);
            this.lblHex.TabIndex = 0;
            this.lblHex.Text = "Hex";
            this.lblHex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(83, 105);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(602, 45);
            this.trackBarBlue.TabIndex = 5;
            this.trackBarBlue.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(83, 54);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(602, 45);
            this.trackBarGreen.TabIndex = 4;
            this.trackBarGreen.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red:";
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(83, 3);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(602, 45);
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 141);
            this.Controls.Add(this.panelChild);
            this.MaximumSize = new System.Drawing.Size(868, 180);
            this.MinimumSize = new System.Drawing.Size(868, 180);
            this.Name = "Form1";
            this.Text = "Color Slider";
            this.panelChild.ResumeLayout(false);
            this.panelChild.PerformLayout();
            this.panelColorArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelChild;
        private Panel panelColorArea;
        private TrackBar trackBarBlue;
        private TrackBar trackBarGreen;
        private Label label3;
        private Label label2;
        private Label label1;
        private TrackBar trackBarRed;
        private Label lblHex;
    }
}