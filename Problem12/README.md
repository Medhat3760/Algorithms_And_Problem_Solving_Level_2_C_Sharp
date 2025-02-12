# Reverse Number - C# Console Application

## Overview

This C# console application is designed to reverse a given positive integer. It prompts the user to input a positive number, reverses the digits of that number, and then displays the reversed number.

---

## Features

- **Input Validation**: Ensures the user enters a valid positive integer.
- **Number Reversal**: Reverses the digits of the input number.
- **Simple and Efficient**: Uses basic arithmetic operations to reverse the number.

---

## Code Structure

### 1. **`ReadPositiveNumbers` Method**
   - **Purpose**: Prompts the user to enter a positive integer and validates the input.
   - **Parameters**:
     - `Message`: A string message to display to the user.
   - **Returns**: A valid positive integer entered by the user.

### 2. **`ReverseNumber` Method**
   - **Purpose**: Reverses the digits of the input number.
   - **Parameters**:
     - `Number`: The positive integer to be reversed.
   - **Returns**: The reversed number.

### 3. **`Main` Method**
   - **Purpose**: The entry point of the application.
   - **Steps**:
     1. Prompts the user to enter a positive number using the `ReadPositiveNumbers` method.
     2. Reverses the number using the `ReverseNumber` method.
     3. Displays the reversed number to the user.

---

## How It Works

1. **Input Validation**:
   - The `ReadPositiveNumbers` method ensures the user enters a valid positive integer. If the input is invalid (e.g., negative or zero), the user is prompted again.

2. **Number Reversal**:
   - The `ReverseNumber` method uses a `while` loop to extract the last digit of the number using the modulus operator (`%`) and builds the reversed number by multiplying the current result by 10 and adding the extracted digit.

3. **Output**:
   - The reversed number is displayed to the user.

---

## Example

### Input:
Entre a Positive Number?

12345

### Output:
Reverse Number is :

54321


---

## Code Explanation

### `ReadPositiveNumbers` Method
```csharp
static int ReadPositiveNumbers(string Message)
{
    int Num;
    do
    {
        Console.WriteLine(Message);
        Num = int.Parse(Console.ReadLine());
    } while (Num <= 0); // Ensure the number is positive
    return Num;
}

static int ReverseNumber(int Number)
{
    int Remainder = 0, Number2 = 0;
    while (Number > 0)
    {
        Remainder = Number % 10; // Extract the last digit
        Number /= 10; // Remove the last digit
        Number2 = Number2 * 10 + Remainder; // Build the reversed number
    }
    return Number2;
}

static void Main(string[] args)
{
    Console.WriteLine("Reverse Number is :\n" +
                      ReverseNumber(ReadPositiveNumbers("Entre a Positive Number?")));
}
