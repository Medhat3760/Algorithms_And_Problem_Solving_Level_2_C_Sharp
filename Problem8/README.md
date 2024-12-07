# Digit Frequency Counter

This C# program calculates the frequency of a specific digit in a given positive integer. It ensures valid input for both the number and the digit to check and uses mathematical operations to count the occurrences of the specified digit.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem8`
- **Class**: `Problem8`
  - Defined as `internal`, restricting access to the same assembly.

### Main Components

1. **`ReadPositiveNumber` Method**:
   - Prompts the user to enter a positive integer.
   - Validates the input using a `do-while` loop to ensure the input is greater than 0.

2. **`CountDigitFrequancy` Method**:
   - Counts the occurrences of a specific digit (`DigitToCheck`) in a number (`Number`):
     - Extracts the last digit of the number using the modulus operator (`% 10`).
     - Compares the extracted digit with the specified digit.
     - Increments the frequency count (`FreqCount`) if they match.
     - Removes the last digit using integer division (`/ 10`).
     - Repeats until the number becomes 0.
   - Returns the frequency count.

3. **`Main` Method**:
   - The entry point of the program.
   - Reads a positive number and a single digit from the user using `ReadPositiveNumber`.
   - Calls `CountDigitFrequancy` to calculate the frequency and displays the result.

---

## How It Works

1. **Input Validation**:
   - The program ensures valid input for both the main number and the digit to check using `ReadPositiveNumber`.

2. **Frequency Calculation**:
   - Each digit of the main number is extracted and compared with the specified digit.
   - A counter is incremented each time a match is found.

3. **Output**:
   - Displays the frequency of the specified digit in the main number.

---

## Sample Output

### Input:
```plaintext
Please enter the main number?
1234512345
Please enter one digit to check?
5
```
### Output:
```
Digit 5 Frequency is 2 Time(s).
```
