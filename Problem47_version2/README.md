# Problem47_version2 - Custom Rounding Function

## Description

This C# program implements a custom rounding function, `MyRound`, that mimics the behavior of the built-in `Math.Round` method. It rounds a floating-point number to the nearest integer based on its fractional part. The program reads a floating-point number from the user, applies both `MyRound` and `Math.Round`, and displays the results for comparison.

## Features

- Reads a floating-point number from the user.
- Extracts the fractional part of the number.
- Implements a rounding mechanism similar to `Math.Round`.
- Displays the rounded results from both the custom function and the built-in C# method.

## Code Explanation

### 1. **ReadNumber Method**

```csharp
static float ReadNumber(string Message)
```

- Displays a message and prompts the user to enter a floating-point number.
- Parses the input as a `float`.
- Returns the user-entered value.

### 2. **GetFractionPart Method**

```csharp
static float GetFractionPart(float Num)
```

- Extracts and returns the fractional part of the given number.
- Uses casting to separate the integer part from the decimal portion.

### 3. **MyRound Method**

```csharp
static int MyRound(float Num)
```

- Implements custom rounding logic:
  - If the number is positive, adds `0.5` and casts to `int`.
  - If the number is negative, subtracts `0.5` before casting to `int`.
- Returns the rounded integer value.

### 4. **Main Method**

```csharp
static void Main(string[] args)
```

- Calls `ReadNumber` to obtain user input.
- Applies `MyRound` and `Math.Round` to the input.
- Displays both results for comparison.

## Example Output

```
Enter a Number? 4.7

My Round Result: 5

C# Round Result: 5
```

```
Enter a Number? -2.3

My Round Result: -2

C# Round Result: -2
```

## How to Run

1. Copy and paste the C# code into a .cs file.
2. Compile and run the program using a C# development environment (such as Visual Studio or .NET CLI).
3. Enter a floating-point number when prompted.
4. View and compare the rounded results in the console.

## Conclusion

This program demonstrates custom rounding logic in C#, reinforcing concepts like type casting, floating-point arithmetic, and conditional operations. The `MyRound` function effectively simulates standard rounding behavior while maintaining clarity and efficiency.


