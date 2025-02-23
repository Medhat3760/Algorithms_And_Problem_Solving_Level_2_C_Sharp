# Guess a 3-Letter Password ( Problem17 )

## Overview
This C# program attempts to guess a 3-letter uppercase password by iterating through all possible combinations from "AAA" to "ZZZ". It uses a brute-force approach and counts the number of attempts required to find the correct password.

## How It Works
1. The program prompts the user to enter a 3-letter password (consisting of uppercase letters A-Z).
2. It then generates all possible 3-letter combinations and compares each with the entered password.
3. Each attempt is displayed on the console with a trial number.
4. If a match is found, the program prints the correct password along with the number of trials taken to find it.

## Code Breakdown
### 1. **Reading the Password**
```csharp
static string ReadPassWord(string Message)
{
    Console.WriteLine(Message);
    return Console.ReadLine();
}
```
- This function prompts the user to enter a 3-letter password and returns it as a string.

### 2. **Brute Force Guessing Function**
```csharp
static bool GuessPasswordFromAAAtoZZZ(string Pass)
{
    int Counter = 0;
    string Word = "";

    for (int i = 65; i <= 90; i++)
    {
        for (int j = 65; j <= 90; j++)
        {
            for (int k = 65; k <= 90; k++)
            {
                Counter++;
                Word += (char)i;
                Word += (char)j;
                Word += (char)k;
                Console.WriteLine("Trial [" + Counter + "]: " + Word);

                if (Word == Pass)
                {
                    Console.WriteLine("\nPassword is " + Pass);
                    Console.WriteLine("Found After " + Counter + " Trial(s)");
                    return true;
                }
                Word = "";
            }
        }
    }
    return false;
}
```
- This function generates all possible 3-letter uppercase combinations using nested loops.
- It keeps track of the number of attempts using `Counter`.
- Each generated word is compared with the user-provided password.
- If a match is found, the program stops and displays the password and number of attempts.

### 3. **Main Function**
```csharp
static void Main(string[] args)
{
    GuessPasswordFromAAAtoZZZ(ReadPassWord("Enter a 3-Letter Password (all capital)?"));
}
```
- The `Main` method calls `ReadPassWord` to get user input and then calls `GuessPasswordFromAAAtoZZZ` to attempt to find the password.

## Example Output
```
Enter a 3-Letter Password (all capital)?
XYZ

Trial [1]: AAA
Trial [2]: AAB
...
Trial [17576]: XYZ

Password is XYZ
Found After 17576 Trial(s)
```

## Complexity Analysis
- The program performs a brute-force search with a time complexity of **O(26³) = O(17576)**, where 26 is the number of uppercase letters.
- This approach is inefficient for larger password lengths but works within a reasonable time for 3-letter passwords.

## Possible Enhancements
- Allow mixed-case passwords.
- Support for numeric and special character passwords.
- Implement a more efficient password-guessing algorithm (e.g., dictionary attacks).

## Conclusion
This program demonstrates a simple brute-force password guessing approach using nested loops. While effective for short passwords, it highlights the impracticality of brute-force attacks on longer passwords.


