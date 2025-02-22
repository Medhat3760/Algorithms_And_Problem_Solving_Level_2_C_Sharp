# Inverted Letter Pattern in C#

## Overview
This C# program prints an inverted letter pattern based on a user-provided positive number. The letters are printed in descending order, starting from the ASCII character corresponding to the user's input.

## Code Explanation

### **Namespace and Class**
- The program is defined in the `Problem14` namespace.
- The main logic is implemented in the `Problem14` class.

### **Reading a Positive Number**
- The `ReadPositiveNumbers` method prompts the user to enter a positive integer.
- It ensures the number is greater than zero by using a `do-while` loop.

### **Printing the Inverted Letter Pattern**
- The `PrintInvertedLetterPattern` method generates the pattern based on the input number.
- The ASCII value of 'A' is `65`, and the starting character is determined using `65 + Number - 1`.
- The outer loop iterates from the highest character down to 'A'.
- The inner loop prints each character multiple times, decreasing in count per row.

### **Main Method Execution**
- The `Main` method calls `ReadPositiveNumbers` to get user input.
- It passes the input to `PrintInvertedLetterPattern`, which prints the pattern.

## Example Output
If the user enters `5`, the output will be:
```
EEEEE
DDDD
CCC
BB
A
```
### Explanation:
- The first row prints 'E' five times.
- The second row prints 'D' four times.
- The pattern continues until 'A' is printed once.

## Key Features
- Uses loops for pattern generation.
- Implements input validation.
- Demonstrates ASCII character manipulation in C#.

## Usage
1. Compile and run the program.
2. Enter a positive integer when prompted.
3. Observe the generated inverted letter pattern.

