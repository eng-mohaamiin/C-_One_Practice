# C# File Handling


## Project Description

This project is a simple C# Windows Forms application that demonstrates basic file handling operations using the `System.IO` namespace.

The application allows users to create, write, append, read, and delete text files. It also provides options to clear the ListBox and exit the application.

## Application Features

1. **Create File:** Creates a new text file named `data.txt`.
2. **Write File:** Writes text data into the file.
3. **Append File:** Adds new data to the end of the existing file.
4. **Read File:** Reads the file character by character and displays the characters in a ListBox.
5. **Read All File:** Reads all the contents of the file and displays them in the ListBox.
6. **Delete File:** Checks whether the file exists and deletes it.
7. **Clear List:** Clears all items from the ListBox.
8. **Exit:** Closes the application.

## Screenshots

### 1. Create File Code
Shows how `File.CreateText()` is used to create a new text file named `data.txt`.

![Create File Code](./ScreenShots/image%20code%20Create%20File.png)

### 2. Write File Code
Shows how `File.AppendText()` and `WriteLine()` are used to write text data into the file.

![Write File Code](./ScreenShots/image%20code%20write%20file.png)

### 3. Append File Code
Shows how `File.AppendText()` and `WriteLine()` are used to add new data to the end of the existing file.

![Append File Code](./ScreenShots/image%20code%20append%20file.png)

### 4. Read File Code
Shows how `StreamReader`, `File.OpenText()`, and `Read()` are used to read the file character by character.

![Read File Code](./ScreenShots/image%20code%20read%20file.png)

### 5. Read All File Code
Shows how `StreamReader` and `ReadToEnd()` are used to read all the contents of the text file.

![Read All File Code](./ScreenShots/image%20%20code%20read%20all%20files.png)

### 6. Delete File Code
Shows how `File.Exists()` checks whether the file exists and `File.Delete()` deletes it.

![Delete File Code](./ScreenShots/image%20%20code%20delete%20files.png)

### 7. Clear List Code
Shows how `result.Items.Clear()` is used to remove all items from the ListBox.

![Clear List Code](./ScreenShots/image%20code%20clear%20.png)

### 8. Exit Code
Shows how `this.Close()` is used to close the Windows Form application.

![Exit Code](./ScreenShots/image%20code%20exit%20.png)

### 9. Read File – User Interface Result
Shows the application interface after reading the file character by character and displaying the characters in the ListBox.

![Read File Result](./ScreenShots/image%20user%20interface%20result%20read%20files.png)

### 10. Read All File – User Interface Result
Shows the application interface after reading all the contents of the text file and displaying them in the ListBox.

![Read All Result](./ScreenShots/image%20result%20user%20interrface%20read%20all%20files.png)

## Conclusion

This project demonstrates the basic concepts of file handling in C# Windows Forms, including creating, writing, appending, reading, and deleting text files.


**Author:** Mohamed Amiin
