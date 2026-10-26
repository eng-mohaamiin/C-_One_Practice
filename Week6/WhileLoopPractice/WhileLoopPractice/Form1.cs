namespace WhileLoopPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);

            int i = 1;

            while (i <= number)
            {
                result.Items.Add(i);

                i++;
            }
        }

        private void btnCleaer_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            result.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
