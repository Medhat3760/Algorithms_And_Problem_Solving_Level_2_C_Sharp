# Problem32: Copy Array In Reverse Order

## Description
This C# program generates an array of random numbers, then creates a second array that contains the same elements but in reverse order. The program prompts the user to enter the number of elements, fills the array with random numbers, and displays both the original and reversed arrays.

## Features
- Reads a positive number from the user to determine the size of the array.
- Fills an array with random numbers between 1 and 100.
- Copies the elements of the first array into a second array in reversed order.
- Displays both the original and reversed arrays.

## Code Breakdown

### 1. **Reading a Positive Number**
```csharp
static int ReadPositiveNumber(string Message)
```
- Prompts the user with a message.
- Ensures the user enters a positive integer.

### 2. **Generating Random Numbers**
```csharp
static Random random = new Random();
static int RandomNumberInRange(int From, int To)
```
- Generates a random number within the given range.

### 3. **Filling the Array with Random Numbers**
```csharp
static void FillArrayWithRandomNumbers(int[] arr, int arrLength)
```
- Fills an array with random numbers between 1 and 100.

### 4. **Copying Array in Reversed Order**
```csharp
static void CopyArrayInReversedOrder(int[] arrSource, int[] arrDestination, int arrLength)
```
- Iterates through the source array and copies each element to the destination array in reverse order.

### 5. **Printing an Array**
```csharp
static void PrintArray(int[] arr, int arrLength)
```
- Prints the elements of an array to the console.

### 6. **Main Method**
```csharp
static void Main(string[] args)
```
- Reads the number of elements from the user.
- Fills the first array with random numbers.
- Copies the first array to a second array in reversed order.
- Prints both arrays.

## Example Output
```
Enter Number Of Elements? 5

Array 1 Elements:
45 23 78 90 12

Array 2 Elements After Copying Array 1 In Reversed Order:
12 90 78 23 45
```

## How to Run the Program
1. Compile and run the C# program.
2. Enter a positive number for the array size.
3. View the original and reversed arrays in the console.


