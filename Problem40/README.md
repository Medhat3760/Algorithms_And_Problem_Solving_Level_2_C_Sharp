# Problem40 - Copy Distinct Numbers to Array

## Overview
This C# program copies distinct numbers from one array to another, ensuring no duplicates in the destination array.

## Functionality
- The program starts with a predefined integer array (`arr`) containing duplicate values.
- It iterates through the source array and adds only unique elements to the destination array (`arr2`).
- The program then prints both arrays to the console.

## Code Explanation

### 1. **Checking for Duplicates**
```csharp
static bool IsNumberInArray(int Number, int[] arr, int arrLength)
```
- Iterates through `arr` to check if `Number` already exists.
- Returns `true` if the number is found, `false` otherwise.

### 2. **Adding Elements to the Array**
```csharp
static void AddArrayElement(int Number, int[] arrDestination, ref int arrDestinationLength)
```
- Adds `Number` to `arrDestination` at the next available position.
- Increments `arrDestinationLength`.

### 3. **Copying Distinct Numbers**
```csharp
static void CopyDistinctNumbersToArray(int[] arrSource, int[] arrDestination, int SourceLength, ref int DestinationLength)
```
- Loops through `arrSource`, adding only unique numbers to `arrDestination`.
- Uses `IsNumberInArray()` to check for duplicates before adding.

### 4. **Printing Arrays**
```csharp
static void PrintArray(int[] arr, int arrLength)
```
- Loops through an array and prints each element.

### 5. **Main Method Execution**
```csharp
static void Main(string[] args)
```
- Initializes the source array `arr` with duplicate numbers.
- Defines a destination array `arr2` with a capacity of 100.
- Calls `CopyDistinctNumbersToArray()` to remove duplicates.
- Prints both arrays for comparison.

## Example Output
```
Array 1 Elements:
10 10 10 50 50 70 70 70 70 90 10

Array 2 Elements:
10 50 70 90
```

## Key Takeaways
- **Avoids using `List<int>` for learning purposes.**
- **Uses simple array manipulations and iteration.**
- **Efficient way to remove duplicates from an array without sorting.**

## Possible Enhancements
- Use `HashSet<int>` for O(1) lookup time.
- Implement user input instead of a predefined array.
- Allow dynamic array sizes using `List<int>`.  ( But we focus on working with arrays )


