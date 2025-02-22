# Problem15 - Print Letter Pattern

## Description
This C# program prints a letter pattern based on the user's input. It prompts the user to enter a positive number and then prints a pattern where each row contains repeated instances of a letter, starting from 'A' and progressing alphabetically.

## How It Works
1. The program starts execution in the `Main` method.
2. It calls the `ReadPositiveNumbers` method to prompt the user for a positive integer.
3. The `PrintLetterPattern` method is then invoked with the entered number.
4. The pattern is generated using nested loops:
   - The outer loop iterates through ASCII values starting from 65 ('A').
   - The inner loop prints the corresponding letter multiple times.
   - The pattern builds up in a triangular form.

## Code Breakdown

### `ReadPositiveNumbers` Method
- This method prompts the user to enter a number.
- It ensures the input is a positive integer.
- It keeps prompting until the user enters a valid positive number.

### `PrintLetterPattern` Method
- Accepts an integer as input.
- Uses two nested loops:
  - The outer loop iterates over the range of letters starting from 'A'.
  - The inner loop prints the respective letter multiple times.
- The pattern is printed line by line.

## Example Output
If the user enters `5`, the program outputs:
```
A
BB
CCC
DDDD
EEEEE
```

## Usage
- Compile and run the program.
- Enter a positive integer when prompted.
- Observe the generated letter pattern.

## Notes
- The program only accepts positive integers.
- The pattern follows the ASCII character sequence starting from 'A'.

This program demonstrates the use of loops, ASCII character manipulation, and user input validation in C#.


