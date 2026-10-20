# ✈️ Airline Ticket Booking System

## 📌 Project Overview

The **Airline Ticket Booking System** is a Windows Forms application developed using C#. It allows users to enter passenger information, select a travel class, calculate ticket costs, apply discounts, and determine the final booking amount.

The application also validates user inputs to ensure that bookings follow the specified rules.


## 🛠️ Technologies Used

- **Programming Language:** C#
- **Framework:** .NET Windows Forms
- **IDE:** Microsoft Visual Studio
- **Application Type:** Desktop Application

## ✨ Features

- Passenger information entry
- Input validation using `TryParse()`
- Passenger age validation (1–100 years)
- Ticket quantity validation (1–5 tickets)
- Baggage weight validation (0–50 kg)
- Three travel classes:
  - First Class
  - Normal Class
  - Business Class
- Ticket discounts based on the number of tickets
- Age-based discounts for children and senior passengers
- Optional travel insurance
- Booking rejection messages
- Booking cost calculation and result display
- Clear and Exit buttons

## 📋 Booking Validation Rules

| Input | Validation Rule |
|---|---|
| Passenger Name | Cannot be empty |
| Passenger Age | Must be between 1 and 100 |
| Number of Tickets | Must be between 1 and 5 |
| Baggage Weight | Must be between 0 and 50 kg |
| Travel Class | A class must be selected |
| First Class | Not allowed for passengers under 12 |

The application uses `int.TryParse()` to validate passenger age and ticket quantity, and `double.TryParse()` to validate baggage weight.

## 💰 Ticket Prices

| Travel Class | Price per Ticket |
|---|---:|
| First Class | $500 |
| Normal Class | $300 |
| Business Class | $700 |

## 🎯 Discount and Additional Charges

| Rule | Calculation |
|---|---|
| 1–2 tickets | No ticket discount |
| 3–4 tickets | 5% ticket discount |
| 5 tickets | 10% ticket discount |
| Passenger below 12 | 20% age discount |
| Passenger aged 60 or above | 10% age discount |
| Travel insurance | $25 per ticket |
| Baggage up to 20 kg | Free |

Ticket discounts are calculated first, followed by the age discount. Travel insurance is then added to determine the final amount payable.

**Note:** The assignment does not specify the additional baggage fee for weights above 20 kg. The application therefore displays a message indicating that the extra fee has not been specified.

## 🖼️ Screenshots

### 1. Input Validation

This section demonstrates how the application validates the passenger's input information.

![Input Validation Code](./ScreenShohts/Code%20All%20inputs%20validations.png)

### 2. Calculate Button

The Calculate button checks the entered information before processing the booking.

![Calculate Code](./ScreenShohts/Code%20Calculate.png)

### 3. Discount Calculation

This section demonstrates how ticket discounts and age-based discounts are calculated.

![Discount Calculation](./ScreenShohts/Code%20Discount.png)

### 4. Display Booking Results

The application displays passenger details, ticket charges, discounts, insurance costs, baggage status, and the total amount payable.

![Display Result Code](./ScreenShohts/Code%20display%20result.png)

### 5. Selected Travel Class and Ticket Charges

This section shows how the application identifies the selected travel class and calculates the ticket charges.

![Travel Class and Ticket Charges](./ScreenShohts/Find%20Price%20selected%20Class%20and%20worout%20ticket%20charge.png)

### 6. Reset Form

The Clear button resets the input fields, travel class selections, insurance checkbox, and displayed results.

![Reset Code](./ScreenShohts/Reset%20Code.png)

### 7. Completed Application Interface

The completed interface provides a form for entering booking information and viewing the calculated results.

![Completed Result UI](./ScreenShohts/Result%20UI%20completed%20.png)

## ▶️ How to Run the Project

1. Clone or download the project repository.
2. Open the solution file (`.sln`) in Microsoft Visual Studio.
3. Ensure that the required .NET Windows Forms components are installed.
4. Build the project.
5. Run the application.
6. Enter the passenger information and select a travel class.
7. Click **Calculate** to validate the information and calculate the booking cost.
8. Click **Clear** to reset the form.
9. Click **Exit** to close the application.

## 🧪 Example Calculation

Suppose a passenger has the following information:

- Passenger age: 65
- Travel class: Normal Class
- Number of tickets: 3
- Baggage weight: 15 kg
- Travel insurance: Selected

| Calculation | Amount |
|---|---:|
| Basic ticket cost ($300 × 3) | $900.00 |
| Ticket discount (5%) | −$45.00 |
| Cost after ticket discount | $855.00 |
| Senior discount (10%) | −$85.50 |
| Cost after age discount | $769.50 |
| Travel insurance ($25 × 3) | +$75.00 |
| **Total amount payable** | **$844.50** |

## 📚 Learning Objectives

This project demonstrates the use of:

- Variables and data types
- `if`, `else if`, and `else` statements
- Logical operators
- `TryParse()` for input validation
- Boolean variables and conditional logic
- Mathematical calculations
- Radio buttons and checkboxes
- Message boxes
- Windows Forms controls and event handlers

## 👨‍💻 Author

**Mohamed Amiin**

## 📄 License

This project was developed for educational and assignment purposes.






