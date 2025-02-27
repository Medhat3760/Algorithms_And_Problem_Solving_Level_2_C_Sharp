# Problem38 - Copy Odd Numbers to a New Array

## Overview
This C# program generates an array of random numbers and extracts only the odd numbers into a new array. The extracted numbers are stored in a separate array and displayed to the user.

## Features
- Reads a user-defined number of elements.
- Generates random numbers between 1 and 100.
- Identifies odd numbers and copies them to a new array.
- Displays both the original and filtered arrays.

## Code Explanation

### 1. **Enumeration (enOddOrEven)**
```csharp
enum enOddOrEven { Odd = 1, Even = 2 }
```
Defines an enum to classify numbers as **Odd** or **Even**.

### 2. **CheckOddOrEven Method**
```csharp
static enOddOrEven CheckOddOrEven(int Number)
```
Determines whether a given number is odd or even using the modulus operator `%`.

### 3. **ReadPositiveNumber Method**
```csharp
static int ReadPositiveNumber(string Message)
```
Prompts the user to enter a positive number and validates the input.

### 4. **RandomNumber Method**
```csharp
static int RandomNumber(int From, int To)
```
Generates a random integer between the specified range.

### 5. **FillArrayWithRandomNumbers Method**
```csharp
static void FillArrayWithRandomNumbers(int[] arr, int arrLength)
```
Fills an array with random numbers between 1 and 100.

### 6. **AddArrayElement Method**
```csharp
static void AddArrayElement(int Number, int[] arr, ref int arrLength)
```
Adds a new element to the array and updates the array length.

### 7. **CopyArrayOddNumbers Method**
```csharp
static void CopyArrayOddNumbers(int[] arrSource, int[] arrDestination, int arrLength, ref int arrDestinationLength)
```
Iterates through the source array and copies only the odd numbers to the destination array.

### 8. **PrintArray Method**
```csharp
static void PrintArray(int[] arr, int arrLength)
```
Prints all elements in the given array.

### 9. **Main Method**
```csharp
static void Main(string[] args)
```
- Reads the number of elements from the user.
- Fills an array with random numbers.
- Copies only the odd numbers to a new array.
- Prints both the original and filtered arrays.

## Example Output
```
Enter Number Of Elements? 10

Array 1 Elements:
23 10 45 56 89 12 33 67 90 77

Array 2 After Copy Odd Numbers:
23 45 89 33 67 77
```

## Conclusion
This program efficiently separates odd numbers from a randomly generated array and stores them in a new array, demonstrating array manipulation techniques in C#.


