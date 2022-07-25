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
    public partial class Start : UserControl
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Main.instance.panelChild.Controls.Clear();
            Main.instance.panelChild.Controls.Add(Main.instance.game = new Game());
        }
    }
}
