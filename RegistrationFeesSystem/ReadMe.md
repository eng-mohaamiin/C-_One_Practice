# 🎓 Registration Fees System

## 📌 Project Overview

The **Registration Fees System** is a C# Windows Forms application designed to calculate student registration fees based on study level, number of courses, and transport fees.

The system validates student information, calculates tuition fees, applies discounts for students taking six or more courses, and displays the final registration amount.

## 🛠️ Technologies Used

- **Programming Language:** C#
- **Framework:** .NET Windows Forms
- **IDE:** Visual Studio
- **Application Type:** Desktop Application

## ✨ Features

- Student name and ID input.
- Study level selection or entry (Year 1 to Year 4).
- Course quantity validation (1–8 courses).
- Transport fee input and validation.
- Automatic tuition fee calculation.
- 10% tuition discount for students taking six or more courses.
- Display of student information and fee results.
- Clear button to reset inputs and results.
- Exit button to close the application.

## 📸 Project Screenshots

### 1. Code Implementation

The following screenshots demonstrate the C# code used to validate inputs, calculate registration fees, and display results.

#### Input Validation Code

This section validates the student name, student ID, study level, number of courses, and transport fee. It prevents invalid input from being processed.

![Input Validation Code](./ScreenShots/image%20code%20all%20inputs%20validation.png)

#### Fee Calculation Code

This section calculates tuition fees according to the student's study level and number of courses. It also applies a 10% discount when the student registers for six or more courses.

![Fee Calculation Code](./ScreenShots/image%20code%20calculateion.png)

#### Display Results Code

This section displays the student's information, tuition fee, transport fee, discount, and final registration amount on the form.

![Display Results Code](./ScreenShots/Image%20code%20display%20result.png)

### 2. User Interface Design

The following screenshot shows the application's user interface, including the input fields and controls used to enter student information.

#### Registration Form Interface

This screenshot presents the registration form where users enter student details, study level, number of courses, and transport fees.

![Registration Form UI](./ScreenShots/image%20result%20ui.png)

#### Complete Application Design

This screenshot shows the overall design of the Registration Fees System, including its layout, input fields, buttons, and result display areas.

![Complete UI Design](./ScreenShots/Image%20ui%20all%20design%20.png)

## 🧮 Fee Calculation Rules

The tuition fee per course depends on the student's study level:

| Study Level | Fee Per Course |
|---|---:|
| Year 1 | $40 |
| Year 2 | $45 |
| Year 3 | $50 |
| Year 4 | $55 |

### Discount Rule

Students registering for six or more courses receive a 10% discount on their tuition fee.

**Formulas:**

- Tuition Fee = Fee Per Course × Number of Courses
- Discount = 10% of Tuition Fee (if courses ≥ 6)
- Final Amount = Tuition Fee + Transport Fee − Discount

## ✅ Input Validation Rules

- Student name must not be empty.
- Student ID must not be empty.
- Study level must be between Year 1 and Year 4.
- Number of courses must be between 1 and 8.
- Transport fee must be a valid non-negative number.

## 🚀 How to Run the Project

1. Clone or download this repository.
2. Open the project in Visual Studio.
3. Open the solution (`.sln`) file.
4. Build the project.
5. Run the application.
6. Enter the student information and click **Calculate** to view the registration fee.

## 👨‍💻 Project Purpose

This project demonstrates the use of C# Windows Forms, input validation, conditional statements, mathematical calculations, event handling, and user interface design in a student registration application.
