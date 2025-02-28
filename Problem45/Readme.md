# Problem45 - Count Negative Numbers in Array

## Description

This C# program generates an array filled with random numbers (both positive and negative) and counts the number of negative numbers in the array. The user is prompted to input the number of elements, and the program then fills the array with random numbers in the range of -100 to 100. Finally, it prints the array and displays the count of negative numbers.

## Features

- Reads a positive integer from the user to determine the array size.
- Fills the array with random numbers ranging from -100 to 100.
- Counts the number of negative numbers in the array.
- Displays the array elements and the count of negative numbers.

## Code Explanation

### 1. **ReadPositiveNumber Method**

```csharp
static int ReadPositiveNumber(string Message)
```

- Prompts the user to enter a positive number.
- Ensures the number is greater than zero.
- Returns the valid positive number.

### 2. **RandomNumberInRange Method**

```csharp
static int RandomNumberInRange(int From, int To)
```

- Generates and returns a random number between `From` and `To`.

### 3. **FillArrayWithRandomNumbers Method**

```csharp
static void FillArrayWithRandomNumbers(int[] arr, ref int arrLength)
```

- Calls `ReadPositiveNumber` to get the array size.
- Fills the array with random numbers between -100 and 100.

### 4. **NegativeNumbersCountInArray Method**

```csharp
static int NegativeNumbersCountInArray(int[] arr, int arrLength)
```

- Iterates through the array and counts negative numbers.
- Returns the count of negative numbers.

### 5. **PrintArray Method**

```csharp
static void PrintArray(int[] arr, int arrLength)
```

- Prints the array elements to the console.

### 6. **Main Method**

```csharp
static void Main(string[] args)
```

- Declares an integer array of size 100.
- Calls `FillArrayWithRandomNumbers` to populate the array.
- Prints the array elements using `PrintArray`.
- Calls `NegativeNumbersCountInArray` to get the count of negative numbers.
- Displays the result in the console.

## Example Output

```
Enter number of elements? 10

Array Elements:
-35 45 -12 89 -67 23 10 -90 50 5

Negative Numbers Count is: 4
```

## How to Run

1. Copy and paste the C# code into a .cs file.
2. Compile and run the program in a C# development environment (such as Visual Studio or .NET CLI).
3. Enter the number of elements when prompted.
4. View the array and the count of negative numbers in the console.

## Conclusion

This program demonstrates array manipulation, user input validation, and basic random number generation in C#. It efficiently counts and displays negative numbers in an array.


