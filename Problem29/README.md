# Problem29: Copy Only Prime Numbers

## Overview
This C# program generates an array of random numbers, filters out only the prime numbers, and stores them in another array. The program then prints both the original array and the array containing only prime numbers.

## Features
- Generates an array with random numbers.
- Filters and copies only prime numbers to a new array.
- Displays both the original and the filtered arrays.

## How It Works
1. **ReadPositiveNumber:** Ensures the user inputs a positive integer.
2. **RandomNumber:** Generates random numbers within a given range.
3. **FillArrayWithRandomNumbers:** Populates an array with random numbers.
4. **CheckPrime:** Determines whether a number is prime.
5. **CopyOnlyPrimeNumbers:** Copies only prime numbers to a new array.
6. **PrintArray:** Displays an array’s contents.
7. **Main Method:**
   - Creates and fills an array with random numbers.
   - Copies only the prime numbers into another array.
   - Prints both arrays.

## Code Explanation
### Prime Number Check
The `CheckPrime` function iterates up to half of the given number (rounded) to determine if it is divisible by any number other than 1 and itself.
```csharp
static enPrimeNotPrime CheckPrime(int Num)
{
    if (Num <= 1)
        return enPrimeNotPrime.NotPrime;
    
    int M = (int)Math.Round((float)Num / 2);
    for (int i = 2; i <= M; i++)
    {
        if (Num % i == 0)
            return enPrimeNotPrime.NotPrime;
    }
    return enPrimeNotPrime.Prime;
}
```

### Copying Prime Numbers
The `CopyOnlyPrimeNumbers` function iterates through the source array and copies only the prime numbers into the destination array.
```csharp
static void CopyOnlyPrimeNumbers(int[] arrSource, int[] arrDestination, int arrLength, ref int arr2Length)
{
    int Counter = 0;
    for (int i = 0; i < arrLength; i++)
    {
        if (CheckPrime(arrSource[i]) == enPrimeNotPrime.Prime)
        {
            arrDestination[Counter] = arrSource[i];
            Counter++;
        }
    }
    arr2Length = Counter;
}
```

## Sample Output
```
Enter Number of Elements? 10

Array Elements:
23 45 11 67 89 90 34 2 13 17

Array 2 Prime Numbers:
23 11 67 89 2 13 17
```

## Requirements
- C# Compiler (.NET Core or .NET Framework)
- Console Application

## How to Run
1. Compile the program using a C# compiler.
2. Run the executable and enter the number of elements.
3. Observe the output in the console.

## Conclusion
This program efficiently filters prime numbers from a randomly generated array, demonstrating fundamental C# programming concepts such as loops, functions, arrays, and conditional logic.
