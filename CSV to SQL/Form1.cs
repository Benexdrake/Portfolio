namespace CSV_to_SQL
{
    public partial class Form1 : Form
    {
        ImportCSV importCSV;
        List<Records> recordsList;
        List<Records> uploadReady;

        public Form1()
        {
            InitializeComponent();
            importCSV = new ImportCSV();
            uploadReady = new List<Records>();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            dGridView.DataSource = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open CSV File";
            theDialog.Filter = "CSV files|*.CSV";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(theDialog.FileName.ToString());
                lbl_FileName.Text = theDialog.SafeFileName;
                recordsList = importCSV.OpenFile(theDialog.FileName);
                dGridView.DataSource = recordsList;
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if(recordsList != null)
            {
                dGridView.DataSource = null;
                uploadReady = importCSV.FindDublicates();
                dGridView.DataSource = uploadReady;
            }
        }

        private void btn_LoadData_Click(object sender, EventArgs e)
        {
            var sql = new MySQLDB();
            dGridView.DataSource = sql.sqlRead("select * from Performance_DataRecords;");
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            if(uploadReady.Count > 0)
            {
                var sql = new MySQLDB();
                sql.sqlWrite(uploadReady);
                uploadReady.Clear();
            }
        }
    }
}