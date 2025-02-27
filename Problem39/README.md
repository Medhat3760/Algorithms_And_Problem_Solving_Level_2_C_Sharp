# Problem39: Copy Prime Numbers to a New Array

## Description
This C# program generates an array of random numbers and copies only the prime numbers into a new array. It utilizes functions to determine whether a number is prime, fill an array with random values, and copy prime numbers to another array.

## Features
- Reads a user-specified number of elements.
- Generates random numbers between 1 and 100.
- Determines if a number is prime.
- Copies only prime numbers to a new array.
- Displays both the original and the filtered arrays.

## Code Explanation

### 1. **Enum for Prime Classification**
```csharp
enum enPrimeNotPrime { Prime = 1, NotPrime = 2 }
```
Defines an enumeration to classify numbers as **Prime** or **Not Prime**.

### 2. **CheckPrime Function**
```csharp
static enPrimeNotPrime CheckPrime(int Num)
```
- Checks if a number is prime.
- Returns **Prime** if the number is prime; otherwise, returns **NotPrime**.
- Uses an efficient method by:
  - Eliminating numbers less than 2.
  - Treating `2` as a special case (the only even prime number).
  - Skipping even numbers greater than 2.
  - Checking divisibility only up to the square root of the number.

### 3. **ReadPositiveNumber Function**
```csharp
static int ReadPositiveNumber(string Message)
```
- Reads a positive integer from the user.
- Ensures the input is greater than zero.

### 4. **Random Number Generation**
```csharp
static Random random = new Random();
static int RandomNumber(int From, int To)
```
- Generates a random number within a specified range (1-100).

### 5. **FillArrayWithRandomNumbers Function**
```csharp
static void FillArrayWithRandomNumbers(int[] arr, int arrLength)
```
- Fills an array with random numbers using `RandomNumber(1, 100)`.

### 6. **AddArrayElement Function**
```csharp
static void AddArrayElement(int Number, int[] arr, ref int arrLength)
```
- Adds a new number to the array and updates its length.

### 7. **Copy Prime Numbers to a New Array**
```csharp
static void CopyArrayPrimeNumbers(int[] arrSource, int[] arrDestination, int arrLength, ref int arrDestinationLength)
```
- Iterates through the source array.
- Uses `CheckPrime()` to identify prime numbers.
- Copies prime numbers to a new array using `AddArrayElement()`.

### 8. **PrintArray Function**
```csharp
static void PrintArray(int[] arr, int arrLength)
```
- Prints the elements of an array.

### 9. **Main Function**
```csharp
static void Main(string[] args)
```
- Reads the number of elements from the user.
- Generates a random array.
- Copies prime numbers to a new array.
- Displays both arrays.

## Example Output
```
Enter Number Of Elements? 10

Array 1 Elements:
12 5 7 20 17 6 11 3 8 2

Array 2 Prime Numbers:
5 7 17 11 3 2
```

## Conclusion
This program demonstrates how to:
- Work with arrays in C#.
- Use functions for modularity.
- Implement efficient prime number checking.
- Copy elements conditionally between arrays.

