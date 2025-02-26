# Problem35 - Check Number In Array

## Description
This C# program generates an array of random numbers and checks whether a specified number exists within the array. It prompts the user to enter the number of elements for the array, fills the array with random numbers, and then allows the user to check if a specific number is present.

## Features
- Reads a positive integer from the user to determine the array size.
- Fills the array with random numbers ranging from 1 to 100.
- Displays the generated array.
- Accepts a number from the user to check for its presence in the array.
- Uses a helper function to search for the number and returns whether it is found.

## Code Structure
### 1. **ReadPositiveNumber**
   - Reads a positive integer from the user.
   - Ensures the input is greater than 0.

### 2. **RandomNumberInRange**
   - Generates a random number between a given range.

### 3. **FillArrayWithRandomNumbers**
   - Fills an array with random numbers between 1 and 100.

### 4. **PrintArray**
   - Prints the contents of the array.

### 5. **FindNumberPositionInArray**
   - Searches for a given number in the array.
   - Returns the index if found, otherwise returns -1.

### 6. **IsNumberInArray**
   - Uses `FindNumberPositionInArray` to check if a number exists in the array.

### 7. **Main Function**
   - Reads user input for array length.
   - Generates the array with random values.
   - Displays the array.
   - Prompts the user to enter a number to search for.
   - Uses `IsNumberInArray` to check for the number's existence and displays the result.

## Example Output
```
Enter Number Of Elements? 10

Array1 Elements:
23 67 12 89 45 90 34 56 78 11

Enter a Number To Check? 45

Number you are looking for is: 45
Yes, Number is Found :-)
```

## Usage
1. Compile and run the program in a C# development environment.
2. Follow the prompts to enter the array size and the number to check.
3. View the generated array and whether the number is found.

## Notes
- The array size must be a positive integer.
- Random values are between 1 and 100.
- The search is linear, meaning it checks each element one by one.

