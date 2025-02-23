# Problem20 - Random Character Generator

## Overview
This C# program generates random characters, including small letters, capital letters, special characters, and digits, using the `Random` class. The characters are generated based on an enumeration that categorizes them into four types.

## Features
- Generates a random small letter (a-z).
- Generates a random capital letter (A-Z).
- Generates a random special character (! to /).
- Generates a random digit (0-9).

## Code Explanation

### Enum `enCharType`
An enumeration `enCharType` is defined to represent different character types:
- `SmallLetter` (1)
- `CapitalLetter` (2)
- `SpecialCharacter` (3)
- `Digit` (4)

### `RandomNumber` Method
This method generates a random integer between a given range using `Random.Next(int, int)`. It ensures that the generated number is within the specified range.

```csharp
static int RandomNumber(int From, int To)
{
    return random.Next(From, To + 1);
}
```

### `GetRandomCharacter` Method
This method takes an `enCharType` argument and returns a random character based on the provided type. It uses ASCII values to determine the character ranges:
- Small letters (ASCII 97-122)
- Capital letters (ASCII 65-90)
- Special characters (ASCII 33-47)
- Digits (ASCII 48-57)

```csharp
static char GetRandomCharacter(enCharType CharType)
{
    switch (CharType)
    {
        case enCharType.SmallLetter:
            return (char)RandomNumber(97, 122);
        case enCharType.CapitalLetter:
            return (char)RandomNumber(65, 90);
        case enCharType.SpecialCharacter:
            return (char)RandomNumber(33, 47);
        case enCharType.Digit:
            return (char)RandomNumber(48, 57);
        default:
            return ' ';
    }
}
```

### `Main` Method
The `Main` method calls `GetRandomCharacter` for each character type and prints the result.

```csharp
static void Main(string[] args)
{
    Console.WriteLine(GetRandomCharacter(enCharType.SmallLetter));
    Console.WriteLine(GetRandomCharacter(enCharType.CapitalLetter));
    Console.WriteLine(GetRandomCharacter(enCharType.SpecialCharacter));
    Console.WriteLine(GetRandomCharacter(enCharType.Digit));
}
```

## Sample Output
```
q
M
!
7
```
Each run of the program will produce different random characters.

## How to Run the Program
1. Copy the code into a C# project.
2. Compile and run the program.
3. The console will output four random characters: one from each category.

## Summary
This program efficiently generates random characters from different categories using ASCII value ranges. It can be useful in applications such as password generators and random string creation.


