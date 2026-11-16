
namespace Bmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Assign variable values
                double weight;
                double height;
                double Bmi;
                string result = "";

                // Check user input
                if (double.TryParse(txtWeight.Text, out weight) &&

                    double.TryParse(txtHeight.Text, out height))
                {
                    // Check weight and height
                    if (weight > 0 && height > 0)
                    {
                        // Calculate BMI
                        Bmi = weight / (height * height);

                        // Check BMI category
                        if (Bmi < 18.5)
                        {
                            result = "UnderWeight";
                        }
                        else
                        {
                            if (Bmi <= 25)
                            {
                                result = "Optimal Weight";
                            }
                            else
                            {
                                result = "OverWeight";
                            }
                        }

                        // Display result
                        resultData.Text = result + " BMI: " + Bmi.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Weight and height must be greater than zero.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numbers.");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong.");
            }
        }
    }
}
