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
    public partial class End : UserControl
    {
        public End()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int.TryParse(Main.instance.lblPoints.Text, out int point);
            int.TryParse(Main.instance.lblHighscore.Text , out int highscore);

            if(point > highscore)
            {
            Main.instance.lblHighscore.Text = Main.instance.lblPoints.Text;
            }
            Main.instance.panelChild.Controls.Clear();
            Main.instance.panelChild.Controls.Add(Main.instance.game = new Game());
        }
    }
}
