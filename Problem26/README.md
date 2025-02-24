# Sum of Random Array

## Overview
This C# program generates an array filled with random numbers and calculates the sum of all elements in the array. It prompts the user to enter the number of elements, fills the array with random values between 1 and 100, and then displays the array along with the total sum.

## Features
- Reads a positive integer input from the user to determine the array size.
- Generates random numbers between 1 and 100.
- Calculates and displays the sum of all elements in the array.

## Code Explanation

### Functions

1. **ReadPositiveNumber(string Message)**
   - Prompts the user for a positive integer input.
   - Ensures the user enters a valid positive number.
   
2. **RandomNumber(int From, int To)**
   - Generates a random number within the specified range.

3. **FillArrayWithRandomNumbers(int[] Arr, ref int Length)**
   - Fills an array with random numbers between 1 and 100.
   - Uses `ReadPositiveNumber()` to determine the number of elements.

4. **PrintArray(int[] Arr, int Length)**
   - Prints all elements of the array.

5. **SumArray(int[] Arr, int arrLength)**
   - Iterates through the array and calculates the sum of its elements.

### Main Function
1. Declares an array of size 100 and a variable `Length` to store the actual number of elements.
2. Calls `FillArrayWithRandomNumbers()` to populate the array.
3. Prints the array elements.
4. Calls `SumArray()` to compute and display the sum of all elements.

## Example Output
```
Enter How Many items you Want To Fill? 5
Array Elements: 45 78 23 89 12

Sum Of All Numbers is: 247
```

## How to Run the Program
1. Compile the C# file using `csc Problem26.cs` (if using the command line).
2. Run the executable using `Problem26.exe`.
3. Follow the prompts to enter the number of elements and view the results.

## Dependencies
- .NET Framework or .NET Core runtime.

## Author
This program is a simple demonstration of working with arrays, random numbers, and basic input validation in C#.


