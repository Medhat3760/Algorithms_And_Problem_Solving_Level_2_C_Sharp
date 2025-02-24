# Problem22 - Repeated Elements Count In Array

## Overview
This C# program counts how many times a specific number appears in an array. It allows the user to input an array of integers and then check how many times a particular number is repeated within it.

## Features
- Reads a positive number from the user.
- Accepts an array of integers from user input.
- Displays the entered array.
- Counts and displays how many times a given number appears in the array.

## Code Explanation

### 1. `ReadPositiveNumber(string Message)`
This function prompts the user with a message and ensures that the input is a positive number.
```csharp
static int ReadPositiveNumber(string Message)
{
    int Num;
    do
    {
        Console.WriteLine(Message);
        Num = int.Parse(Console.ReadLine());
    } while (Num <= 0);
    return Num;
}
```

### 2. `ReadArray(int[] Arr, ref int Length)`
This function reads an array of integers from the user. It first asks for the number of elements and then stores user inputs in the array.
```csharp
static void ReadArray(int[] Arr, ref int Length)
{
    Length = ReadPositiveNumber("Enter How Many Elements Of Array?");
    Console.WriteLine("\nEnter Array Elements: ");
    for (int i = 0; i <= Length - 1; i++)
    {
        Console.Write("Element[" + (i + 1) + "]: ");
        Arr[i] = int.Parse(Console.ReadLine());
    }
}
```

### 3. `PrintArray(int[] Arr, int Length)`
Prints the contents of the array.
```csharp
static void PrintArray(int[] Arr, int Length)
{
    for (int i = 0; i <= Length - 1; i++)
    {
        Console.Write(Arr[i] + " ");
    }
}
```

### 4. `TimesRepeated(int[] Arr, int Length, int NumberToCheck)`
Counts how many times `NumberToCheck` appears in the array.
```csharp
static int TimesRepeated(int[] Arr, int Length, int NumberToCheck)
{
    int Count = 0;
    for (int i = 0; i <= Length - 1; i++)
    {
        if (NumberToCheck == Arr[i])
        {
            Count++;
        }
    }
    return Count;
}
```

### 5. `Main` Method
- Reads the array from user input.
- Asks the user for the number to check.
- Prints the original array.
- Displays how many times the number appears in the array.
```csharp
static void Main(string[] args)
{
    int[] Arr = new int[100];
    int Length = 0, NumberToCheck = 0;
    ReadArray(Arr, ref Length);
    NumberToCheck = ReadPositiveNumber("\nEnter The Number You Want To Check?");
    Console.Write("\nOriginal Array: ");
    PrintArray(Arr, Length);
    Console.WriteLine("\n\n" + NumberToCheck + " is Repeated " + TimesRepeated(Arr, Length, NumberToCheck) + " time(s)");
}
```

## Example Output
```
Enter How Many Elements Of Array? 5

Enter Array Elements:
Element[1]: 3
Element[2]: 5
Element[3]: 3
Element[4]: 7
Element[5]: 3

Enter The Number You Want To Check? 3

Original Array: 3 5 3 7 3

3 is Repeated 3 time(s)
```

## Summary
- The program reads an array from the user.
- It checks how many times a specific number appears.
- Displays the result in a simple and clear format.

This program is useful for scenarios where counting occurrences of a number in an array is needed, such as statistical analysis or frequency calculations.


