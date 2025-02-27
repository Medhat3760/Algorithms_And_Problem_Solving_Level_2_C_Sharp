# Problem37 - Copy Array Using AddArrayElement

## Overview
This C# program generates an array of random numbers and then copies its elements into another array using a custom function. The copying is done element by element using an "AddArrayElement" method, mimicking dynamic array behavior.

## Features
- Reads a positive number from the user to determine the number of elements.
- Generates an array filled with random numbers between 1 and 100.
- Copies the array elements using the `AddArrayElement` method.
- Prints both the original and copied arrays.

## Code Explanation

### 1. `ReadPositiveNumber(string Message)`
- Prompts the user for a positive integer.
- Ensures input validation by re-asking until a positive number is entered.

### 2. `RandomNumber(int From, int To)`
- Generates a random number within the specified range.

### 3. `FillArrayWithRandomNumbers(int[] arr, int arrLength)`
- Populates the array with random numbers from 1 to 100.

### 4. `AddArrayElement(int Number, int[] arr, ref int arrLength)`
- Adds an element to the array.
- Increments the array length.

### 5. `CopyArrayUsingAddArrayElement(int[] arrSource, int[] arrDestination, int arrLength, ref int arrDestinationLength)`
- Copies elements from the source array to the destination array.
- Uses `AddArrayElement` to ensure elements are added dynamically.

### 6. `PrintArray(int[] arr, int arrLength)`
- Prints the elements of the array to the console.

### 7. `Main(string[] args)`
- Reads the number of elements from the user.
- Fills an array with random numbers.
- Displays the original array.
- Copies the array elements using `CopyArrayUsingAddArrayElement`.
- Prints the copied array.

## Example Output
```
Enter Number Of Elements? 5

Array 1 Elements:
23 67 89 12 45

Array 2 Elements After Copy:
23 67 89 12 45
```

## How to Run
1. Compile and run the program in a C# environment.
2. Enter the number of elements when prompted.
3. The program will generate a random array and copy it.
4. Both arrays will be printed to the console.

## Conclusion
This program demonstrates how to copy an array dynamically using a manual element addition approach, simulating dynamic arrays in C#.


