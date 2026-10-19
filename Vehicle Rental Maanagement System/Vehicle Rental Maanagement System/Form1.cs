
namespace Vehicle_Rental_Maanagement_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Validate Customer Name
            string customerName = textName.Text.Trim();

            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Please enter customer name.");
                textName.Focus();
                return;
            }

            // 2. Validate numeric inputs using TryParse
            int age;
            int days;
            int experience;

            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid customer age.");
                txtAge.Focus();
                return;
            }

            if (!int.TryParse(txtDays.Text, out days))
            {
                MessageBox.Show("Please enter valid rental days.");
                txtDays.Focus();
                return;
            }

            if (!int.TryParse(txtExperience.Text, out experience))
            {
                MessageBox.Show("Please enter valid driving experience.");
                txtExperience.Focus();
                return;
            }

            // 3. Validate age range
            if (age < 18 || age > 80)
            {
                MessageBox.Show("Customer age must be between 18 and 80.");
                return;
            }

            // 4. Validate rental days
            if (days < 1 || days > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30.");
                return;
            }

            // 5. Validate driving experience
            if (experience < 0)
            {
                MessageBox.Show("Driving experience cannot be negative.");
                return;
            }

            // 6. Check customer eligibility
            if (age < 21)
            {
                MessageBox.Show(
                    "Customer is not eligible. Minimum age is 21.");
                return;
            }

            if (experience < 1)
            {
                MessageBox.Show(
                    "Customer must have at least 1 year of driving experience.");
                return;
            }

            // 7. Get vehicle type and daily rate using switch
            string vehicleType;
            decimal dailyRate;

            if (radioBtnEconomy.Checked)
            {
                vehicleType = "Economy";
            }
            else if (radioBtnSuv.Checked)
            {
                vehicleType = "SUV";
            }
            else if (radioBtnLuxury.Checked)
            {
                vehicleType = "Luxury";
            }
            else
            {
                MessageBox.Show("Please select a vehicle type.");
                return;
            }

            switch (vehicleType)
            {
                case "Economy":
                    dailyRate = 35m;
                    break;

                case "SUV":
                    dailyRate = 60m;
                    break;

                case "Luxury":
                    dailyRate = 100m;
                    break;

                default:
                    MessageBox.Show("Invalid vehicle type.");
                    return;
            }

            // 8. Luxury vehicle requirements
            if (vehicleType == "Luxury" &&
                (age < 25 || experience < 3))
            {
                MessageBox.Show(
                    "Luxury requires age 25 or above and " +
                    "at least 3 years of driving experience.");
                return;
            }

            // 9. Calculate basic rental cost
            decimal basicCost = dailyRate * days;

            // 10. Calculate discount using rental days
            decimal discountRate = 0m;

            if (days >= 14)
            {
                discountRate = 0.10m;
            }
            else if (days >= 7)
            {
                discountRate = 0.05m;
            }

            decimal discount = basicCost * discountRate;

            // 11. Calculate insurance cost
            decimal insuranceCost = 0m;

            if (checkboxInsurance.Checked)
            {
                insuranceCost = 15m * days;
            }

            // 12. Calculate young driver surcharge
            decimal surcharge = 0m;

            if (age >= 21 && age <= 24)
            {
                surcharge = basicCost * 0.10m;
            }

            // 13. Calculate final rental cost
            decimal finalCost =
                basicCost - discount + insuranceCost + surcharge;

            // 14. Display results

            string rentalStatus = "Eligible - Rental Approved";

            result.Text =
                "Rental Information and Results\n\n" +
                "Rental Details\n" +
                "--------------------------------------------------\n\n" +
                "Customer Name          : " + customerName + "\n" +
                "Customer Age           : " + age + "\n" +
                "Driving Experience     : " + experience + " years\n" +
                "Vehicle Type           : " + vehicleType + "\n" +
                "Daily Rate             : $" + dailyRate.ToString("F2") + "\n" +
                "Rental Days            : " + days + "\n" +
                "Basic Rental Cost      : $" + basicCost.ToString("F2") + "\n" +
                "Discount               : $" + discount.ToString("F2") + "\n" +
                "Insurance Cost         : $" + insuranceCost.ToString("F2") + "\n" +
                "Young Driver Surcharge : $" + surcharge.ToString("F2") + "\n" +
                "Final Rental Cost      : $" + finalCost.ToString("F2") + "\n\n" +
                "--------------------------------------------------\n\n" +
                "Rental Status          : " + rentalStatus;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            textName.Clear();
            txtAge.Clear();
            txtDays.Clear();
            txtExperience.Clear();

            // Uncheck insurance checkbox
            checkboxInsurance.Checked = false;

            // Reset all vehicle radio buttons
            radioBtnEconomy.Checked = false;
            radioBtnSuv.Checked = false;
            radioBtnLuxury.Checked = false;

            // Clear results
            result.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
