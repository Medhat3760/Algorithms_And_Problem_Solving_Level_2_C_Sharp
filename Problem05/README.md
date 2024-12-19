# Reverse Digits of a Number

This C# program reverses the digits of a given positive integer and prints each digit on a new line. The program ensures the input is a valid positive integer and uses a simple mathematical approach to extract and display digits in reverse order.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem5`
- **Class**: `Problem5`
  - Defined as `internal`, restricting access to the same assembly.

### Main Components

1. **`ReadPositiveNumbers` Method**:
   - Prompts the user to enter a positive integer.
   - Validates the input using a `do-while` loop to ensure the input is greater than 0.

2. **`ReverseDigits` Method**:
   - Reverses and prints the digits of the provided number:
     - Extracts the last digit using the modulus operator (`% 10`).
     - Removes the last digit by integer division (`/ 10`).
     - Prints each extracted digit on a new line until the number becomes 0.

3. **`Main` Method**:
   - The entry point of the program.
   - Reads a positive integer from the user using `ReadPositiveNumbers`.
   - Calls `ReverseDigits` to reverse and print the digits of the entered number.

---

## How It Works

1. **Input Validation**:
   - The user is prompted to enter a positive number.
   - Invalid inputs (non-positive numbers) are rejected using a validation loop.

2. **Digit Extraction**:
   - For the given number, the last digit is extracted and printed.
   - The process repeats until the number becomes 0.

3. **Output**:
   - Displays each digit of the number in reverse order, one digit per line.

---

## Sample Output

### Input:
```plaintext
Enter a Positive Number?
12345
```
### Output:
```plaintext
5
4
3
2
1
