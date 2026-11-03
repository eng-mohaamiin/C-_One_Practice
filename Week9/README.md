# C# Windows Forms – OpenFileDialog

## Project Overview

This project demonstrates how to open and read a text file in a C# Windows Forms application using `OpenFileDialog` and `StreamReader`.

The application allows users to:
- Open a file using the Open File Dialog.
- Select a file from their computer.
- Read the selected file line by line.
- Display the file contents inside a ListBox.
- Handle the Cancel button.

## Concepts Covered

### 1. StreamReader

`StreamReader` is a C# class used to read text from files.

In this project, it is used to open the selected file and read its contents.

```csharp
StreamReader Reads;
```

### 2. DialogResult

`DialogResult` stores the result of a dialog box interaction.

In this project, it checks whether the user selected OK or Cancel.

```csharp
DialogResult Results;
```

### 3. OpenFileDialog

`OpenFileDialog` displays a file selection window that allows users to browse and select a file from their computer.

```csharp
OpenFileDialog openFile = new OpenFileDialog();
Results = openFile.ShowDialog();
```

### 4. DialogResult.OK

`DialogResult.OK` checks whether the user selected a file and clicked the OK button.

```csharp
if (Results == DialogResult.OK)
{
    // Open and read the selected file
}
```

### 5. DialogResult.Cancel

`DialogResult.Cancel` checks whether the user clicked the Cancel button.

```csharp
else if (Results == DialogResult.Cancel)
{
    MessageBox.Show("Waa la kansalay");
}
```

### 6. File.OpenText()

`File.OpenText()` opens the selected text file for reading and returns a StreamReader object.

```csharp
Reads = File.OpenText(openFile.FileName);
```

### 7. EndOfStream

`EndOfStream` checks whether the StreamReader has reached the end of the file.

It is useful when reading a file line by line using a while loop.

### 8. ReadLine()

`ReadLine()` reads one line of text from the file at a time.

```csharp
string lines;

while (Reads.EndOfStream == false)
{
    lines = Reads.ReadLine();
    ResultListBox.Items.Add(lines);
}
```

### 9. ListBox Items.Add()

`Items.Add()` adds the information read from the file into the ListBox.

### 10. ListBox Items.Clear()

`Items.Clear()` removes all items from the ListBox.

```csharp
ResultListBox.Items.Clear();
```

### 11. Close()

`Close()` closes the StreamReader after finishing reading the file and releases the file resources.

```csharp
Reads.Close();
```

---

## Screenshots and Explanations

### 1. Declaring StreamReader, DialogResult, and Opening a File Dialog

![Declaring StreamReader, DialogResult, and Opening a File Dialog](./ScreenShots/Image%20Declaring%20StreamReader,%20DialogResult,%20and%20Opening%20a%20File%20Dialog.png)

**Explanation:**

This screenshot shows the declaration of the `StreamReader` and `DialogResult` variables and the creation of an `OpenFileDialog` object.

**Key Concepts:**
- `StreamReader`: Used to read text files.
- `DialogResult`: Stores the user's dialog selection.
- `OpenFileDialog`: Allows users to select a file.
- `ShowDialog()`: Displays the file selection window.

### 2. Open File Dialog Result

![Open File Dialog Result](./ScreenShots/image%20result%20Open%20Dialog.png)

**Explanation:**

This screenshot shows the Open File Dialog window displayed to the user.

The user can browse their computer, select a file, and click Open to continue.

**Key Concept:**

`ShowDialog()` displays the dialog window and waits for the user's selection.

### 3. Checking File Selection

![Checking File Selection](./ScreenShots/image%20code%20Checking%20file%20Selection.png)

**Explanation:**

This screenshot shows how the application checks the user's selection using `DialogResult.OK`.

When the user clicks OK, the application opens the selected file using `File.OpenText()`.

It then reads the file line by line using a `while` loop and `ReadLine()`.

**Key Concepts:**
- `DialogResult.OK`
- `File.OpenText()`
- `EndOfStream`
- `ReadLine()`
- `while` loop
- `ListBox.Items.Add()`

### 4. Displaying File Contents in the ListBox

![Displaying File Contents](./ScreenShots/image%20display%20result%20Full.png)

**Explanation:**

This screenshot demonstrates the result of reading a selected text file.

The application reads each line from the file and displays it as an item inside the ListBox.

**Key Concept:**

`ResultListBox.Items.Add(lines)` adds each line of text to the ListBox.

### 5. Checking the Cancel Selection in Code

![Checking Cancel Selection](./ScreenShots/image%20code%20checking%20cancel.png)

**Explanation:**

This screenshot shows how the application handles the Cancel selection.

When the user clicks Cancel instead of selecting a file, the application checks `DialogResult.Cancel` and displays a message using `MessageBox.Show()`.

**Key Concepts:**
- `else if`
- `DialogResult.Cancel`
- `MessageBox.Show()`

### 6. Result When the User Clicks Cancel

![Result When User Clicks Cancel](./ScreenShots/image%20result%20when%20user%20clicked%20cance.png)

**Explanation:**

This screenshot shows the message displayed when the user cancels the file selection.

The message informs the user that the operation has been cancelled.

**Key Concept:**

`MessageBox.Show()` displays a message box to communicate information to the user.

---

## How the Application Works

The application follows these steps:

1. The user clicks the Open button.
2. The Open File Dialog appears.
3. The user selects a file and clicks Open or Cancel.
4. If the user clicks Open, the application reads the selected file.
5. The file is read line by line using `StreamReader`.
6. Each line is displayed inside the ListBox.
7. If the user clicks Cancel, a cancellation message appears.
8. The Clear button removes all items from the ListBox.

## Conclusion

This project helped me understand how to work with text files in C# Windows Forms.

I learned how to use `OpenFileDialog`, `DialogResult`, `StreamReader`, `File.OpenText()`, `ReadLine()`, `EndOfStream`, and `ListBox`.

It also improved my understanding of file handling, conditional statements, while loops, and basic Windows Forms controls.

**Author:** Mohamed Amiin 