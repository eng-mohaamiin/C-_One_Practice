# BMI Calculator

## About The Project

The **BMI Calculator** is a desktop application developed using C# and Windows Forms. It allows users to calculate their Body Mass Index (BMI) based on their weight and height.

The application validates user inputs, calculates BMI, and classifies the result into three categories: Underweight, Optimal Weight, and Overweight.

## Application Features

- **Weight Input:** Allows users to enter their body weight.
- **Height Input:** Allows users to enter their height.
- **Input Validation:** Uses `double.TryParse()` to ensure that inputs are valid numbers.
- **Positive Value Validation:** Ensures that weight and height are greater than zero.
- **BMI Calculation:** Calculates BMI using the standard mathematical formula.
- **BMI Classification:** Classifies BMI results into three categories.
- **Display Results:** Displays the BMI category and calculated BMI.
- **Exception Handling:** Uses `try-catch` to handle unexpected errors.

## BMI Calculation Formula

The application uses the following formula:

```text
BMI = Weight / (Height * Height)
```

**Note:** Weight should be entered in kilograms (kg), and height should be entered in meters (m).

## BMI Categories

The application classifies BMI results using the following conditions:

| BMI Value | Category |
|---|---|
| Below 18.5 | UnderWeight |
| 18.5 – 25 | Optimal Weight |
| Above 25 | OverWeight |

## Application Screenshots

### 1. Application User Interface

This screenshot shows the BMI Calculator application interface, where users can enter their weight and height, calculate their BMI, and view the resulting BMI category.

![BMI Calculator User Interface](./ScreenShots/image%20ui%20results.png)

### 2. Variable Assignment and Input Validation

This section demonstrates how variables are declared and initialized to store weight, height, BMI, and the result.

The application uses `double.TryParse()` to validate numeric inputs before performing calculations.

![Variable Assignment and Input Validation](./ScreenShots/image%20code%20assigning%20variable%20.png)

### 3. Nested If Statements and BMI Classification

This screenshot demonstrates the use of nested if-else statements to classify BMI results.

After calculating BMI, the application checks the BMI value and assigns the appropriate category: UnderWeight, Optimal Weight, or OverWeight.

![Nested If Statements](./ScreenShots/image%20code%20nested%20if%20.png)


## Author

**Mohamed Amiin**