# Problem44 - Count Positive Numbers in an Array

## Overview
This C# program counts the number of positive numbers in an array filled with random values. The program generates an array with random numbers ranging from -100 to 100, then determines how many of them are positive.

## Features
- Reads a positive number from the user to determine the array length.
- Fills the array with random integers in the range of -100 to 100.
- Counts and prints the number of positive integers in the array.
- Displays the generated array and the count of positive numbers.

## Code Explanation
### 1. **ReadPositiveNumber Method**
```csharp
static int ReadPositiveNumber(string Message)
```
- Ensures that the user enters a positive integer.
- Keeps prompting until a valid input is provided.

### 2. **RandomNumberInRange Method**
```csharp
static int RandomNumberInRange(int From, int To)
```
- Generates a random number within a specified range.

### 3. **FillArrayWithRandomNumbers Method**
```csharp
static void FillArrayWithRandomNumbers(int[] arr, ref int arrLength)
```
- Asks the user for the number of elements.
- Fills the array with random numbers between -100 and 100.

### 4. **PositiveNumbersCountInArray Method**
```csharp
static int PositiveNumbersCountInArray(int[] arr, int arrLength)
```
- Iterates through the array and counts numbers greater than 0.

### 5. **PrintArray Method**
```csharp
static void PrintArray(int[] arr, int arrLength)
```
- Prints all elements of the array in a single line.

### 6. **Main Method**
```csharp
static void Main(string[] args)
```
- Initializes the array.
- Calls functions to fill the array, display it, and count positive numbers.

## Sample Output
```
Enter number of elements?
5

Array Elements:
-45 78 -23 89 10

Positive Numbers Count is: 3
```

## How to Run
1. Compile and run the program in a C# environment.
2. Enter the desired number of elements when prompted.
3. The program will generate random numbers and display the count of positive values.

## Author
This program is part of a coding exercise focused on array operations in C#.


