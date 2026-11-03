namespace DialogBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Reading the file using open file dialog

            // import classes
            StreamReader Reads;

            // create dialog results
            DialogResult Results;

            OpenFileDialog openFile = new OpenFileDialog();

            // Result variable only stores OK or Cancel
            Results = openFile.ShowDialog();

            // checking the user selection
            if (Results == DialogResult.OK)
            {
                // open the file
                Reads = File.OpenText(openFile.FileName);

                // proccess the file 
                string lines;
                while (Reads.EndOfStream == false)
                {
                    lines = Reads.ReadLine();

                    // store list box when reading item file
                    ResultListBox.Items.Add(lines);
                }
            }
            else if (Results == DialogResult.Cancel)
            {
                MessageBox.Show("Waa la kansalay");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultListBox.Items.Clear();
        }
    }
}
