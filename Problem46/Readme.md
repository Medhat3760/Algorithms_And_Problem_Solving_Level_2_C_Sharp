# Problem46 - My ABS

## Description

This C# program implements a custom absolute value function called `MyAbs`. It reads a floating-point number from the user, computes its absolute value using both the custom function and the built-in `Math.Abs` function in C#, and displays the results.

## Features

- Reads a floating-point number from the user.
- Implements a custom absolute value function `MyAbs`.
- Compares the result of `MyAbs` with `Math.Abs`.
- Displays both results in the console.

## Code Explanation

### 1. **ReadNumber Method**

```csharp
static float ReadNumber(string Message)
```

- Displays a message prompting the user for input.
- Reads a floating-point number from the console.
- Returns the entered number.

### 2. **MyAbs Method**

```csharp
static float MyAbs(float num)
```

- Checks if the number is negative.
- If negative, multiplies it by `-1` to return its positive counterpart.
- If non-negative, returns the number as is.

### 3. **Main Method**

```csharp
static void Main(string[] args)
```

- Calls `ReadNumber` to get user input.
- Computes the absolute value using `MyAbs`.
- Computes the absolute value using `Math.Abs`.
- Prints both results for comparison.

## Example Output

```
Enter a Number? -23.5

My Abs Result: 23.5

C# Abs Result: 23.5
```

## How to Run

1. Copy and paste the C# code into a .cs file.
2. Compile and run the program in a C# development environment (such as Visual Studio or .NET CLI).
3. Enter a floating-point number when prompted.
4. View the absolute value computed using both methods.

## Conclusion

This program illustrates a simple implementation of the absolute value function in C#. It demonstrates conditional logic and function creation while also comparing a custom function with C#'s built-in `Math.Abs` method.


