using System;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class Form1 : Form
    {
        int player = 1;
        int playerCount1 = 0;
        int playerCount2 = 0;
        string playerOne = "X";
        string playerTwo = "O";
        Button btn;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChose(object sender, EventArgs e)
        {
            btn = sender as Button;
            PlayerChangeMark();
            AreYouWinningSon();
            playerText.Text = Convert.ToString(player);
        }

        public void PlayerChangeMark()
        {
            if(player == 1)
            {
                btn.Text = playerOne;
                btn.Enabled = false;
                player = 2;
            }
            else if(player == 2)
            {
                btn.Text = playerTwo;
                btn.Enabled = false;
                player = 1;
            }
            else if(player <1 || player > 2)
            {
                player = 1;
            }
        }

        public void AreYouWinningSon()
        {
            if(
                (button1.Text == playerOne && button2.Text == playerOne && button3.Text == playerOne) ||
                (button4.Text == playerOne && button5.Text == playerOne && button6.Text == playerOne) ||
                (button7.Text == playerOne && button8.Text == playerOne && button9.Text == playerOne) ||
                (button1.Text == playerOne && button4.Text == playerOne && button7.Text == playerOne) ||
                (button2.Text == playerOne && button5.Text == playerOne && button8.Text == playerOne) ||
                (button3.Text == playerOne && button6.Text == playerOne && button9.Text == playerOne) ||
                (button1.Text == playerOne && button5.Text == playerOne && button9.Text == playerOne) ||
                (button3.Text == playerOne && button4.Text == playerOne && button7.Text == playerOne))
            {
                MessageBox.Show("Player 1 Wins the Game!");
                restart();
                ++playerCount1;
                player1Count.Text = Convert.ToString(playerCount1);
                player = 2;
            }
            else if (
                (button1.Text == playerTwo && button2.Text == playerTwo && button3.Text == playerTwo) ||
                (button4.Text == playerTwo && button5.Text == playerTwo && button6.Text == playerTwo) ||
                (button7.Text == playerTwo && button8.Text == playerTwo && button9.Text == playerTwo) ||
                (button1.Text == playerTwo && button4.Text == playerTwo && button7.Text == playerTwo) ||
                (button2.Text == playerTwo && button5.Text == playerTwo && button8.Text == playerTwo) ||
                (button3.Text == playerTwo && button6.Text == playerTwo && button9.Text == playerTwo) ||
                (button1.Text == playerTwo && button5.Text == playerTwo && button9.Text == playerTwo) ||
                (button3.Text == playerTwo && button5.Text == playerTwo && button7.Text == playerTwo))
            {
                MessageBox.Show("Player 2 Wins the Game!");
                restart();
                ++playerCount2;
                player2Count.Text = Convert.ToString(playerCount2);
                player = 1;
            }
            else if(
                (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" &&
                button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
                )
            {
                MessageBox.Show("No one Wins, Game Ends now!");
                restart();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void restart()
        {
            
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
        }
    }
}
