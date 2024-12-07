
# Sum of Digits Calculator

This C# program calculates the sum of the digits of a user-provided positive integer. The program ensures input validation and uses basic mathematical operations to compute the sum.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem6`
- **Class**: `Problem6`
  - Defined as `internal`, restricting access to the same assembly.

### Main Components

1. **`ReadPositiveNumbers` Method**:
   - Prompts the user to enter a positive integer.
   - Ensures the input is valid using a `do-while` loop, rejecting non-positive numbers.

2. **`SumOfDigits` Method**:
   - Computes the sum of the digits of a given number:
     - Extracts the last digit using the modulus operator (`% 10`).
     - Adds the extracted digit to a running total (`Sum`).
     - Removes the last digit using integer division (`/ 10`).
     - Repeats the process until the number becomes 0.
   - Returns the total sum of the digits.

3. **`Main` Method**:
   - The entry point of the program.
   - Reads a positive integer from the user using `ReadPositiveNumbers`.
   - Calls `SumOfDigits` to calculate and display the sum of the digits.

---

## How It Works

1. **Input Validation**:
   - Ensures that the user inputs a positive integer using `ReadPositiveNumbers`.

2. **Sum Calculation**:
   - For the given number, the digits are extracted one by one.
   - The extracted digits are added together to compute the total sum.

3. **Output**:
   - Displays the sum of the digits of the entered number.

---

## Sample Output

### Input:
```plaintext
Enter a Positive Number?
12345
```
### Output:
Sum Of Digits = 15
```
