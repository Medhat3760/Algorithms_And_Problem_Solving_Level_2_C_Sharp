# All Digits Frequency Counter

This C# program determines the frequency of each digit (0–9) in a given positive integer. It demonstrates basic numerical operations, loops, and frequency counting.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem9`
- **Class**: `Problem9`
  - Defined as `internal`, restricting access to the same assembly.

### Main Components

1. **`ReadPositiveNumber` Method**:
   - Prompts the user to input a positive number.
   - Validates the input to ensure it's greater than 0.

2. **`CountDigitFrequency` Method**:
   - Calculates how many times a specific digit appears in a number.
   - Uses modulus and division operations to extract each digit.

3. **`PrintAllDigitsFrequency` Method**:
   - Iterates through all digits from 0 to 9.
   - Calls `CountDigitFrequency` for each digit.
   - Prints the frequency of each digit that appears at least once.

4. **`Main` Method**:
   - The program's entry point.
   - Reads the input number and invokes `PrintAllDigitsFrequency`.

---

## How It Works

1. **Input**:
   - The program prompts the user to enter a positive number.

2. **Digit Frequency Calculation**:
   - Each digit (0–9) is checked against the input number.
   - The count for each digit is calculated using a loop and printed.

3. **Output**:
   - Frequencies of digits are displayed only for those that occur in the number.

---

## Sample Output

### Input:
```plaintext
Enter The Main Number?
112233445566
```
### Output:
```
Digit 1 Frequency is 2 Time(s)
Digit 2 Frequency is 2 Time(s)
Digit 3 Frequency is 2 Time(s)
Digit 4 Frequency is 2 Time(s)
Digit 5 Frequency is 2 Time(s)
Digit 6 Frequency is 2 Time(s)
