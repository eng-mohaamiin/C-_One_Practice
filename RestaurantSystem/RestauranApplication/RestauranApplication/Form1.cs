using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestauranApplication
{
    public partial class Form1 : Form
    {
        // Form constructor
        public Form1()
        {
            // Initialize all form controls
            InitializeComponent();
        }

        // Calculate button event
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare food name variables
                string food1, food2;

                // Declare price and calculation variables
                double priceFood1, priceFood2;
                double salesTax, Tips;
                double Total_amount, Net_amount, full;

                // Get food one name from the textbox
                food1 = txt_FoodOne.Text;

                // Get food two name from the textbox
                food2 = txt_Foodtwo.Text;

                // Convert food one price from text to double
                priceFood1 = double.Parse(txt_priceOne.Text);

                // Convert food two price from text to double
                priceFood2 = double.Parse(txt_priceTwo.Text);

                // Convert tip amount from text to double
                Tips = double.Parse(txt_Amount_Tips.Text);

                // Calculate the full amount before tax and tip
                full = priceFood1 + priceFood2;

                // Calculate 5% sales tax
                salesTax = full * 0.05;

                // Calculate total amount including tax and tips
                Total_amount = full + salesTax + Tips;

                // Calculate net amount
                Net_amount = Total_amount;

                // Display the sales tax
                this.salesTax.Text = salesTax.ToString("0.00");

                // Display the tip amount
                lbl_TipAmount.Text = Tips.ToString("0.00");

                // Display the total amount
                lbl_TotalAmount.Text = Total_amount.ToString("0.00");

                // Display the net amount
                lbl_NetAmount.Text = Net_amount.ToString("0.00");
            }
            catch (FormatException)
            {
                // Show error message when the user enters invalid numbers
                MessageBox.Show(
                    "Please enter valid numbers for the food prices and tips.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                MessageBox.Show(
                    "An error occurred: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // TextBox6 text changed event
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // This event runs when the text in TextBox6 changes
        }

        // Label5 click event
        private void label5_Click(object sender, EventArgs e)
        {
            // This event runs when Label5 is clicked
        }

        // Clear button event
        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear food one input
            txt_FoodOne.Clear();

            // Clear food two input
            txt_Foodtwo.Clear();

            // Clear food one price input
            txt_priceOne.Clear();

            // Clear food two price input
            txt_priceTwo.Clear();

            // Clear tips input
            txt_Amount_Tips.Clear();

            // Clear sales tax result
            this.salesTax.Text = "";

            // Clear tip amount result
            lbl_TipAmount.Text = "";

            // Clear total amount result
            lbl_TotalAmount.Text = "";

            // Clear net amount result
            lbl_NetAmount.Text = "";

            // Set the cursor to the first textbox
            txt_FoodOne.Focus();
        }

        // Close button event
        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }
    }
}