# Problem50 - MySqrt Function

## Description

This C# program implements a custom `MySqrt` function that mimics the behavior of the built-in `Math.Sqrt` function. It takes a floating-point number as input, calculates its square root using exponentiation, and compares the result with the C# built-in function.

## Features

- Reads a floating-point number from the user.
- Implements a custom square root function (`MySqrt`) using the power function.
- Compares the output with the built-in `Math.Sqrt` function.
- Displays both results in the console.

## Code Explanation

### 1. **ReadNumber Method**

```csharp
static float ReadNumber(string Message)
```
- Prompts the user for a floating-point number.
- Reads and returns the number as a float.

### 2. **MySqrt Method**

```csharp
static float MySqrt(float Num)
```
- Uses the `Math.Pow` function to calculate the square root by raising the number to the power of `0.5`.
- Returns the computed square root.

### 3. **Main Method**

```csharp
static void Main(string[] args)
```
- Calls `ReadNumber` to get user input.
- Calls `MySqrt` to compute the custom square root.
- Calls `Math.Sqrt` to get the built-in result.
- Prints both results to the console.

## Example Output

```
Enter a Number? 9

MySqrt Result: 3
C# Sqrt Result: 3

Enter a Number? 16

MySqrt Result: 4
C# Sqrt Result: 4
```

## How to Run

1. Copy and paste the C# code into a `.cs` file.
2. Compile and run the program in a C# development environment (such as Visual Studio or .NET CLI).
3. Enter a floating-point number when prompted.
4. View the custom and built-in square root function results in the console.

## Conclusion

This program demonstrates how to manually compute the square root in C# using exponentiation. It showcases mathematical operations, user input handling, and the comparison of custom and built-in functions.


