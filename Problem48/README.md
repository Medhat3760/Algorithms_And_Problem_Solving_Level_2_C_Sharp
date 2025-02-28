# Problem48 - My Floor Implementation

## Description

This C# program implements a custom version of the `Floor` function, which rounds a floating-point number down to the nearest integer. It also compares the result with C#'s built-in `Math.Floor` function.

## Features

- Reads a floating-point number from the user.
- Implements a custom `MyFloor` function to simulate the behavior of `Math.Floor`.
- Prints both the custom and built-in floor results for comparison.

## Code Explanation

### 1. **ReadNumber Method**

```csharp
static float ReadNumber(string Message)
```

- Prompts the user to enter a floating-point number.
- Reads and returns the inputted number.

### 2. **MyFloor Method**

```csharp
static int MyFloor(float Num)
```

- If `Num` is positive, it returns the integer part of `Num`.
- If `Num` is negative, it decrements `Num` and then returns the integer part.
- This ensures proper flooring behavior for negative numbers.

### 3. **Main Method**

```csharp
static void Main(string[] args)
```

- Reads a number from the user using `ReadNumber`.
- Calls `MyFloor` to compute the custom floor value.
- Calls `Math.Floor` to get the built-in C# floor result.
- Prints both results to compare their outputs.

## Example Output

```
Enter a Number? -4.7

My Floor: -5
C# Floor: -5
```

## How to Run

1. Copy and paste the C# code into a .cs file.
2. Compile and run the program in a C# development environment (such as Visual Studio or .NET CLI).
3. Enter a floating-point number when prompted.
4. View the custom and built-in floor results in the console.

## Conclusion

This program demonstrates how to implement a custom floor function in C#. It showcases typecasting, conditional logic, and mathematical operations to achieve results similar to `Math.Floor`.


