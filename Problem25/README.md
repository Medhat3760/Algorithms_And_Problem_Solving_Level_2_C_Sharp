# Problem25 - Find Minimum Number in an Array

## Description
This C# program generates an array filled with random numbers and determines the smallest number in the array. The program prompts the user to enter the number of elements they want to generate, fills an array with random numbers, prints the array, and then finds and displays the minimum value.

## Features
- Reads a positive number from the user to determine the size of the array.
- Fills the array with random numbers between 1 and 100.
- Prints the array elements.
- Finds and displays the smallest number in the array.

## Code Explanation

### 1. **ReadPositiveNumber Method**
This method ensures the user enters a positive integer.
```csharp
static int ReadPositiveNumber(string Message)
```
- Displays a message prompting the user to enter a number.
- Ensures the number entered is greater than zero.

### 2. **RandomNumber Method**
Generates a random number within a specified range.
```csharp
static int RandomNumber(int From, int To)
```
- Uses `Random` to generate a number between `From` and `To`.

### 3. **FillArrayWithRandomNumbers Method**
Fills an array with random numbers.
```csharp
static void FillArrayWithRandomNumbers(int[] Arr, ref int Length)
```
- Reads the number of elements from the user.
- Populates the array with random numbers from 1 to 100.

### 4. **PrintArray Method**
Prints the elements of the array.
```csharp
static void PrintArray(int[] Arr, int Length)
```
- Iterates through the array and prints each element.

### 5. **MinNumberOfArray Method**
Finds the smallest number in the array.
```csharp
static int MinNumberOfArray(int[] Arr, int arrLength)
```
- Initializes `Min` with the first element.
- Loops through the array, updating `Min` whenever a smaller value is found.
- Returns the smallest number.

### 6. **Main Method**
The entry point of the program.
```csharp
static void Main(string[] args)
```
- Declares an integer array with a max size of 100.
- Calls `FillArrayWithRandomNumbers` to populate the array.
- Prints the array.
- Calls `MinNumberOfArray` and displays the minimum value.

## Example Output
```
Enter How Many items you Want To Fill? 5
Array Elements: 45 78 12 67 3

Min Number Of Array is 3
```

## Summary
This program is useful for generating an array of random numbers and finding the smallest element. It demonstrates the use of loops, functions, and conditional statements in C#.


