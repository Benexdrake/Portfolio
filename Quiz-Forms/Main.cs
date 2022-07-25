namespace Quiz_Forms
{
    public partial class Main : Form
    {
        public static Main instance;

        internal Game game;
        internal Start start;
        internal End end;

        public Main()
        {
            InitializeComponent();
            start = new Start();
            //game = new Game();
            //end = new End();
            instance = this;
            
            panelChild.Controls.Add(start);
        }
    }
}