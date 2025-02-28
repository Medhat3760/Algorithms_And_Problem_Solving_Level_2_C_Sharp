# Problem43 - Count Even Numbers in an Array

## Overview
This C# program counts the number of even numbers in an array filled with random values. The program follows these steps:

1. Prompts the user to enter the number of elements in the array.
2. Fills the array with random numbers between 0 and 100.
3. Prints the generated array.
4. Counts and displays the number of even numbers in the array.

## Features
- Uses a function to read a positive integer from the user.
- Generates an array of random numbers.
- Implements a function to count even numbers in the array.
- Displays the original array and the even number count.

## Code Explanation

### 1. `ReadPositiveNumber(string Message)`
Prompts the user to enter a positive integer and ensures input validation.

### 2. `RandomNumberInRange(int From, int To)`
Generates a random number within a specified range.

### 3. `FillArrayWithRandomNumbers(int[] arr, ref int arrLength)`
- Calls `ReadPositiveNumber` to determine the array size.
- Fills the array with random numbers between 0 and 100.

### 4. `EvenNumbersCountInArray(int[] arr, int arrLength)`
- Iterates through the array.
- Counts elements that are even (i.e., divisible by 2).

### 5. `PrintArray(int[] arr, int arrLength)`
Prints the elements of the array in a single line.

### 6. `Main(string[] args)`
- Initializes an integer array of size 100.
- Calls functions to fill and process the array.
- Prints the array and the count of even numbers.

## Sample Output
```
Enter number of elements? 10

Array Elements:
4 7 10 33 18 22 35 40 55 66

Even Numbers Count is: 6
```

## How to Run the Program
1. Compile the C# program using `csc Problem43.cs` (if using the command line).
2. Run the executable file `Problem43.exe`.
3. Follow the on-screen instructions to enter the number of elements.
4. View the generated array and the count of even numbers.

## Author
This program was written for educational purposes to demonstrate array manipulation and basic control structures in C#.


