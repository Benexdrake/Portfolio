namespace UmwandlerForms
{
    public partial class Form1 : Form
    {
        Wandler wandler;
        DatenGroesse DatenGroesse;

        public Form1()
        {
            InitializeComponent();
            wandler = new Wandler();
            DatenGroesse = new DatenGroesse();
            FillMenuBox();

        }

        private void FillMenuBox()
        {
            cBoxMenu.Items.Clear();
            foreach (var item in wandler.MenuItems)
            {
                cBoxMenu.Items.Add(item);
            }
            cBoxMenu.SelectedIndex = 0;
        }

        private void changeBox()
        {
            cBox1.Items.Clear();
            cBox2.Items.Clear();
            for (int i = 0; i < wandler.Items[cBoxMenu.SelectedIndex].Length; i++)
            {
                cBox1.Items.Add(wandler.Items[cBoxMenu.SelectedIndex][i]);
                cBox2.Items.Add(wandler.Items[cBoxMenu.SelectedIndex][i]);
            }
            cBox1.SelectedIndex = 0;
            cBox2.SelectedIndex = 1;
        }

        private void checkSelectedIndex()
        {
            if(cBox1.SelectedIndex == cBox2.SelectedIndex)
            {
                if(cBox1.SelectedIndex >=0 && cBox1.SelectedIndex < cBox1.Items.Count-1)
                {
                    cBox2.SelectedIndex++;
                }
                else
                {
                    cBox2.SelectedIndex = 0;
                }
            }
        }
        

        private void cBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSelectedIndex();
        }

        private void cBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeBox();
        }

        private void cBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSelectedIndex();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if(tBox_Input.Text != String.Empty)
            {

            switch(cBoxMenu.SelectedIndex)
            {
                case 0:
                    tBox_Output.Text = DatenGroesse.Menu(cBox1.SelectedIndex,cBox2.SelectedIndex,float.Parse(tBox_Input.Text)).ToString();
                    break;
            }
            }
        }
    }
}