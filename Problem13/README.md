# Number Pattern Program in C#

## Overview
This C# program prints a number pattern based on user input. The pattern consists of numbers printed in a triangular shape, where each row contains the same number repeated according to the row index.

## Program Explanation
The program consists of the following key components:

### 1. `ReadPositiveNumbers(string Message)`
- This function prompts the user to enter a positive number.
- It ensures that the input is greater than zero before returning it.

### 2. `PrintNumberPattern(int Num)`
- This function prints a number pattern based on the input `Num`.
- It uses nested loops:
  - The outer loop (`i`) controls the number of rows.
  - The inner loop (`j`) prints the number `i` repeated `i` times in each row.

### 3. `Main()`
- The `Main` method calls `ReadPositiveNumbers()` to get user input.
- It then calls `PrintNumberPattern()` to display the pattern.

## Example Output
```
Enter a Positive Number? 5
1
22
333
4444
55555
```

## How to Run
1. Copy the code into a C# compiler or IDE (such as Visual Studio or VS Code with C# extension).
2. Compile and run the program.
3. Enter a positive number when prompted.
4. Observe the number pattern displayed as output.

## Code
```csharp
﻿namespace Problem13
{
    // Print Number Pattern
    internal class Problem13
    {
        static int ReadPositiveNumbers(string Message)
        {
            int Num;
            do
            {
                Console.WriteLine(Message);
                Num = int.Parse(Console.ReadLine());
            } while (Num <= 0);
            return Num;
        }

        static void PrintNumberPattern(int Num)
        {
            for (int i = 1; i <= Num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PrintNumberPattern(ReadPositiveNumbers("Enter a Positive Number?"));
        }
    }
}
```

## Notes
- The program ensures that only positive numbers are accepted.
- The pattern follows a simple triangular number structure.
- You can modify the pattern format by adjusting the nested loops.


