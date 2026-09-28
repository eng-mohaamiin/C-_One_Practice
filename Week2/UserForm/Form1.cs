using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Validate names and display full name
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the first name is empty

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // Check if the first name is empty

                MessageBox.Show("First Name is required");
                return;
            }

            // Check if the last name is empty
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                // Show an error message
                MessageBox.Show("Last Name is required");

                // Stop the code
                return;
            }

            // Get the first name
            string firstName = textBox1.Text;

            // Get the last name
            string lastName = textBox2.Text;

            // Combine first name and last name
            string fullName = firstName + " " + lastName;

            // Display the full name
            textBox3.Text = fullName;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Clear all text boxes
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Show greeting
        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "Hello Mohamed Amiin";
        }

        // Clear label
        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        // Close window
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
