# Prime Numbers Printer Program in C#

This C# program identifies and prints all prime numbers from 1 to a user-specified positive integer `N`. It features a clean structure with an interactive prompt to input `N`, modular methods for reusability, and an enum for better code readability.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem2`
- **Class**: `Problem2`
  - Marked as `internal` to limit access to the same assembly.

### Main Components

1. **`enPrimeNotprime` Enum**:
   - An enum with two values:
     - `Prime`: Indicates a number is prime.
     - `NotPrime`: Indicates a number is not prime.

2. **`ReadPositiveNumber` Method**:
   - Prompts the user to enter a positive integer.
   - Ensures input is valid by repeatedly asking until a positive number is provided.

3. **`CheckPrime` Method**:
   - Determines whether a number is prime using a mathematical rule:
     - If the number is 1, it is not prime.
     - Iterates through possible divisors up to half the number and checks for divisibility.
   - Returns `Prime` or `NotPrime` based on the result.

4. **`PrintPrimeNumbersFrom1toN` Method**:
   - Iterates through numbers from 1 to `N`.
   - Calls `CheckPrime` for each number.
   - Prints the number if it is prime.

5. **`Main` Method**:
   - The entry point of the program.
   - Reads a positive number from the user.
   - Prints all prime numbers from 1 to `N` by calling `PrintPrimeNumbersFrom1toN`.

---

## How It Works

1. **Input Validation**:
   - The user is prompted to enter a positive integer.
   - Invalid inputs (non-positive numbers) are rejected.

2. **Prime Check**:
   - Numbers are classified as `Prime` or `NotPrime` using the `CheckPrime` method.

3. **Output**:
   - Displays all prime numbers between 1 and `N`.

---

## Sample Output

### Input:
```plaintext
Enter a Positive Number ?
20
Prime Numbers From 1 to 20 are :
2
3
5
7
11
13
17
19

