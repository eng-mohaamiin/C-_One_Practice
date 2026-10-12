# LoanApp – C# Windows Forms

## Introduction

LoanApp is a simple loan qualification application developed using C# and Windows Forms. It determines whether a user qualifies for a loan based on salary and years of work experience.

## Screenshots and Explanations

### 1. Application Introduction

![Application Introduction](./ScreenShots/introduction.png)

**Description:**

This screenshot introduces the LoanApp application interface. It shows the main form where users can enter their salary and years of work experience to check their loan qualification.

### 2. Background Color and Result

![Background and Result](./ScreenShots/bgResult.png)

**Description:**

This screenshot demonstrates the application's background color and result display. After checking the user's information, the application displays a message indicating whether the user meets the loan requirements.

### 3. Tab Order

![Tab Order](./ScreenShots/TabOrder.png)

**Description:**

This screenshot demonstrates how the `TabIndex` property is used to control the order in which controls receive keyboard focus. Users can press the Tab key to move between input fields and buttons without using a mouse.

### 4. Background Color and Input Validation

![Background and Validation](./ScreenShots/BgValidtion.png)

**Description:**

This screenshot demonstrates the application's button color customization and input validation. The application checks the entered values and displays an appropriate message when the salary or work experience does not meet the required conditions.

### 5. Change Background Color Code

![Change Background Color Code](./ScreenShots/codeChangeBg.png)

**Description:**

This screenshot shows the C# code responsible for changing the button colors. The `BackColor` property sets the background color, while the `ForeColor` property changes the text color of the buttons.

### 6. Try-Catch and Input Validation Code

![Try Catch and Validation Code](./ScreenShots/codeTryCatch.png)

**Description:**

This screenshot shows the code used for numeric input validation and exception handling. The `double.TryParse()` method checks whether the entered values can be converted into numbers, while the `try-catch` block handles unexpected exceptions.

## Features

* **Loan Qualification:** Determines whether a user meets the loan requirements.
* **Salary Validation:** Requires a salary of at least 200.
* **Experience Validation:** Requires at least 2 years of work experience.
* **Input Validation:** Uses `double.TryParse()` to validate numeric input.
* **Exception Handling:** Uses `try-catch` to handle unexpected errors.
* **Button Color Customization:** Changes button background and text colors.
* **Keyboard Navigation:** Uses `TabIndex` to organize the order of controls.
* **Exit Functionality:** Closes the application using the Exit button.

## Loan Qualification Requirements

| Requirement             | Condition                |
| ----------------------- | ------------------------ |
| Minimum Salary          | 200                      |
| Minimum Work Experience | 2 years                  |
| Salary and Experience   | Must be positive numbers |

A user qualifies for a loan when the salary is at least 200 and work experience is at least 2 years.

## Technologies Used

* C#
* .NET Windows Forms
* Visual Studio

## How to Run the Application

1. Clone or download the repository.
2. Open the solution file (`.sln`) in Visual Studio.
3. Build the project.
4. Press `F5` to run the application.
5. Enter the salary and years of work experience.
6. Click the qualification button to view the result.

## Learning Objectives

This project demonstrates the use of:

* Variables and constants
* Conditional statements (`if-else`)
* Numeric input validation
* Exception handling (`try-catch`)
* Windows Forms event handling
* Control properties and colors
* Keyboard navigation using `TabIndex`

## Author

**Mohamed Amin**
