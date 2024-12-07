# Reverse a Number Program

This C# program calculates the reverse of a user-provided positive integer. It ensures valid input and uses arithmetic operations to reverse the number.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem7`
- **Class**: `Problem7`
  - Defined as `internal`, restricting access to the same assembly.

### Main Components

1. **`ReadPositiveNumbers` Method**:
   - Prompts the user to enter a positive integer.
   - Validates the input using a `do-while` loop to ensure the number is greater than 0.

2. **`ReverseNumber` Method**:
   - Reverses the digits of the input number:
     - Extracts the last digit using the modulus operator (`% 10`).
     - Builds the reversed number (`Number2`) by multiplying it by 10 and adding the extracted digit.
     - Removes the last digit from the original number using integer division (`/ 10`).
     - Continues until the number becomes 0.
   - Returns the reversed number.

3. **`Main` Method**:
   - The entry point of the program.
   - Reads a positive number from the user using `ReadPositiveNumbers`.
   - Calls `ReverseNumber` to reverse the digits and displays the result.

---

## How It Works

1. **Input Validation**:
   - Ensures the user inputs a positive integer using `ReadPositiveNumbers`.

2. **Reverse Calculation**:
   - Digits are extracted from the input number one by one.
   - Each digit is appended to the reversed number.

3. **Output**:
   - Displays the reversed number.

---

## Sample Output

### Input:
```plaintext
Enter a Positive Number?
12345
```
### Output:
```
Reverse Number is:
54321
```
