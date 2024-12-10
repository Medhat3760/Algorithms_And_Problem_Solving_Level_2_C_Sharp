# Print Digits in Order

This C# program extracts and prints the digits of a positive integer in their natural order. It reverses the number to achieve sequential digit extraction.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem10`
- **Class**: `Problem10`
  - The main class containing methods to process and print the digits of a number in order.

### Main Components

1. **`ReadPositiveNumbers` Method**:
   - Prompts the user to input a positive integer.
   - Ensures that the input is valid (greater than 0).

2. **`ReverseNumber` Method**:
   - Reverses the digits of a given number.
   - Uses modulus and division operations to extract digits and form the reversed number.

3. **`PrintDigits` Method**:
   - Extracts and prints each digit of the reversed number, effectively displaying them in the original order.

4. **`Main` Method**:
   - The program's entry point.
   - Reads the input number, reverses it, and then prints its digits in order.

---

## How It Works

1. **Input**:
   - The program prompts the user to enter a positive number.

2. **Reverse and Extract Digits**:
   - The number is reversed using `ReverseNumber`.
   - Digits are then extracted from the reversed number, resulting in the digits being printed in their natural order.

3. **Output**:
   - Each digit of the number is displayed on a new line.

---

## Sample Output

### Input:
```plaintext
Enter Main Number?
12345
```
### Output:
```
1
2
3
4
5
