# Problem34 - Return Number Index in Array

## Description
This C# program generates an array filled with random numbers and allows the user to search for a specific number within the array. If the number exists, the program returns its index and order in the array. Otherwise, it informs the user that the number is not found.

## Features
- Reads a positive integer from the user to determine the array size.
- Populates the array with random numbers between 1 and 100.
- Displays the generated array.
- Prompts the user to enter a number to search for in the array.
- Returns the index and order of the number if found.
- Informs the user if the number is not present in the array.

## Code Explanation

### 1. **ReadPositiveNumber()**
This function prompts the user to enter a positive number and ensures input validation.
```csharp
static int ReadPositiveNumber(string Message)
```

### 2. **RandomNumberInRange()**
Generates a random number within a given range.
```csharp
static int RandomNumberInRange(int From, int To)
```

### 3. **FillArrayWithRandomNumbers()**
Fills an array with random numbers between 1 and 100.
```csharp
static void FillArrayWithRandomNumbers(int[] arr, int arrLength)
```

### 4. **PrintArray()**
Prints the array elements.
```csharp
static void PrintArray(int[] arr, int arrLength)
```

### 5. **FindNumberPositionInArray()**
Searches for a given number in the array and returns its index if found, otherwise returns `-1`.
```csharp
static short FindNumberPositionInArray(int Number, int[] arr, int arrLength)
```

### 6. **Main()**
- Reads the array length from the user.
- Fills the array with random numbers.
- Prints the array.
- Reads the number to search for.
- Searches for the number and prints its index/order if found.

```csharp
static void Main(string[] args)
```

## Sample Output
```
Enter Number Of Elements? 5

Array1 Elements:
12 45 78 23 56

Enter a Number To Search For? 23

Number You Are Looking For is: 23
The Number Found At Position: 3
The Number Found its Order  : 4
```

## Usage
1. Compile and run the program.
2. Enter the number of elements.
3. Observe the randomly generated array.
4. Enter a number to search for.
5. Get the index and order if found.

## Notes
- The index starts from `0`, but the order starts from `1`.
- The program ensures valid input for positive numbers.
- Uses `Random` class to generate numbers dynamically.
