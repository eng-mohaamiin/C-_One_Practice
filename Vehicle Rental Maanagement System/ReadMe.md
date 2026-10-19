# Vehicle Rental Management System

A desktop application developed using **C# and Windows Forms** to manage vehicle rental bookings. The system validates customer information, checks rental eligibility, calculates rental charges, applies discounts, and displays the final rental cost.

## Features

- Customer name validation
- Customer age validation (18–80 years)
- Rental duration validation (1–30 days)
- Driving experience validation
- Customer rental eligibility checks
- Vehicle type selection (Economy, SUV, and Luxury)
- Daily rental rate calculation using `switch`
- Rental discounts based on the number of days
- Optional insurance calculation
- Young driver surcharge calculation
- Final rental cost calculation
- Clear button to reset all fields
- Exit button to close the application
- Rental information and approval status display

## Technologies Used

- C#
- .NET Windows Forms
- Visual Studio

## Application Screenshots

### 1. Rental Results

Displays the customer's rental information, vehicle details, daily rate, discount, insurance cost, surcharge, and final rental cost.

![Full Image Result](./ScreenShots/full%20Image%20Result%20.png)

### 2. Main Application Design

The main user interface for entering customer information, selecting a vehicle, choosing insurance, and calculating the rental cost.

![Vehicle Rental Management Design](./ScreenShots/fullDesign%20rental%20mangaments.png)

### 3. Input Validation Code

Shows the validation logic used to check customer details, numeric inputs, age limits, driving experience, and rental eligibility.

![Input Validation Code](./ScreenShots/image%20code%20all%20controlers%20validtion.png)

### 4. Daily Rate Calculation Using Switch

Demonstrates how the `switch` statement assigns a daily rental rate according to the selected vehicle type.

![Daily Rate Using Switch](./ScreenShots/image%20code%20daily%20rate%20using%20switch.png)

## Vehicle Types and Daily Rates

| Vehicle Type | Daily Rate |
|---|---:|
| Economy | $35.00 |
| SUV | $60.00 |
| Luxury | $100.00 |

## Rental Rules

### Customer Eligibility

- Customer age must be between 18 and 80.
- Customers must be at least 21 years old to rent a vehicle.
- Customers must have at least one year of driving experience.
- Luxury vehicles require a minimum age of 25 and at least three years of driving experience.

### Discounts

| Rental Duration | Discount |
|---|---:|
| 1–6 days | 0% |
| 7–13 days | 5% |
| 14–30 days | 10% |

### Additional Charges

- **Insurance:** $15 per rental day when selected.
- **Young driver surcharge:** 10% of the basic rental cost for customers aged 21–24.

## Calculation Logic

The system calculates the rental cost using the following formulas:

**Basic Rental Cost**

`Daily Rate × Rental Days`

**Discount**

`Basic Rental Cost × Discount Rate`

**Insurance Cost**

`$15 × Rental Days` (if insurance is selected)

**Young Driver Surcharge**

`Basic Rental Cost × 10%` (if the customer is aged 21–24)

**Final Rental Cost**

`Basic Rental Cost − Discount + Insurance Cost + Surcharge`

## How to Run the Project

1. Clone or download this repository.
2. Open the project in Visual Studio.
3. Open the solution file (`.sln`).
4. Build the solution.
5. Run the application.

## Author

**Mohamed Amin**

