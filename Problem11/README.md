# Problem11: Check Palindrome Number

This program is a C# console application that checks whether a given positive integer is a palindrome. A number is considered a palindrome if it reads the same backward as forward, such as `121` or `12321`.

## Features

- Reads a positive integer from the user.
- Reverses the input number.
- Compares the original number with its reverse to determine if it is a palindrome.
- Displays the result to the user.

## Code Overview

### Methods

1. **`ReadPositiveNumbers(string Message)`**
   - Prompts the user to enter a positive integer.
   - Repeats until a valid positive number is entered.
   - Returns the valid input as an integer.

2. **`ReverseNumber(int Number)`**
   - Reverses the digits of the input number.
   - Uses a `while` loop to extract digits and build the reversed number.
   - Returns the reversed integer.

3. **`isPalindromNumber(int Number)`**
   - Compares the original number with its reversed version.
   - Returns `true` if they are the same, otherwise `false`.

4. **`PrintResult(int Number)`**
   - Prints a message indicating whether the given number is a palindrome or not.

5. **`Main(string[] args)`**
   - Entry point of the application.
   - Invokes the necessary methods to read input, check for palindrome, and display the result.

## How It Works

1. The program starts by asking the user to enter a positive number using the `ReadPositiveNumbers` method.
2. It reverses the entered number using the `ReverseNumber` method.
3. The reversed number is compared with the original number in the `isPalindromNumber` method.
4. Finally, the `PrintResult` method outputs whether the number is a palindrome or not.

## Example

### Input:
```
Enter The Number that You Want to Check if its Palindrom?
12321
```

### Output:
```
 yes, its a Palindrome Number
```

### Input:
```
Enter The Number that You Want to Check if its Palindrom?
12345
```

### Output:
```
 NO, its Not a Palindrome Number
```

## Edge Cases

- Input: `0` (The program prompts the user again because `0` is not positive).
- Input: `-121` (The program does not accept negative numbers).
- Input: `10` (The program correctly identifies that `10` is not a palindrome).

## Usage

1. Compile the program using a C# compiler (e.g., `csc`).
2. Run the generated executable.
3. Follow the prompts to check if a number is a palindrome.

## Requirements

- .NET Framework or .NET Core runtime
- Basic understanding of C# programming
