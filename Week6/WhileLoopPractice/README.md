# C# While Loop Practice

## Overview

This project demonstrates how to use a `while` loop in C# Windows Forms to display numbers in a ListBox. It also demonstrates how to clear the input and output and how to exit or close the application.

## 1. While Loop Code

![While Loop Code](./ScreenShots/Image%20Codoe%20While%20Loop.png)

The first image shows the C# code used to implement a `while` loop.

The program takes a number from the user through a TextBox and displays numbers from 1 up to the entered number in a ListBox.

### Code Explanation

- `Convert.ToInt32(textBox1.Text)`: Converts the user's input from text into an integer.
- `int i = 1`: Initializes the counter at 1.
- `while (i <= number)`: Repeats the loop while the counter is less than or equal to the user's number.
- `result.Items.Add(i)`: Adds the current number to the ListBox.
- `i++`: Increases the counter by 1 during each iteration.

For example, if the user enters `5`, the ListBox displays the numbers from 1 to 5.

## 2. Clear and Exit Code

![Clear and Exit Code](./ScreenShots/Code%20Clear%20And%20Exits.png)

The second image shows the code used to clear the input and output and to exit the application.

### Clear Button

The Clear button removes the entered number from the TextBox and clears all items from the ListBox.

```csharp
private void btnCleaer_Click(object sender, EventArgs e)
{
    textBox1.Clear();
    result.Items.Clear();
}
```

- `textBox1.Clear()`: Clears the input TextBox.
- `result.Items.Clear()`: Removes all displayed numbers from the ListBox.

### Exit Button

The Exit button closes the application when the user clicks it.

```csharp
private void btnExit_Click(object sender, EventArgs e)
{
    Application.Exit();
}
```

- `Application.Exit()`: Closes the running application.

## 3. User Interface Result

![While Loop Result](./ScreenShots/Image%20Result%20Ui.png)

The third image shows the application's user interface after running the program.

The user enters a number into the TextBox and clicks the appropriate button to display the counting sequence in the ListBox.

For example, entering `5` displays:

```text
1
2
3
4
5
```

The Clear button removes the input and displayed results, while the Exit button closes the application.

## What I Learned

- How to use a `while` loop in C#.
- How to get user input from a TextBox.
- How to convert text into an integer.
- How to display numbers in a ListBox.
- How to clear a TextBox and ListBox.
- How to close a Windows Forms application.

## Technologies Used

- C#
- Windows Forms
- Visual Studio

## Conclusion

This assignment helped me understand how a `while` loop works in C# Windows Forms. It also helped me practice user input, displaying results, clearing data, and exiting an application.

## Author

**Mohamed Amiin**