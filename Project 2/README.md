# Math Quiz Game

## Overview
This is a simple console-based Math Quiz Game written in C#. The game allows users to answer randomly generated math questions based on a chosen difficulty level and operation type. The game tracks the user's performance and displays the final result.

## Features
- Choose the number of questions (1-10)
- Select difficulty level: Easy, Medium, Hard, or Mixed
- Choose the type of mathematical operation: Addition, Subtraction, Multiplication, Division, or Mixed
- Randomized questions based on user selection
- Tracks right and wrong answers
- Displays final quiz results
- Option to replay the game

## Game Flow
1. The game asks the user how many questions they want to answer.
2. The user selects the difficulty level.
3. The user selects the type of mathematical operation.
4. The game generates random questions based on the selected settings.
5. The user inputs their answer.
6. The game checks the answer and provides feedback.
7. At the end of the quiz, the game displays the total correct and incorrect answers and determines whether the user passes or fails.
8. The user is given the option to play again.

## Code Structure
### Enumerations
- `enQuestionLevel`: Defines the difficulty levels (Easy, Medium, Hard, Mixed).
- `enOpType`: Defines the types of operations (Add, Subtract, Multiply, Divide, Mixed).

### Structures
- `stQuestion`: Stores information about a single question (numbers, operation, user answer, correct answer, and result).
- `stQuiz`: Stores information about the quiz, including a list of questions, correct/wrong answers, and the final result.

### Main Functions
- `ReadNumberOfQuestions()`: Reads the number of questions from the user.
- `ReadQuestionsLevel()`: Reads the chosen difficulty level.
- `ReadOpType()`: Reads the chosen mathematical operation.
- `RandomNumber(int From, int To)`: Generates a random number within a given range.
- `SimpleCalculator(int num1, int num2, enOpType opType)`: Performs basic arithmetic operations.
- `GenerateQuestion(enQuestionLevel questionLevel, enOpType opType)`: Generates a single random math question.
- `GenerateQuizQuestions(ref stQuiz quiz)`: Populates the quiz with generated questions.
- `PrintTheQuestion(stQuiz quiz, short questionNumber)`: Displays the current question.
- `ReadPlayerAnswer()`: Reads and returns the user's answer.
- `CorrectTheQuestionAnswer(ref stQuiz quiz, short questionNumber)`: Checks if the answer is correct and updates quiz stats.
- `AskAndCorrectQuestionListAnswers(ref stQuiz quiz)`: Loops through all quiz questions, presenting them to the user.
- `PrintFinalResult(stQuiz quiz)`: Displays the user's final results.
- `ResetScreen()`: Resets console colors and clears the screen.
- `PlayMathGame()`: Handles the full game flow.
- `StartGame()`: Manages replaying the game.
- `Main()`: Entry point of the application.

## How to Run
1. Compile the C# code using a C# compiler or run it in Visual Studio.
2. Execute the program in a console window.
3. Follow the on-screen prompts to play the game.

## Example Gameplay
```
How Many Questions Do You Want To Answer? 3
Enter Questions Level: [1] Easy, [2] Med, [3] Hard, [4] Mix? 1
Enter Operation Type: [1] Add, [2] Sub, [3] Mult, [4] Div, [5] Mix? 1

Question [1/3]
4
5 +
____________
Your Answer: 9
Right Answer :-)

Question [2/3]
3
2 +
____________
Your Answer: 5
Right Answer :-)

Question [3/3]
8
1 +
____________
Your Answer: 10
Wrong Answer :-(
The Right Answer is 9

Final Result is Pass :-)
```


