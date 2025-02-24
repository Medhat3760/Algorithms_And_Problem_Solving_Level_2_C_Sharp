# Problem27: Average Of Random Array

## Overview
This C# program generates an array filled with random numbers and calculates the average of its elements.

## Features
- Reads a positive integer from the user to determine the array size.
- Fills the array with random numbers between 1 and 100.
- Prints the generated array.
- Computes the sum of all elements in the array.
- Calculates and displays the average of the array elements.

## Code Explanation

### 1. **ReadPositiveNumber(string Message)**
   - Reads and returns a positive integer from the user.
   - Ensures the input is greater than 0.

### 2. **RandomNumber(int From, int To)**
   - Generates and returns a random integer within the specified range.

### 3. **FillArrayWithRandomNumbers(int[] Arr, ref int Length)**
   - Asks the user for the number of elements.
   - Fills the array with random numbers between 1 and 100.

### 4. **PrintArray(int[] Arr, int Length)**
   - Prints the elements of the array in a single line.

### 5. **SumArray(int[] Arr, int arrLength)**
   - Computes and returns the sum of all array elements.

### 6. **AverageOfArray(int[] Arr, int arrLength)**
   - Calculates the average of the array elements by dividing the sum by the total number of elements.

### 7. **Main Method**
   - Initializes an array of size 100.
   - Calls `FillArrayWithRandomNumbers()` to populate the array.
   - Calls `PrintArray()` to display the array elements.
   - Computes and prints the average of the array elements.

## Example Run
```
Enter How Many items you Want To Fill? 5
Array Elements: 23 45 67 12 89

Average Of All Numbers is: 47.2
```

## How to Run
1. Compile the program using a C# compiler.
2. Run the executable and enter the required input values.

## Dependencies
- C#
- .NET Framework or .NET Core

## Author
This program was created as a basic implementation of arrays and random number generation in C#.


