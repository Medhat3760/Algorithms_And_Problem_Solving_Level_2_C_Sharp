# Problem30: Sum Of Two Arrays To a Third One

## Description
This C# program generates two arrays of random numbers, sums their corresponding elements, and stores the result in a third array. The program prompts the user to enter the number of elements for the arrays, fills them with random numbers, computes the sum, and displays all three arrays.

## Features
- Reads a positive integer from the user to determine the size of the arrays.
- Generates random integers between 1 and 100 to populate the arrays.
- Computes the sum of corresponding elements from two arrays.
- Displays all three arrays.

## Code Explanation
### 1. **Reading a Positive Number**
```csharp
static int ReadPositiveNumber(string Message)
```
This function prompts the user to enter a positive integer, ensuring that the input is greater than zero.

### 2. **Generating Random Numbers**
```csharp
static Random random = new Random();
static int RandomNumber(int From, int To)
```
Generates a random number within a specified range using the `Random` class.

### 3. **Filling Arrays with Random Numbers**
```csharp
static void FillArrayWithRandomNumbers(int[] arr, int arrLength)
```
Fills an array with random numbers ranging from 1 to 100.

### 4. **Summing Two Arrays**
```csharp
static void SumOf2Arrays(int[] arr, int[] arr2, int[] arrSum, int arrLength)
```
Computes the sum of corresponding elements from `arr` and `arr2`, storing the results in `arrSum`.

### 5. **Printing an Array**
```csharp
static void PrintArray(int[] arr, int arrLength)
```
Displays the elements of an array.

### 6. **Main Method**
```csharp
static void Main(string[] args)
```
- Initializes three arrays of size 100.
- Reads the number of elements from the user.
- Fills two arrays with random numbers.
- Computes their sum and stores it in the third array.
- Prints all three arrays.

## Sample Output
```
Enter Number of Elements? 5

Array 1 Elements:
23 45 67 12 89

Array 2 Elements:
34 56 78 90 11

Sum Of Array1 and Array2 Elements:
57 101 145 102 100
```

## How to Run
1. Copy the code into a C# console application.
2. Compile and run the program.
3. Enter the number of elements when prompted.
4. View the output of randomly generated arrays and their sum.

## Dependencies
- .NET Core or .NET Framework

## Author
This program is written as a simple demonstration of array operations in C#.

