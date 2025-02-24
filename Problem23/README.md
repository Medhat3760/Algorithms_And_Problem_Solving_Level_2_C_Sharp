# Problem23 - Fill Array With Random Numbers

## Description
This C# program generates an array filled with random numbers. The user specifies the number of elements to be generated, and the program populates the array with random integers between 1 and 100, then prints the array to the console.

## How It Works

1. The program prompts the user to enter a positive number specifying how many random numbers should be generated.
2. It generates random numbers in the range of 1 to 100.
3. The generated numbers are stored in an array.
4. The program prints the array elements to the console.

## Code Breakdown

### 1. `ReadPositiveNumber(string Message)`
   - Prompts the user with a message and reads an integer input.
   - Ensures the number entered is positive by using a `do-while` loop.

### 2. `RandomNumber(int From, int To)`
   - Uses `Random` to generate a random number within the specified range (`From` to `To`).

### 3. `FillArrayWithRandomNumbers(int[] Arr, ref int Length)`
   - Calls `ReadPositiveNumber` to get the number of elements.
   - Fills the array with random numbers between 1 and 100.

### 4. `PrintArray(int[] Arr, int Length)`
   - Iterates through the array and prints each element.

### 5. `Main(string[] args)`
   - Initializes an integer array with a maximum size of 100.
   - Calls `FillArrayWithRandomNumbers` to populate the array.
   - Calls `PrintArray` to display the generated numbers.

## Example Run

```
Enter How Many items you Want To Fill? 5

Array Elements: 23 87 45 12 99
```

## Key Concepts
- Generating random numbers in a specific range.
- Working with arrays in C#.
- Using methods for modular programming.
- Reading user input and ensuring valid data.

This program is useful for understanding array manipulation and random number generation in C#.


