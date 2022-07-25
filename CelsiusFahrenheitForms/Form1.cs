namespace CelsiusFahrenheitForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBox_Eingabe_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Change_Click(sender, e);
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if(tBox_Eingabe.Text != "")
            {
                if(rButton_Celsius.Checked)
                {
                   tBox_Anzeige.Text = FahrenheitToCelsius(tBox_Eingabe.Text);
                }
                else
                {
                    tBox_Anzeige.Text = CelsiusToFahrenheit(tBox_Eingabe.Text);
                }
            }
            else
            {
                tBox_Anzeige.Text = "Please Enter a Number";
            }
        }

        public string FahrenheitToCelsius(string n)
        {
            int number;

            bool isNumber = int.TryParse(n, out number);
            if(isNumber)
            {
                // Berechnung
                number = (number - 32) * 5 / 9;
                return number.ToString();
            }
            else
            {
                return "Error not a Number";
            }
        }

        public string CelsiusToFahrenheit(string n)
        {
            double number;

            bool isNumber = double.TryParse(n, out number);
            if (isNumber)
            {
                // Berechnung
                number = number * 1.8 + 32;
                return number.ToString();
            }
            else
            {
                return "Error not a Number";
            }
        }

        private void rButton_Fahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            btn_Change_Click(sender, e);
        }
    }
}