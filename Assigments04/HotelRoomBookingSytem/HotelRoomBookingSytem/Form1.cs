namespace HotelRoomBookingSytem
{
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
        }

        private void lblGuesNights_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. VARIABLES
            string guestName = inputGuestName.Text.Trim();

            int age;
            int nights;
            int numberGuests;

            // Bool flag
            bool approved = true;


            // 2. VALIDATE GUEST NAME

            if (String.IsNullOrEmpty(guestName))
            {
                MessageBox.Show("Please Enter Guest Name");
                approved = false;
            }


            // 3. VALIDATE AGE

            if (!int.TryParse(inputAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                approved = false;
            }
            else if (age < 18 || age > 90)
            {
                MessageBox.Show("Age must be between 18 and 90.");
                approved = false;
            }


            // 4. VALIDATE NIGHTS

            if (!int.TryParse(inputNight.Text, out nights))
            {
                MessageBox.Show("Please enter valid number of nights.");
                approved = false;
            }
            else if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be between 1 and 30.");
                approved = false;
            }


            // 5. VALIDATE NUMBER OF GUESTS

            if (!int.TryParse(inputGuestNumber.Text, out numberGuests))
            {
                MessageBox.Show("Please enter valid number of guests.");
                approved = false;
            }
            else if (numberGuests < 1 || numberGuests > 6)
            {
                MessageBox.Show("Guests must be between 1 and 6.");
                approved = false;
            }


            // 6. CHECK ROOM SELECTION

            if (!radioBtnStandard.Checked &&
                !radioBtnNormal.Checked &&
                !radioBtnHight.Checked)
            {
                MessageBox.Show("Please select a room.");
                approved = false;
            }


            if (!approved)
            {
                MessageBox.Show("Booking Rejected.");
                return;
            }


            // 7. GET ROOM TYPE

            string roomType = "";

            if (radioBtnStandard.Checked)
            {
                roomType = "Standard";
            }
            else if (radioBtnNormal.Checked)
            {
                roomType = "Normal";
            }
            else if (radioBtnHight.Checked)
            {
                roomType = "Hight";
            }


            // 8. CHECK ROOM CAPACITY

            if (roomType == "Standard" && numberGuests > 2)
            {
                MessageBox.Show(
                    "Standard room can accommodate a maximum of 2 guests."
                );

                approved = false;
            }
            else if (roomType == "Normal" && numberGuests > 4)
            {
                MessageBox.Show(
                    "Normal room can accommodate a maximum of 4 guests."
                );

                approved = false;
            }
            else if (roomType == "Hight" && numberGuests > 6)
            {
                MessageBox.Show(
                    "Hight room can accommodate a maximum of 6 guests."
                );

                approved = false;
            }


            // Haddii room capacity-ga khaldan yahay
            if (!approved)
            {
                MessageBox.Show("Booking Rejected.");
                return;
            }


            // 9. ROOM RATE USING SWITCH

            decimal roomRate = 0;

            switch (roomType)
            {
                case "Standard":
                    roomRate = 50;
                    break;

                case "Normal":
                    roomRate = 80;
                    break;

                case "Hight":
                    roomRate = 130;
                    break;
            }


            // 10. CALCULATE ROOM COST

            decimal roomCost = roomRate * nights;


            // 11. NIGHT DISCOUNT

            decimal nightDiscount = 0;

            if (nights >= 1 && nights <= 4)
            {
                // No discount
                nightDiscount = 0;
            }
            else if (nights >= 5 && nights <= 9)
            {
                // 5% discount
                nightDiscount = roomCost * 0.05m;
            }
            else if (nights >= 10)
            {
                // 12% discount
                nightDiscount = roomCost * 0.12m;
            }


            // Discount ka jar room cost
            decimal total = roomCost - nightDiscount;


            // 12. BREAKFAST

            decimal breakfastCost = 0;

            if (radioBtnBreakFast.Checked)
            {
                breakfastCost = 10 * numberGuests * nights;
                total = total + breakfastCost;
            }


            // 13. SERVICE SURCHARGE

            decimal serviceSurcharge = 0;

            if (numberGuests > 4)
            {
                serviceSurcharge = total * 0.05m;

                total = total + serviceSurcharge;
            }


            // 14. SENIOR DISCOUNT
            // 

            decimal seniorDiscount = 0;

            if (age >= 60)
            {
                seniorDiscount = total * 0.05m;

                total = total - seniorDiscount;
            }


            // 15. BOOKING APPROVED

            approved = true;

            // Clear inputs
            //inputGuestName.Clear();
            //inputAge.Clear();
            //inputNight.Clear();
            //inputGuestNumber.Clear();

            //// Clear RadioButtons
            //radioBtnStandard.Checked = false;
            //radioBtnNormal.Checked = false;
            //radioBtnHight.Checked = false;

            //// Clear CheckBox
            //radioBtnBreakFast.Checked = false;

            //// Clear result
            //textResult.Clear();

            // Focus on guest name
            inputGuestName.Focus();

            // 16. SHOW RESULT
            textResult.Text =
                "Booking Approved!\r\n\r\n" +
                "Guest Name: " + guestName + "\r\n" +
                "Age: " + age + "\r\n" +
                "Room: " + roomType + "\r\n" +
                "Guests: " + numberGuests + "\r\n" +
                "Nights: " + nights + "\r\n" +
                "Room Rate: $" + roomRate.ToString("0.00") + "\r\n" +
                "Night Discount: -$" + nightDiscount.ToString("0.00") + "\r\n" +
                "Breakfast: $" + breakfastCost.ToString("0.00") + "\r\n" +
                "Service Surcharge: $" + serviceSurcharge.ToString("0.00") + "\r\n" +
                "Senior Discount: -$" + seniorDiscount.ToString("0.00") + "\r\n\r\n" +
                "TOTAL: $" + total.ToString("0.00");

        }
    }
}