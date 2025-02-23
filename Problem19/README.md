# Problem19 - Random 3 Numbers From 1 to 10

## Overview
This C# program generates and prints three random numbers in the range of 1 to 10. It uses the `Random` class to generate the numbers and a helper method to encapsulate the randomization logic.

## Code Explanation

### Namespace and Class
The program is defined under the `Problem19` namespace and contains a class named `Problem19`.

### Random Number Generation
A `Random` object named `random` is created as a static field to generate random numbers.

```csharp
static Random random = new Random();
```

### Method: `RandomNumber(int From, int To)`
This method generates a random integer within a specified range (inclusive of `From` and `To`).

```csharp
static int RandomNumber(int From, int To)
{
    int RandNum = random.Next(From, To + 1);
    return RandNum;
}
```
- The method takes two parameters: `From` (starting range) and `To` (ending range).
- It uses `random.Next(From, To + 1)` to generate a number within the specified range.
- The result is returned to the caller.

### Main Method
The `Main` method calls `RandomNumber(1, 10)` three times and prints the generated numbers to the console.

```csharp
static void Main(string[] args)
{
    Console.WriteLine(RandomNumber(1, 10));
    Console.WriteLine(RandomNumber(1, 10));
    Console.WriteLine(RandomNumber(1, 10));
}
```
- Each call generates a random number between 1 and 10 and prints it to the console.
- Since `Random.Next()` is used, the numbers generated will be different each time the program runs.

## Expected Output
When executed, the program will print three random numbers between 1 and 10. Example output:
```
7
3
10
```

The output will vary with each execution due to randomness.

## Key Concepts
- **Random Number Generation**: The `Random` class is used to generate pseudo-random numbers.
- **Method Usage**: Encapsulating logic in a method for reusability.
- **Static Fields**: The `Random` object is static to ensure consistent behavior across multiple calls.

## Enhancements
- Allow user input to specify the range dynamically.
- Generate a user-specified number of random numbers.
- Store and analyze the generated numbers (e.g., count occurrences).


