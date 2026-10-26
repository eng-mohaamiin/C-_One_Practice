namespace ForLoopsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 10; i++)
            {
                result.Items.Add("I Love Allah");
            }
        }

        private void result_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
