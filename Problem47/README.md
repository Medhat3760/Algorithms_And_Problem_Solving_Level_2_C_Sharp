# Problem47 - My Round Function

## Description

This C# program implements a custom rounding function (`MyRound`) that mimics the behavior of `Math.Round`. The program reads a floating-point number from the user, extracts its integer and fractional parts, and determines whether to round up or down based on the fraction. Finally, it compares the result with C#'s built-in `Math.Round` function.

## Features

- Reads a floating-point number from the user.
- Extracts the integer and fractional parts of the number.
- Implements a custom rounding function (`MyRound`) that rounds based on the fractional part.
- Compares the result with C#'s `Math.Round`.

## Code Explanation

### 1. **ReadNumber Method**

```csharp
static float ReadNumber(string Message)
```

- Prompts the user to enter a floating-point number.
- Parses the input and returns the float value.

### 2. **GetFractionPart Method**

```csharp
static float GetFractionPart(float Num)
```

- Extracts the fractional part of a given number.
- Returns the difference between the number and its integer part.

### 3. **MyRound Method**

```csharp
static int MyRound(float Num)
```

- Extracts the integer and fractional parts of the number.
- Checks if the absolute value of the fractional part is `>= 0.5`.
  - If true, rounds up (for positive numbers) or rounds down (for negative numbers).
  - Otherwise, returns the integer part without rounding.

### 4. **Main Method**

```csharp
static void Main(string[] args)
```

- Calls `ReadNumber` to get user input.
- Calls `MyRound` to round the number.
- Displays the result of `MyRound` and compares it with `Math.Round`.

## Example Output

```
Enter a Number? 4.7

My Round Result: 5

C# Round Result: 5
```

```
Enter a Number? -3.4

My Round Result: -3

C# Round Result: -3
```

## How to Run

1. Copy and paste the C# code into a .cs file.
2. Compile and run the program in a C# development environment (such as Visual Studio or .NET CLI).
3. Enter a floating-point number when prompted.
4. View the rounded result using both `MyRound` and `Math.Round`.

## Conclusion

This program demonstrates how to manually implement rounding logic using integer and fractional parts. It highlights the use of conditionals and floating-point arithmetic to achieve the same results as `Math.Round`.


