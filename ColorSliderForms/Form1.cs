namespace ColorSliderForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBarRed.Value = 128;
            trackBarGreen.Value = 128;
            trackBarBlue.Value = 128;
            lblHex.Click += LblHex_Click; // Click Action Listener Event
        }
        
        private void LblHex_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText($"#{trackBarRed.Value.ToString("X")}{trackBarGreen.Value.ToString("X")}{trackBarBlue.Value.ToString("X")}");
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            panelColorArea.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            label1.Text = $" Red: {trackBarRed.Value}";
            label2.Text = $" Green: {trackBarGreen.Value}";
            label3.Text = $" Blue: {trackBarBlue.Value}";

            lblHex.Text = $"Hex: {trackBarRed.Value.ToString("X")}{trackBarGreen.Value.ToString("X")}{trackBarBlue.Value.ToString("X")}";

            if(trackBarRed.Value <= 128 && trackBarGreen.Value <= 128 && trackBarBlue.Value <= 128)
            {
                lblHex.ForeColor = Color.White;
            }
            else
            {
                lblHex.ForeColor = Color.Black;
            }
        }
    }
}