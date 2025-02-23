# Problem16_version2 - Print Words from AAA to ZZZ

## Description
This C# program generates and prints all possible three-letter uppercase combinations from "AAA" to "ZZZ" using nested loops. The program iterates through the ASCII values of uppercase English letters ('A' to 'Z') and constructs words by combining three characters at a time.

## How It Works
1. The program defines a method `PrintWordsFromAAAtoZZZ()` that generates all three-letter combinations.
2. It uses three nested `for` loops to iterate through ASCII values from 65 ('A') to 90 ('Z').
3. Inside the innermost loop:
   - It appends three characters to form a word.
   - Prints the generated word.
   - Resets the string `Word` after each print.
4. The `Main` method calls `PrintWordsFromAAAtoZZZ()` to execute the pattern generation.

## Code Explanation
```csharp
namespace Problem16_version2
{
    // Print Words From AAA to ZZZ
    internal class Problem16_version2
    {
        static void PrintWordsFromAAAtoZZZ()
        {
            string Word = "";

            for (int i = 65; i <= 90; i++) // Loop for first letter
            {
                for (int j = 65; j <= 90; j++) // Loop for second letter
                {
                    for (int k = 65; k <= 90; k++) // Loop for third letter
                    {
                        Word += (char)i; // Convert ASCII to char and append
                        Word += (char)j;
                        Word += (char)k;

                        Console.WriteLine(Word); // Print the generated word
                        
                        Word = ""; // Reset the word for the next iteration
                    }
                    Console.WriteLine(); // New line for better readability
                }
                Console.WriteLine(); // New line for better readability
            }
        }

        static void Main(string[] args)
        {
            PrintWordsFromAAAtoZZZ();
        }
    }
}
```

## Output Example
The output of this program will be:
```
AAA
AAB
AAC
...
AAZ

ABA
ABB
ABC
...
ABZ

...

ZZA
ZZB
ZZC
...
ZZZ
```

## Key Features
- Uses ASCII values to generate uppercase letters dynamically.
- Efficiently constructs words using nested loops.
- Ensures each word is correctly formatted before printing.

## Improvements in Version 2
- Uses a string variable `Word` to construct each combination before printing.
- Resets `Word` after each iteration to prevent incorrect string concatenation.

## Usage
Compile and run the program in a C# environment, such as Visual Studio or the .NET CLI.

```sh
csc Program.cs  # Compile
Program         # Run
```
This will generate all words from "AAA" to "ZZZ" and print them to the console.

## Author
Developed as part of the `Problem16_version2` series to practice nested loops and string manipulation in C#.


