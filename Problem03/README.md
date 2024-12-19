# Perfect Number Checker Program in C#

This C# program determines whether a user-specified positive integer is a **perfect number**. A perfect number is a positive integer that is equal to the sum of its proper divisors (excluding itself). The program interacts with the user to input the number and outputs whether the number is perfect.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem3`
- **Class**: `Problem3`
  - Marked as `internal` to restrict access to the same assembly.

### Main Components

1. **`ReadPositiveNumber` Method**:
   - Prompts the user to enter a positive integer.
   - Ensures input validation using a `do-while` loop, rejecting non-positive numbers.

2. **`IsPerfect` Method**:
   - Determines whether the given number is perfect:
     - Iterates through all integers less than the number.
     - Checks if each integer is a divisor using the modulus operator (`%`).
     - Sums up all proper divisors.
   - Returns `true` if the sum equals the original number, otherwise `false`.

3. **`PrintNumberType` Method**:
   - Prints whether the number is a perfect number or not by calling the `IsPerfect` method.

4. **`Main` Method**:
   - The entry point of the program.
   - Reads a positive number from the user and determines its type (perfect or not).

---

## How It Works

1. **Input Validation**:
   - The user is prompted to enter a positive integer.
   - Invalid inputs (non-positive numbers) are rejected, ensuring the program only processes valid input.

2. **Perfect Number Check**:
   - Proper divisors of the number are identified.
   - The sum of these divisors is compared to the original number.

3. **Output**:
   - Displays whether the number is perfect or not.

---

## Sample Output

### Input:
```plaintext
Enter a Positive Number?
28
```
### Output:
```plaintext
28 is Perfect Number
