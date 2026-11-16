# Employee Attendance Management System

## About The Project

The **Employee Attendance Management System** is a Windows Forms application developed using C#. This application allows users to manage employee attendance information by entering employee details, validating inputs, saving records to a text file, reading stored data, counting employees, and managing displayed records.



## Application Features

- **Input Validation:** Ensures that employee ID, name, department, and attendance status are valid before saving.
- **Save Employee Information:** Saves employee records into a text file using `File.AppendText()`.
- **Read Employee Records:** Reads saved employee information from the text file using `StreamReader`.
- **Count Employees:** Counts the total number of employee records stored in the file.
- **Remove Employee:** Removes a selected employee record from the ListBox.
- **Clear All Inputs:** Clears all text fields, radio buttons, and displayed ListBox items.
- **Exit Application:** Closes the application.

## Application Screenshots

### 1. User Interface Design

This screenshot shows the main interface of the Employee Attendance Management System. It contains input fields for Employee ID, Name, and Department, attendance options (Present and Absent), and buttons for managing employee records.

![Application User Interface](../ScreenShots/image%20ui%20results.png)

### 2. Input Validation

The application validates employee information before saving. It checks that the employee ID is a valid non-negative integer, the name and department are not empty, and an attendance option is selected.

![Input Validations](../ScreenShots/image%20code%20all%20inputs%20validations.png)

### 3. Create and Save Employee Records

After successful validation, employee information is saved into `D:\attendence.txt` using `File.AppendText()` and `StreamWriter`. New records are appended without deleting previously saved information.

![Create and Save File](../ScreenShots/image%20code%20create%20files%20.png)

The employee information is stored in the following format:

```text
ID,Name,Department,Attendance
```

Example:

```text
101,Mohamed,IT,Present
102,Ahmed,HR,Absent
```

### 4. Read Employee Records

The Read button uses `StreamReader` and `ReadLine()` inside a `while` loop to read employee records from the text file and display them in the ListBox.

![Reading File Data](../ScreenShots/image%20code%20reading%20file%20data.png)

### 5. Count Total Employees

The Count button reads the text file line by line and increments a counter for every record. Finally, it displays the total number of employee records in the ListBox.

![Counting Employees](../ScreenShots/image%20code%20counting.png)

### 6. Remove Employee

The Remove button checks whether an employee has been selected in the ListBox. If no employee is selected, it displays a validation message. Otherwise, it removes the selected item from the ListBox.

![Remove Employee](../ScreenShots/image%20code%20remove.png)

### 7. Clear All Inputs

The Clear button resets all input fields, unchecks the attendance radio buttons, and clears all displayed records from the ListBox.

![Clear All Inputs](../ScreenShots/image%20code%20all%20inputs%20clear%20values.png)

## Author

**Mohamed Amiin**