# Problem41 - Palindrome Array Checker

## Description
This C# program checks whether a given array is a **palindrome**. An array is considered a palindrome if it reads the same forward and backward.

## How It Works
1. **FillArray Method**:
   - Pre-fills an array with predefined elements: `{10, 20, 30, 30, 20, 10}`.
   - Sets the `arrLength` to 6.

2. **PrintArray Method**:
   - Iterates over the array and prints each element.

3. **IsPalindromeArray Method**:
   - Compares elements from the beginning and end moving towards the center.
   - If any mismatch is found, returns `false`.
   - If no mismatches occur, returns `true`.

4. **Main Method**:
   - Initializes the array.
   - Calls `FillArray` to populate the array.
   - Prints the array.
   - Calls `IsPalindromeArray` to check if the array is a palindrome and displays the result.

## Example Output
```
Array Elements:
10 20 30 30 20 10

Yes, Array is Palindrome
```

## Key Features
- Uses a **two-pointer technique** to check for palindrome properties efficiently.
- Demonstrates array traversal and element comparison.
- Simple and efficient, with a time complexity of **O(n/2)**.

## Potential Enhancements
- Modify the `FillArray` method to allow user input.
- Generalize the method to check palindromes for dynamically created arrays.

This program is a great introduction to array manipulation and palindrome checking using C#!


