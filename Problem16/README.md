# Problem16 - Print Words From AAA to ZZZ

## Description
This C# program prints all possible three-letter uppercase combinations from "AAA" to "ZZZ" using nested loops.

## Code Breakdown

### Namespace and Class Definition
The program is encapsulated in the namespace `Problem16` and the class `Problem16`.

### `PrintWordsFromAAAtoZZZ` Method
- This method generates and prints all possible three-letter words consisting of uppercase English letters (A-Z).
- Three nested `for` loops iterate over ASCII values of uppercase letters (65 to 90).
  - The outer loop controls the first letter.
  - The middle loop controls the second letter.
  - The inner loop controls the third letter.
- Each iteration prints a combination of three characters.
- An empty `Console.WriteLine()` is used to separate sections visually.

### `Main` Method
- Calls `PrintWordsFromAAAtoZZZ` to execute the program.

## Example Output
```
AAA
AAB
AAC
...
ZZZ
```

## How to Run
1. Compile the program using a C# compiler or run it in Visual Studio.
2. Execute the program to see all three-letter uppercase combinations printed sequentially.

## Concepts Demonstrated
- ASCII character manipulation
- Nested loops
- Console output handling


