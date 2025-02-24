# Problem24 - Max Number of Array

## Overview
This C# program generates an array of random numbers and determines the maximum number in the array. The program follows these steps:

1. Prompt the user to enter the number of elements for the array.
2. Fill the array with random numbers between 1 and 100.
3. Print the generated array.
4. Find and display the maximum number in the array.

## Code Explanation

### 1. `ReadPositiveNumber(string Message)`
- Asks the user for input and ensures the entered number is positive.
- Loops until a positive number is provided.

### 2. `RandomNumber(int From, int To)`
- Generates a random number between the specified range (`From` to `To`).

### 3. `FillArrayWithRandomNumbers(int[] Arr, ref int Length)`
- Prompts the user for the number of elements to generate.
- Fills the array with random numbers using `RandomNumber(1, 100)`.

### 4. `PrintArray(int[] Arr, int Length)`
- Iterates through the array and prints each element.

### 5. `MaxNumberOfArray(int[] Arr, int arrLength)`
- Finds the maximum number in the array by iterating through its elements.

### 6. `Main(string[] args)`
- Creates an array of size 100.
- Calls `FillArrayWithRandomNumbers()` to populate it.
- Calls `PrintArray()` to display the generated numbers.
- Calls `MaxNumberOfArray()` to find and print the largest number.

## Example Output
```
Enter How Many items you Want To Fill? 5

Array Elements: 23 89 45 12 78

Max Number Of Array is 89
```

## Summary
This program efficiently generates an array, prints it, and determines the maximum value in the list. It demonstrates the use of loops, functions, and handling user input effectively.


