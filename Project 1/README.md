# Rock Paper Scissors - C# Console Game

## Description

This is a console-based Rock Paper Scissors game implemented in C#. The game allows the player to compete against the computer in multiple rounds and determines a final winner based on the number of rounds won.

## Features

- The player can choose the number of rounds (1 to 10).
- The player selects their move (Stone, Paper, or Scissors).
- The computer randomly selects its move.
- The winner of each round is determined based on standard game rules.
- A final winner is declared after all rounds are played.
- The game can be replayed multiple times.
- The console background color changes based on the winner of each round and the game result.

## Code Explanation

### 1. **Enumerations**

```csharp
enum enGameChoice { Stone = 1, Paper = 2, Scissors = 3 }
enum enWinner { Player = 1, Computer = 2, Draw = 3 }
```
- `enGameChoice` represents the choices available: Stone, Paper, or Scissors.
- `enWinner` represents the round and game winner.

### 2. **Structures**

```csharp
struct stGameResults
struct stRoundInfo
```
- `stGameResults` stores the results of the game, including the number of rounds and wins for each player.
- `stRoundInfo` holds details for each round, including choices and the round winner.

### 3. **Methods**

#### **Game Setup and Input Handling**

- `ReadHowManyRounds()`: Prompts the user to enter the number of rounds.
- `ReadPlayerChoice()`: Reads and validates the player's choice.
- `GetComputerChoice()`: Generates a random move for the computer.

#### **Game Logic**

- `WhoWonTheRound(stRoundInfo roundInfo)`: Determines the winner of a single round.
- `WhoWonTheGame(short playerWinTimes, short computerWinTimes)`: Determines the final game winner.

#### **Utility Functions**

- `ChoiceName(enGameChoice choice)`: Converts an enum choice into a string.
- `WinnerName(enWinner winner)`: Converts an enum winner into a string.
- `SetScreenColor(enWinner winner)`: Changes the console background color based on the winner.
- `PrintRoundResult(stRoundInfo roundInfo)`: Displays the results of a single round.
- `ShowGameResults(stGameResults gameResults)`: Displays the final game results.

#### **Game Flow Control**

- `PlayGame(short howManyRounds)`: Manages the game rounds and tracks scores.
- `StartGame()`: Handles the main game loop, including replay functionality.

### 4. **Main Method**

```csharp
static void Main(string[] args)
```
- Calls `StartGame()` to begin the game loop.

## Example Gameplay Output

```
How Many Rounds 1 to 10 ? 3

Round [1] Begins:
Your Choice: [1]:Stone [2]:Paper [3]:Scissors ? 1

Player Choice  : Stone
Computer Choice: Scissors
Round Winner   : [Player]

Round [2] Begins:
Your Choice: [1]:Stone [2]:Paper [3]:Scissors ? 2

Player Choice  : Paper
Computer Choice: Paper
Round Winner   : [Draw]

Round [3] Begins:
Your Choice: [1]:Stone [2]:Paper [3]:Scissors ? 3

Player Choice  : Scissors
Computer Choice: Stone
Round Winner   : [Computer]

Final Winner: [Player]
Do You Want To Play Again? Y/N
```

## How to Run

1. Copy and paste the C# code into a `.cs` file.
2. Compile and run the program using a C# compiler or an IDE like Visual Studio.
3. Follow the on-screen instructions to play.

## Conclusion

This project demonstrates fundamental C# programming concepts, including:
- **User input handling**
- **Random number generation**
- **Enumerations and structures**
- **Looping and conditional statements**
- **Modular function-based approach**

Enjoy playing Rock Paper Scissors! 🎮


