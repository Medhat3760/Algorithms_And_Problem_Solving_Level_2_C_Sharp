# Problem33 - Fill Array With Keys

## Description
This C# program generates an array filled with random keys. Each key consists of four groups of four uppercase letters separated by dashes (e.g., `ABCD-EFGH-IJKL-MNOP`). The program allows the user to specify the number of keys to generate and then prints them to the console.

## Features
- Reads a positive integer from the user to determine the number of keys.
- Generates random uppercase character-based keys.
- Stores the keys in an array and prints them.

## Code Explanation
### Enum `enCharType`
An enumeration defining different character types:
- `SmallLetter`: Lowercase letters (`a-z`)
- `CapitalLetter`: Uppercase letters (`A-Z`)
- `SpecialCharacter`: Special characters (`!-/`)
- `Digit`: Numeric digits (`0-9`)

### Methods
1. **`ReadPositiveNumber(string Message)`**
   - Reads a positive integer input from the user.

2. **`RandomNumberInRange(int From, int To)`**
   - Generates a random number within a given range.

3. **`GetRandomCharacter(enCharType CharType)`**
   - Returns a random character based on the specified `enCharType`.

4. **`GenerateWord(enCharType CharType, short Length)`**
   - Creates a string of randomly generated characters of a given type and length.

5. **`GenerateKey()`**
   - Generates a formatted key containing four groups of uppercase letters.

6. **`FillArrayWithKeys(string[] arr, int arrLength)`**
   - Fills an array with randomly generated keys.

7. **`PrintStringArray(string[] arr, int arrLength)`**
   - Prints the array elements to the console.

### `Main` Method
- Reads the desired number of keys.
- Fills an array with generated keys.
- Prints the generated keys.

## Example Output
```
Enter How Many Keys Do You Want To Generate? 3

Array Elements:
Array[0] : XZRW-QYPT-DMLK-VNSO
Array[1] : AGFU-KLNP-QWET-ZXCV
Array[2] : JHGF-UIOP-ASDF-MNBV
```

## How to Run
1. Compile and run the program in a C# environment (e.g., Visual Studio, .NET CLI).
2. Enter the number of keys to generate.
3. View the randomly generated keys displayed in the console.
