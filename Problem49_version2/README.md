# Problem49 - My Ceil Function

## Description

This C# program implements a custom `MyCeil` function that mimics the behavior of the built-in `Math.Ceiling` function. It takes a floating-point number as input, determines its ceiling value, and compares the result with the C# built-in function.

## Features

- Reads a floating-point number from the user.
- Implements a custom ceiling function (`MyCeil`) to round numbers up.
- Compares the output with the built-in `Math.Ceiling` function.
- Displays both results in the console.

## Code Explanation

### 1. **ReadNumber Method**

```csharp
static float ReadNumber(string Message)
```
- Prompts the user for a floating-point number.
- Reads and returns the number as a float.

### 2. **MyCeil Method**

```csharp
static int MyCeil(float Num)
```
- Extracts the fractional part of the number.
- If the fractional part is nonzero and the number is positive, it returns the integer part plus one.
- Otherwise, it returns the integer part as is.

### 3. **Main Method**

```csharp
static void Main(string[] args)
```
- Calls `ReadNumber` to get user input.
- Calls `MyCeil` to compute the custom ceiling value.
- Calls `Math.Ceiling` to get the built-in result.
- Prints both results to the console.

## Example Output

```
Enter a Number? 4.2

My Ceil: 5
C# Ceil: 5

Enter a Number? -3.8

My Ceil: -3
C# Ceil: -3
```

## How to Run

1. Copy and paste the C# code into a `.cs` file.
2. Compile and run the program in a C# development environment (such as Visual Studio or .NET CLI).
3. Enter a floating-point number when prompted.
4. View the custom and built-in ceiling function results in the console.

## Conclusion

This program demonstrates how to manually implement a ceiling function in C#. It showcases type casting, mathematical operations, and user input handling.


