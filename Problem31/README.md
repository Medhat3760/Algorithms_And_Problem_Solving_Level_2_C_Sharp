# Problem31 - Shuffle Ordered Array

## Overview
This C# program generates an ordered array of numbers from 1 to N, then shuffles the array randomly. It demonstrates array manipulation, random number generation, and swapping techniques in C#.

## Features
- Reads a positive integer from the user to determine the array size.
- Fills the array with ordered numbers from 1 to N.
- Shuffles the array randomly.
- Prints the array before and after shuffling.

## Code Explanation

### 1. `ReadPositiveNumber(string Message)`
This function prompts the user to enter a positive number and ensures valid input.
```csharp
static int ReadPositiveNumber(string Message)
```
- It uses a `do-while` loop to validate that the number is positive.
- Returns the valid positive integer.

### 2. `Swap(ref int A, ref int B)`
This function swaps the values of two integers using a temporary variable.
```csharp
static void Swap(ref int A, ref int B)
```

### 3. `FillArrayFrom1ToN(int[] arr, int N)`
Fills an array with numbers from 1 to N.
```csharp
static void FillArrayFrom1ToN(int[] arr, int N)
```

### 4. `RandomNumber(int From, int To)`
Generates a random number within a specified range.
```csharp
static int RandomNumber(int From, int To)
```
- Uses `Random.Next(From, To + 1)` to ensure inclusivity.

### 5. `ShuffleArray(int[] arr, int arrLength)`
Shuffles the array using random swaps.
```csharp
static void ShuffleArray(int[] arr, int arrLength)
```
- Iterates over the array and swaps elements randomly.
- Uses `RandomNumber()` to select indices for swapping.

### 6. `PrintArray(int[] arr, int arrLength)`
Prints the elements of the array.
```csharp
static void PrintArray(int[] arr, int arrLength)
```
- Loops through the array and prints each element.

### 7. `Main(string[] args)`
The entry point of the program.
```csharp
static void Main(string[] args)
```
- Reads the array size from the user.
- Fills the array with ordered numbers.
- Prints the original array.
- Shuffles the array.
- Prints the shuffled array.

## Example Output
```
Enter Number Of Elements? 5

Array Elements Before Shuffle: 
1 2 3 4 5 

Array Elements After Shuffle: 
3 1 5 2 4 
```

## Summary
This program effectively demonstrates random shuffling of an ordered array. The key techniques include:
- Input validation
- Array initialization
- Random number generation
- Swapping elements

It is a useful implementation for scenarios requiring randomized ordering, such as card shuffling or lottery number generation.
