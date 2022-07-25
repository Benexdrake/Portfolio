using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Forms
{
    public partial class Game : UserControl
    {
       internal Quiz[] quiz;
        Quiz q;
        int seite;
        int points;

        bool isClickedA,isClickedB,isClickedC,isClickedD;
        public Game()
        {
            InitializeComponent();
            Json json = new Json();
            quiz = json.loadJson();
            
            loadPage();

        }

        public void loadPage()
        {
            Main.instance.lblPage.Text = (seite+1) + "/" + quiz.Length;
            Main.instance.lblPoints.Text = points.ToString();
            q = quiz[seite];
            tBox_Question.Text = quiz[seite].question;
            btn_AnswerA.Text = quiz[seite].answerA;
            btn_AnswerB.Text = quiz[seite].answerB;
            btn_AnswerC.Text = quiz[seite].answerC;
            btn_AnswerD.Text = quiz[seite].answerD;
            uncheckAll();
        }

        void uncheckAll()
        {
            uncheckButton(btn_AnswerA);
            uncheckButton(btn_AnswerB);
            uncheckButton(btn_AnswerC);
            uncheckButton(btn_AnswerD);
            isClickedA = false;
            isClickedB = false;
            isClickedC = false;
            isClickedD = false;
        }

        void checkAnswer()
        {
            if(checkA.Checked == true && q.checkA == true)
            {
                points += 1;
            }
            else if(checkB.Checked == true && q.checkB == true)
            {
                points += 1;
            }
            else if(checkC.Checked == true && q.checkC == true)
            {
                points += 1;
            }
            else if(checkD.Checked == true && q.checkD == true)
            {
                points += 1;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

            if(isClickedA == true || isClickedB == true || isClickedC == true || isClickedD == true)
            {
            checkAnswer();
            seite++;
            if (seite < quiz.Length)
            {
                loadPage();
            }
            else if (seite == quiz.Length)
            {
                    Main.instance.lblPoints.Text = points.ToString();
                    Main.instance.panelChild.Controls.Clear();
                Main.instance.panelChild.Controls.Add(Main.instance.end = new End());
                    Main.instance.end.lbl_End.Text = "Sie haben " + points + "/" + quiz.Length + " punkten erreicht";
            }

            if (seite == quiz.Length - 1)
            {
                btn_Next.Text = "End >>>";
            }
            }
            else
            {
                MessageBox.Show("Bitte eine Antwort auswählen!");
            }
        }

        private void btn_AnswerA_Click(object sender, EventArgs e)
        {
            uncheckAll();
            checkA.Checked = true;
            if (isClickedA)
            {
                uncheckButton(sender);
                isClickedA = false;
            }
            else
            {
            checkButton(sender);
                isClickedA=true;
            }
        }

        private void btn_AnswerB_Click(object sender, EventArgs e)
        {
            uncheckAll();
            checkB.Checked = true;
            if (isClickedB)
            {
                uncheckButton(sender);
                isClickedB = false;
            }
            else
            {
                checkButton(sender);
                isClickedB = true;
            }
        }

        private void btn_AnswerC_Click(object sender, EventArgs e)
        {
            uncheckAll();
            checkC.Checked = true;
            if (isClickedC)
            {
                uncheckButton(sender);
                isClickedC = false;
            }
            else
            {
                checkButton(sender);
                isClickedC = true;
            }
        }

        private void btn_AnswerD_Click(object sender, EventArgs e)
        {
            uncheckAll();
            checkD.Checked = true;
            if (isClickedD)
            {
                uncheckButton(sender);
                isClickedD = false;
            }
            else
            {
                checkButton(sender);
                isClickedD = true;
            }

        }

        void checkButton(object button)
        {
            Button btn = button as Button;
            btn.FlatAppearance.BorderColor = Color.White;
            btn.FlatAppearance.BorderSize = 5;
            btn.BackColor = Color.Green;
        }

        void uncheckButton(object button)
        {
            Button btn = button as Button;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.IndianRed;
        }
    }
}
