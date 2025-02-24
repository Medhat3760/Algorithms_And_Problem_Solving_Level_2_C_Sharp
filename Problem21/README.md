# Generate Keys - C# Program

## Overview
This C# program generates a specified number of random keys, each consisting of four groups of four capital letters separated by hyphens (e.g., `ABCD-EFGH-IJKL-MNOP`). The program ensures that the user inputs a valid positive number before generating the keys.

## Features
- Reads a positive number from the user, representing the number of keys to generate.
- Uses random capital letters to form keys.
- Each key follows the format: `XXXX-XXXX-XXXX-XXXX`, where `X` is a randomly generated capital letter.
- Uses an enumeration (`enCharType`) to categorize character types.

## Code Explanation
### 1. `enum enCharType`
Defines different character types:
- `SmallLetter`
- `CapitalLetter`
- `SpecialCharacter`
- `Digit`

### 2. `ReadPositiveNumber(string Message)`
Prompts the user for a positive number and ensures the input is greater than zero.

### 3. `RandomNumber(int From, int To)`
Generates a random number between the specified range using `Random.Next()`.

### 4. `GetRandomCharacter(enCharType CharType)`
Returns a random character based on the given `enCharType`:
- `CapitalLetter`: ASCII range (65-90)
- `SmallLetter`: ASCII range (97-122)
- `SpecialCharacter`: ASCII range (33-47)
- `Digit`: ASCII range (48-57)

### 5. `GenerateWord(enCharType CharType, short Length)`
Generates a random word of the given length using the specified character type.

### 6. `GenerateKey()`
Creates a key consisting of four random sequences of four capital letters, separated by hyphens.

### 7. `GenerateKeys(int NumberOfKeys)`
Generates the specified number of keys and prints them.

### 8. `Main(string[] args)`
- Reads the number of keys from the user.
- Calls `GenerateKeys()` to generate and print the keys.

## Example Output
```
Enter How Many Keys To Generate? 3

Key[1] : ABCD-EFGH-IJKL-MNOP
Key[2] : WXYZ-QRST-UVWX-YZAB
Key[3] : LMNO-PQRS-TUVW-XYZA
```

## Usage
1. Compile and run the program.
2. Enter a positive number when prompted.
3. View the generated keys.

## Dependencies
- .NET Framework or .NET Core
- C# Compiler

## Conclusion
This program demonstrates the use of randomization, string manipulation, and user input handling in C#. It is useful for generating random license keys, access codes, or authentication tokens.


