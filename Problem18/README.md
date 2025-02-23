# Problem18 - Encrypt And Decrypt Text

## Overview
This C# program encrypts and decrypts a given text using a simple character shifting method. It reads a text input from the user, encrypts it by shifting characters forward in the ASCII table, and then decrypts it back to its original form by reversing the shift.

## Features
- Reads a text input from the user.
- Encrypts the text by shifting characters forward using a predefined encryption key.
- Decrypts the text by shifting characters backward using the same key.
- Displays the original text, encrypted text, and decrypted text.

## Code Explanation

### **1. ReadText Method**
```csharp
static string ReadText(string Message)
```
- Prompts the user to enter a text.
- Reads and returns the inputted text.

### **2. EncryptText Method**
```csharp
static string EncryptText(string Text, short EncryptionKey)
```
- Converts the input text into a character array.
- Shifts each character forward by the encryption key value.
- Returns the encrypted string.

### **3. DecryptText Method**
```csharp
static string DecryptText(string Text, short EncryptionKey)
```
- Converts the encrypted text into a character array.
- Shifts each character backward by the encryption key value.
- Returns the decrypted string.

### **4. Main Method**
```csharp
static void Main(string[] args)
```
- Calls `ReadText` to get user input.
- Defines a constant encryption key (`short EncryptionKey = 2`).
- Calls `EncryptText` and `DecryptText` to process the text.
- Displays the original, encrypted, and decrypted text.

## Example Output
```
Enter a Text ?
Hello

Text Before Encryption : Hello
Text After Encryption  : Jgnnq
Text After Decryption  : Hello
```
## Usage
- This program demonstrates a basic encryption and decryption approach using character shifting.
- Can be enhanced with more advanced encryption algorithms for security purposes.

## Notes
- The encryption key determines how many ASCII positions each character shifts.
- Currently, it only works with basic ASCII characters and does not handle special cases (e.g., spaces, symbols, or Unicode characters).

## Author
This project is a simple demonstration of text encryption and decryption using C#.


