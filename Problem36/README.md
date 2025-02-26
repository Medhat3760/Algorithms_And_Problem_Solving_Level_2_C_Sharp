# Problem36 - Add Array Element Semi-Dynamic

## Description
This C# console application allows users to dynamically add elements to an array. The user is prompted to enter numbers, which are stored in the array. The process continues until the user chooses to stop.

## Features
- Read numbers from the user.
- Store numbers in an array dynamically.
- Allow users to continue adding numbers or stop at any time.
- Display the array length and its elements after input completion.

## Code Explanation

### 1. **ReadNumber Method**
```csharp
static int ReadNumber(string Message)
```
- Prompts the user with a message and reads an integer input.

### 2. **ReadNumberInRange Method**
```csharp
static int ReadNumberInRange(int From, int To, string Message)
```
- Ensures that user input is within a specified range.
- Keeps prompting the user until a valid input is received.

### 3. **DoMore Method**
```csharp
static bool DoMore()
```
- Asks the user whether they want to add more numbers.
- Returns `true` if the user chooses to continue, otherwise `false`.

### 4. **AddArrayElement Method**
```csharp
static void AddArrayElement(int Number, int[] arr, ref int arrLength)
```
- Adds a new number to the array.
- Increments the array length.

### 5. **InputUserNumbersInArray Method**
```csharp
static void InputUserNumbersInArray(int[] arr, ref int arrLength)
```
- Calls `ReadNumber` to take user input.
- Uses `AddArrayElement` to store the input in the array.
- Repeats the process until the user chooses to stop.

### 6. **PrintArray Method**
```csharp
static void PrintArray(int[] arr, int arrLength)
```
- Prints all elements stored in the array.

### 7. **Main Method**
```csharp
static void Main(string[] args)
```
- Initializes an integer array of size 100.
- Calls `InputUserNumbersInArray` to populate the array.
- Displays the array length and its elements.

## Sample Output
```
Enter a Number To Store Them In Array? 5
Do You Want To Add More Numbers? [0]No,[1]Yes? 1
Enter a Number To Store Them In Array? 10
Do You Want To Add More Numbers? [0]No,[1]Yes? 0

Array Length: 2
Array Elements: 5 10 
```

## Notes
- The array size is fixed at 100, meaning it cannot store more than 100 numbers.
- The user must enter valid integer values.
- The program ensures proper input validation before adding values.

