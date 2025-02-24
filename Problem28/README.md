# Problem28 - Copy Array

## Overview
This C# program demonstrates how to create, populate, and copy an array. It generates a random array of numbers, prints its contents, then copies it to another array and prints the copied values.

## Features
- Reads a positive integer from the user to determine the array length.
- Fills an array with random numbers between 1 and 100.
- Prints the contents of the original and copied arrays.
- Copies the contents of one array into another manually.

## Code Explanation

### 1. `ReadPositiveNumber(string Message)`
Prompts the user for a positive integer input and ensures it's greater than zero before returning it.

### 2. `RandomNumber(int From, int To)`
Generates and returns a random integer between the specified `From` and `To` values (inclusive).

### 3. `FillArrayWithRandomNumbers(int[] Arr, ref int Length)`
- Asks the user for the number of elements to generate.
- Populates the array with random numbers from 1 to 100.

### 4. `PrintArray(int[] Arr, int Length)`
Prints the elements of the array in a single line.

### 5. `CopyArray(int[] arrSource, int[] arrDestination, int arrLength)`
Copies the contents of `arrSource` into `arrDestination` using a loop.

### 6. `Main(string[] args)`
- Creates an array with a maximum size of 100.
- Fills it with random numbers.
- Copies its contents into another array.
- Prints both arrays to verify the copy operation.

## Sample Output
```
Enter How Many items you Want To Fill?
5

Array Elements: 34 67 12 89 45
Array 2 Elements After Copy: 34 67 12 89 45
```

## How to Run the Code
1. Open a C# compiler or IDE (e.g., Visual Studio, Visual Studio Code).
2. Create a new C# console application.
3. Copy and paste the provided code into the `Program.cs` file.
4. Run the program and follow the prompts.

## Notes
- The maximum array size is set to 100.
- The program ensures the array length entered by the user is positive.
- The array copy is performed manually using a loop instead of built-in functions like `Array.Copy` for educational purposes.

## Author
This program was developed as a learning exercise to understand basic array manipulation in C#.


