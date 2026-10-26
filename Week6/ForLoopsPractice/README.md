# C# For Loop Practice

## Overview
This project demonstrates how to use a `for` loop in C# Windows Forms to display the message **"I Love Allah"** ten times in a ListBox.

## 1. For Loop Code

![For Loop Code](./ScreenShots/code%20for%20%20loop.png)

The first image shows the C# code used to repeat a message using a `for` loop.

```csharp
for (int i = 1; i <= 10; i++)
{
    result.Items.Add("I Love Allah");
}
```

### Code Explanation

- `int i = 1`: Initializes the counter at 1.
- `i <= 10`: Continues the loop while the counter is less than or equal to 10.
- `i++`: Increases the counter by 1 after each iteration.
- `result.Items.Add("I Love Allah")`: Adds the message to the ListBox during each iteration.

As a result, the message **"I Love Allah"** is added to the ListBox ten times.

## 2. User Interface Result

![For Loop Result](./ScreenShots/result%20UI%20For%20loop.png)

The second image shows the application's user interface after running the program.

The ListBox displays **"I Love Allah"** ten times, demonstrating that the `for` loop works correctly.

## What I Learned

- How to use a `for` loop in C#.
- How to repeat a statement ten times.
- How to display output in a Windows Forms ListBox.
- How to connect C# code with a graphical user interface.

## Technologies Used

- C#
- Windows Forms
- Visual Studio

## Conclusion

This practice helped me understand how a `for` loop works in C# and how to use it to display repeated messages in a Windows Forms application.

## Author

**Mohamed Amiin**