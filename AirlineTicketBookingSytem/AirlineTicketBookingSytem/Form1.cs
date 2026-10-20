
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_TWO_Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            bool bookingApproved = true;
            string rejectionReason = "";

            int Age = 0;
            int numberOfTickets = 0;
            double baggageWeight = 0;

            string passengerName = TxtName.Text.Trim();

            // Check the passenger information
            if (passengerName == "")
            {
                bookingApproved = false;
                rejectionReason = "Please enter the passenger's name.";
            }
            else if (!int.TryParse(txtPassengerAge.Text, out Age))
            {
                bookingApproved = false;
                rejectionReason = "Enter the passenger's age using numbers.";
            }
            else if (Age < 1 || Age > 100)
            {
                bookingApproved = false;
                rejectionReason = "Age must be from 1 to 100 years.";
            }
            else if (!int.TryParse(txtNumberOfTickets.Text, out numberOfTickets))
            {
                bookingApproved = false;
                rejectionReason = "Please enter a valid ticket quantity.";
            }
            else if (numberOfTickets < 1 || numberOfTickets > 5)
            {
                bookingApproved = false;
                rejectionReason = "You can book between 1 and 5 tickets.";
            }
            else if (!double.TryParse(txtBaggageWeight.Text, out baggageWeight))
            {
                bookingApproved = false;
                rejectionReason = "Enter the baggage weight in kilograms.";
            }
            else if (baggageWeight < 0 || baggageWeight > 50)
            {
                bookingApproved = false;
                rejectionReason = "Baggage weight must be between 0 and 50 kg.";
            }
            else if (!RdoFirstclass.Checked &&
                     !RdoNormalClass.Checked &&
                     !RdoBusinessClass.Checked)
            {
                bookingApproved = false;
                rejectionReason = "Choose a travel class before continuing.";
            }
            else if (Age < 12 && RdoFirstclass.Checked)
            {
                bookingApproved = false;
                rejectionReason = "First Class is not available for passengers under 12.";
            }

            // Stop if any booking requirement is not met
            if (!bookingApproved)
            {
                MessageBox.Show(
                    rejectionReason,
                    "Invalid Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Find the price of the selected class
            double ticketPrice;
            string travelClass;

            if (RdoFirstclass.Checked)
            {
                ticketPrice = 500;
                travelClass = "First Class";
            }
            else if (RdoNormalClass.Checked)
            {
                ticketPrice = 300;
                travelClass = "Normal Class";
            }
            else
            {
                ticketPrice = 700;
                travelClass = "Business Class";
            }

            // Work out the ticket charges
            double basicTicketCost = ticketPrice * numberOfTickets;

            double ticketDiscountRate = 0;

            if (numberOfTickets >= 3 && numberOfTickets <= 4)
            {
                ticketDiscountRate = 0.05;
            }
            else if (numberOfTickets == 5)
            {
                ticketDiscountRate = 0.10;
            }

            double ticketDiscount = basicTicketCost * ticketDiscountRate;
            double discountedCost = basicTicketCost - ticketDiscount;

            // Apply the discount according to the passenger's age
            double ageDiscountRate = 0;

            if (Age < 12)
            {
                ageDiscountRate = 0.20;
            }
            else if (Age >= 60)
            {
                ageDiscountRate = 0.10;
            }

            double ageDiscount = discountedCost * ageDiscountRate;
            double costAfterAgeDiscount = discountedCost - ageDiscount;

            // Add insurance when the option is selected
            double insuranceCost = 0;

            if (chkTravelInsurance.Checked)
            {
                insuranceCost = 25 * numberOfTickets;
            }

            // Determine whether the baggage is within the free allowance
            string baggageStatus;

            if (baggageWeight <= 20)
            {
                baggageStatus = "Within free allowance";
            }
            else
            {
                baggageStatus = "Exceeds 20 kg; additional fee not provided";
            }

            // Calculate the amount payable
            double totalCost = costAfterAgeDiscount + insuranceCost;

            // Show the latest booking information
            LstResult.Items.Clear();

            LstResult.Items.Add("FLIGHT BOOKING SUMMARY");
            LstResult.Items.Add("==============================");
            LstResult.Items.Add("Passenger: " + passengerName);
            LstResult.Items.Add("Age: " + Age + " years");
            LstResult.Items.Add("Tickets booked: " + numberOfTickets);
            LstResult.Items.Add("Baggage: " + baggageWeight.ToString("F2") + " kg");
            LstResult.Items.Add("Selected class: " + travelClass);

            LstResult.Items.Add("------------------------------");
            LstResult.Items.Add("Ticket subtotal: $" + basicTicketCost.ToString("F2"));
            LstResult.Items.Add("Group ticket savings: $" + ticketDiscount.ToString("F2"));
            LstResult.Items.Add("Price after ticket discount: $" + discountedCost.ToString("F2"));
            LstResult.Items.Add("Age-based savings: $" + ageDiscount.ToString("F2"));
            LstResult.Items.Add("Price after age discount: $" + costAfterAgeDiscount.ToString("F2"));
            LstResult.Items.Add("Insurance charge: $" + insuranceCost.ToString("F2"));
            LstResult.Items.Add("Baggage allowance: " + baggageStatus);

            LstResult.Items.Add("==============================");
            LstResult.Items.Add("AMOUNT TO PAY: $" + totalCost.ToString("F2"));

            MessageBox.Show(
                "Your booking has been calculated successfully.",
                "Booking Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Reset the form for another booking
            TxtName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();

            RdoFirstclass.Checked = false;
            RdoNormalClass.Checked = false;
            RdoBusinessClass.Checked = false;
            chkTravelInsurance.Checked = false;

            LstResult.Items.Clear();

            TxtName.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Ask before closing the application
            DialogResult answer = MessageBox.Show(
                "Do you want to close the flight booking application?",
                "Exit Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
