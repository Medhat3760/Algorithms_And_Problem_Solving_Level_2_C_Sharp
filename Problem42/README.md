# Problem42 - Count Odd Numbers in an Array

## Overview
This C# program generates an array of random numbers and counts how many of them are odd. The program prompts the user to specify the number of elements in the array, fills the array with random values, prints the array, and finally displays the count of odd numbers.

## Features
- Reads a positive integer from the user to determine the array size.
- Fills an array with random numbers ranging from 0 to 100.
- Counts the number of odd numbers in the array.
- Prints the array elements and the odd numbers count.

## Code Breakdown

### 1. **Reading a Positive Number**
```csharp
static int ReadPositiveNumber(string Message)
```
- Prompts the user for input.
- Ensures the number entered is greater than zero.

### 2. **Generating Random Numbers**
```csharp
static Random random = new Random();
static int RandomNumberInRange(int From, int To)
```
- Generates a random number within the specified range.

### 3. **Filling the Array with Random Numbers**
```csharp
static void FillArrayWithRandomNumbers(int[] arr, ref int arrLength)
```
- Prompts the user for the number of elements.
- Populates the array with random numbers from 0 to 100.

### 4. **Counting Odd Numbers in the Array**
```csharp
static int OddNumbersCountInArray(int[] arr, int arrLength)
```
- Iterates through the array and counts the numbers that are not divisible by 2.

### 5. **Printing the Array Elements**
```csharp
static void PrintArray(int[] arr, int arrLength)
```
- Displays the array elements on the console.

### 6. **Main Method Execution**
```csharp
static void Main(string[] args)
```
- Declares an integer array with a size of 100.
- Calls functions to populate, display, and count odd numbers.
- Prints the results.

## Example Output
```
Enter number of elements? 5

Array Elements:
3 14 27 42 55

Odd Numbers Count is: 3
```

## How to Run
1. Compile and run the program in a C# environment.
2. Enter the number of elements.
3. Observe the array output and the count of odd numbers.

## Conclusion
This program effectively demonstrates array manipulation, random number generation, and basic number property checks in C#. It provides a simple but useful utility for working with odd numbers in an array.


