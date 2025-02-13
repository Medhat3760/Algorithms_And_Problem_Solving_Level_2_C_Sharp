# Inverted Number Pattern Program

## Overview
This C# program generates an **inverted number pattern** based on a user-provided positive integer. The pattern consists of repeated numbers in descending order.

## Program Explanation
The program is structured within the `Problem12` namespace and contains three main methods:

1. **`ReadPositiveNumbers(string Message)`**
   - Prompts the user to enter a positive integer.
   - Ensures the input is a positive number (greater than zero).
   - Returns the validated integer.

2. **`PrintInvertedNumberPattern(int Number)`**
   - Uses nested loops to print an inverted pattern.
   - The outer loop starts from the user-input number down to `1`.
   - The inner loop prints the current value of `i` for `i` times.

3. **`Main(string[] args)`**
   - Calls `ReadPositiveNumbers()` to get a valid input.
   - Passes the input to `PrintInvertedNumberPattern()` to display the pattern.

## Example Execution
### Input:
```
Enter a Positive Number? 5
```
### Output:
```
55555
4444
333
22
1
```

## How to Run the Program
1. Copy and paste the code into a C# compiler or IDE (e.g., Visual Studio, .NET CLI).
2. Compile and run the program.
3. Enter a positive integer when prompted.
4. Observe the inverted number pattern displayed as output.

## Key Concepts Used
- **Loops**: The program uses `for` loops to generate the pattern.
- **Input Validation**: Ensures the user enters a positive integer.
- **Console Output**: Uses `Console.WriteLine()` and `Console.Write()` for structured output.

## Use Cases
- Understanding nested loops in C#.
- Practicing pattern printing problems.
- Building a foundation for more complex pattern-based problems.

## Author
This program is written in C# as part of a pattern printing exercise.

