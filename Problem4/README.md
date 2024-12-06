# Perfect Numbers from 1 to N

This C# program identifies and prints all **perfect numbers** between 1 and a user-specified positive integer `N`. A **perfect number** is a positive integer that equals the sum of its proper divisors (excluding itself). The program prompts the user to input `N` and outputs all perfect numbers in the range.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem4`
- **Class**: `Problem4`
  - Defined as `internal`, restricting access to the same assembly.

### Main Components

1. **`ReadPositiveNumber` Method**:
   - Prompts the user to input a positive integer.
   - Validates the input using a `do-while` loop to ensure the number is greater than 0.

2. **`IsPerfectNumber` Method**:
   - Determines if a given number is perfect:
     - Computes the sum of all proper divisors up to half the number (`Num / 2`).
     - Returns `true` if the sum equals the number, otherwise `false`.

3. **`PrintPerfectNumbersFrom1toN` Method**:
   - Iterates through all numbers from 1 to `N`.
   - Calls `IsPerfectNumber` to check if each number is perfect.
   - Prints the number if it is perfect.

4. **`Main` Method**:
   - The program's entry point.
   - Reads a positive number from the user.
   - Prints all perfect numbers from 1 to `N` by invoking `PrintPerfectNumbersFrom1toN`.

---

## How It Works

1. **Input Validation**:
   - Ensures that the user inputs a positive number using the `ReadPositiveNumber` method.

2. **Perfect Number Check**:
   - For each number in the range, proper divisors are identified, and their sum is calculated.

3. **Output**:
   - Displays all perfect numbers between 1 and `N`.

---

## Sample Output

### Input:
```plaintext
Enter a Positive Number?
30
```
### Output:
```plaintext
Perfect Numbers From 1 to 30 are:

6
28
