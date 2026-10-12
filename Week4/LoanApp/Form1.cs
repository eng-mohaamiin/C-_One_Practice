using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
private void button2_Click(object sender, EventArgs e)
        {
            // Declare variables
            double salary, yearsExperience, validation;

            // Set the minimum required experience
            const double YEARS_EXP = 2;

            // Validate user input before processing
            if (double.TryParse(SalaryInput.Text, out validation) &
                double.TryParse(experienceInput.Text, out yearsExperience))
            {
                try
                {
                    // Get values from input fields
                    salary = double.Parse(SalaryInput.Text);
                    yearsExperience = double.Parse(experienceInput.Text);

                    // Ensure that input values are positive
                    if (salary > 0 & yearsExperience > 0)
                    {
                        // Check the minimum salary requirement
                        if (salary >= 200)
                        {
                            // Check the minimum experience requirement
                            if (yearsExperience >= YEARS_EXP)
                            {
                                // Display loan approval message
                                resultInput.Text = "Your Qualify on loan";
                            }
                            else
                            {
                                // Display experience requirement message
                                resultInput.Text = "You Experience must be Greater than 2 years";
                            }
                        }
                        else
                        {
                            // Display salary requirement message
                            resultInput.Text = "You Salary is less than 200 ";
                        }
                    }
                    else
                    {
                        // Display input validation error
                        resultInput.Text = "Salary and years of exprience must be Positive";
                    }
                }
                catch (Exception ex)
                {
                    // Show unexpected errors
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // Display invalid input message
                resultInput.Text = "Salary and Years of Experience Must be Integer";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeBg_Click(object sender, EventArgs e)
        {
            // Set qualification button colors
            btnQualification.BackColor = Color.AliceBlue;
            btnQualification.ForeColor = Color.Navy;

            // Set background change button colors
            btnChangeBg.BackColor = Color.DodgerBlue;
            btnChangeBg.ForeColor = Color.White;
        }
    }
}
