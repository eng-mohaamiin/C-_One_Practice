using System;
using System.IO;
using System.Windows.Forms;

namespace AssigmentsFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // CREATE FILE
        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            // this is creating in this form
            outputFile = File.CreateText("data.txt");

            // this is creating file another path from  my local D
            //outputFile = File.CreateText(@"D:\data.txt");
            outputFile.Close();

            MessageBox.Show("File Created Successfully!");
        }

        // WRITE FILE
        private void btnWrite_Click_1(object sender, EventArgs e)
        {
            // Declare StreamWriter variable
            StreamWriter outputFile;

            // Open the file and prepare to append data
            outputFile = File.AppendText("data.txt");

            // Write the first line into the file
            outputFile.WriteLine("Hello I'm Mohamed Amiin");

            outputFile.WriteLine("I'm one of African fastest teenage typists");

            outputFile.Close();

            MessageBox.Show("Data Written Successfully!");
        }

        // APPEND FILE
        private void btnAppend_Click(object sender, EventArgs e)
        {
            // Declare StreamWriter variable
            StreamWriter outputFile;

            // Open the file and prepare to append new data
            outputFile = File.AppendText("data.txt");

            // Add a new line at the end of the file
            outputFile.WriteLine("I love writing code every day.");

            outputFile.Close();

            // Display success message
            MessageBox.Show("Data Appended Successfully!");
        }

        // READ FILE
        private void btnRead_Click(object sender, EventArgs e)
        {
            // Declare StreamReader variable
            StreamReader inputFile;

            // Open the file for reading
            inputFile = File.OpenText("data.txt");

            result.Items.Clear();

            // Repeat reading while the file has more data
            while (!inputFile.EndOfStream)
            {
                // Read one character from the file
                int character = inputFile.Read();

                // Convert the integer into a character and add it to the ListBox
                result.Items.Add((char)character);
            }

            inputFile.Close();

            MessageBox.Show("Data Read Successfully!");
        }

        // READ ALL FILE
        private void btnReadAll_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;

            // Open the file for reading
            inputFile = File.OpenText("data.txt");

            // Read all data from the file and store it in a string
            string data = inputFile.ReadToEnd();

            result.Items.Clear();

            result.Items.Add(data);

            inputFile.Close();

            MessageBox.Show("Data Read Successfully!");
        }

        // DELETE FILE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check whether the file exists
            if (File.Exists("data.txt"))
            {
                File.Delete("data.txt");

                result.Items.Clear();

                MessageBox.Show("File Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("File Does Not Exist!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            result.Items.Clear();

            MessageBox.Show("List Cleared Successfully!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}