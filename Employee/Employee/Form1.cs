using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee
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

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String  name = txtName.Text.Trim(), department = txtDepartment.Text.Trim();

                int id;

               

                if(!int.TryParse(txtID.Text, out id))
                {
                    MessageBox.Show("please enter valid id");
                    return;
                }
                if (id < 0)
                {
                    MessageBox.Show("id can not negative");
                    return;
                }
            


                if (String.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Name  is required");
                    return;
                }
                if (String.IsNullOrWhiteSpace(department))
                {
                    MessageBox.Show("Department is required");
                    return;
                }

                // checking if the user is not selecct attenden

                if (!radioBtnAbsent.Checked && !radioBtnPresent.Checked)
                {
                    MessageBox.Show("Please selecct at least one");
                    return;
                }

                // store selected attendencce data 
                String type = "";

                if (radioBtnPresent.Checked)
                {
                    type = "Present";
                }
                else if (radioBtnAbsent.Checked)
                {
                    type = "Absent";
                }


                // start store files data

                String employeeInfo = $"{id},{name},{department},{type} ";

                // import streamwrite
                StreamWriter outpuFile;

                //outpuFile = File.AppendText("employeeAttendenceInfor.txt");
                outpuFile = File.AppendText("D:\\attendence.txt");

                // write the file
                outpuFile.WriteLine(employeeInfo);

                // close the file
                outpuFile.Close();
                MessageBox.Show("File creating successfully");
                listBox1.Items.Add(employeeInfo);
            }
            catch (Exception ex) {

                MessageBox.Show("something wrong");
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            String data;

            StreamReader inputFile;
            inputFile = File.OpenText("D:\\attendence.txt");
            //listBox1.Items.Add(data);

            // with loops 
            while ((data = inputFile.ReadLine()) != null)
            {
                listBox1.Items.Add(data);
            }
            inputFile.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCount_Click_1(object sender, EventArgs e)
        {
            // import streamreader
            StreamReader inputFile;

            // open the file
            inputFile = File.OpenText("D:\\attendence.txt");


            int count = 0;
            String data;

            // checking 
            while ((data = inputFile.ReadLine()) != null)
            {
                count++;
            }

            inputFile.Close();

            listBox1.Items.Add("Total Emplooyee " + count);
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee to remove");
                return;
            }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            MessageBox.Show("Employee removed successfully");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtDepartment.Clear();

            radioBtnPresent.Checked = false;
            radioBtnAbsent.Checked = false;

            listBox1.Items.Clear();

            MessageBox.Show("All fields cleared successfully");
        }
    }
}
