
namespace RegistrationFeesSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare variables
            string studentName = inputName.Text.Trim();
            string studentId = textId.Text.Trim();

            int studyLevel;
            int numberOfCourses;
            double transportFee;

            double feePerCourse = 0;
            double tuitionFee;
            double discountAmount = 0;
            double finalAmount;

            // Validate student name
            if (studentName == "")
            {
                MessageBox.Show("Please enter the student name.");
                inputName.Focus();
                return;
            }

            // Validate student ID
            if (studentId == "")
            {
                MessageBox.Show("Please enter the student ID.");
                textId.Focus();
                return;
            }

            // Validate study level
            if (!int.TryParse(textLevel.Text, out studyLevel))
            {
                MessageBox.Show("Please enter a valid study level.");
                textLevel.Focus();
                return;
            }

            // Validate number of courses
            if (!int.TryParse(textCourse.Text, out numberOfCourses))
            {
                MessageBox.Show("Please enter a valid number of courses.");
                textCourse.Focus();
                return;
            }

            if (numberOfCourses < 1 || numberOfCourses > 8)
            {
                MessageBox.Show("Number of courses must be between 1 and 8.");
                textCourse.Focus();
                return;
            }

            // Validate transport fee
            if (!double.TryParse(textBoxTransportFee.Text, out transportFee)
                || transportFee < 0)
            {
                MessageBox.Show("Please enter a valid transport fee.");
                textBoxTransportFee.Focus();
                return;
            }

            // Calculate fee per course according to study level
            if (studyLevel == 1)
            {
                feePerCourse = 40;
            }
            else if (studyLevel == 2)
            {
                feePerCourse = 45;
            }
            else if (studyLevel == 3)
            {
                feePerCourse = 50;
            }
            else if (studyLevel == 4)
            {
                feePerCourse = 55;
            }
            else
            {
                MessageBox.Show(
                    "Study Level must be Year 1, Year 2, Year 3, or Year 4."
                );

                textLevel.Focus();
                return;
            }

            // Calculate tuition fee
            tuitionFee = feePerCourse * numberOfCourses;

            // Apply 10% discount for 6 or more courses
            if (numberOfCourses >= 6)
            {
                discountAmount = tuitionFee * 0.10;
            }

            // Calculate final registration amount
            finalAmount = tuitionFee + transportFee - discountAmount;

            // Display results
            resultName.Text = "Name: " + studentName;
            resultId.Text = "ID: " + studentId;

            resultNumberOfCourse.Text =
                "Number of Courses: " + numberOfCourses;

            resultStudy.Text = "Study Year: " + studyLevel;

            resultTuitionFee.Text =
                "Tuition Fee: " + tuitionFee.ToString("C2");

            resultTranportFee.Text =
                "Transport Fee: " + transportFee.ToString("C2");

            resultDiscount.Text =
                "Discount: " + discountAmount.ToString("C2");

            resultFinalAmount.Text =
                "Final Amount: " + finalAmount.ToString("C2");

            MessageBox.Show(
                "Registration completed successfully!",
                "Success"
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all input TextBoxes
            inputName.Clear();
            textId.Clear();
            textCourse.Clear();
            textLevel.Clear();
            textBoxTransportFee.Clear();

            // Clear all result Labels
            resultName.Text = "";
            resultId.Text = "";
            resultNumberOfCourse.Text = "";
            resultStudy.Text = "";
            resultTuitionFee.Text = "";
            resultTranportFee.Text = "";
            resultDiscount.Text = "";
            resultFinalAmount.Text = "";

            // Return focus to Student Name
            inputName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
