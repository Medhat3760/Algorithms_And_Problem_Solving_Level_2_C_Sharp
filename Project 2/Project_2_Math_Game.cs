namespace Project_2_Math_Game
{
    internal class Project_2_Math_Game
    {

        enum enQuestionLevel { EasyLevel = 1, MedLevel = 2, HardLevel = 3, MixLevel = 4 }
        enum enOpType { Add = 1, Sub = 2, Mult = 3, Div = 4, MixOp = 5 }

        struct stQuestion
        {

            public int num1;
            public int num2;
            public enQuestionLevel questionLevel;
            public enOpType opType;
            public int playerAnswer;
            public int correctAnswer;
            public bool answerResult;

        }

        struct stQuiz
        {

            public stQuestion[] questionsList;
            public short numberOfQuestions;
            public enQuestionLevel questionLevel;
            public enOpType opType;
            public short numberOfRightAnswer;
            public short numberOfWrongAnswer;
            public bool isPass;

        }

        static short ReadNumberOfQuestions()
        {

            short numberOfQuestions = 0;

            do
            {
                Console.Write("How Many Questions Do You Want To Answer ?");

                numberOfQuestions = short.Parse(Console.ReadLine());

            } while (numberOfQuestions < 1 || numberOfQuestions > 10);

            return numberOfQuestions;

        }

        static enQuestionLevel ReadQuestionsLevel()
        {

            short questionLevel = 0;

            do
            {

                Console.Write("Enter Questions Level: [1] Easy, [2] Med, [3] Hard, [4] Mix ?");
                questionLevel = short.Parse(Console.ReadLine());

            } while (questionLevel < 1 || questionLevel > 4);

            return (enQuestionLevel)questionLevel;

        }

        static enOpType ReadOpType()
        {

            short opType = 0;

            do
            {

                Console.Write("Enter Operation Type: [1] Add, [2] Sub, [3] Mult, [4] Div, [5] Mix ?");
                opType = short.Parse(Console.ReadLine());

            } while (opType < 1 || opType > 5);

            return (enOpType)opType;

        }

        static Random random = new Random();
        static int RandomNumber(int From, int To)
        {

            return random.Next(From, To + 1);

        }

        static int SimpleCalculator(int num1, int num2, enOpType opType)
        {

            switch (opType)
            {

                case enOpType.Add:
                    return num1 + num2;
                case enOpType.Sub:
                    return num1 - num2;
                case enOpType.Mult:
                    return num1 * num2;
                case enOpType.Div:
                    return num1 / num2;
                default:
                    return num1 + num2;

            }

        }

        static stQuestion GenerateQuestion(enQuestionLevel questionLevel, enOpType opType)
        {

            stQuestion question = new stQuestion();

            if (questionLevel == enQuestionLevel.MixLevel)
            {
                questionLevel = (enQuestionLevel)RandomNumber(1, 3);
            }

            question.questionLevel = questionLevel;

            if (opType == enOpType.MixOp)
            {
                opType = (enOpType)RandomNumber(1, 4);
            }

            question.opType = opType;

            switch (question.questionLevel)
            {

                case enQuestionLevel.EasyLevel:
                    question.num1 = RandomNumber(1, 10);
                    question.num2 = RandomNumber(1, 10);
                    break;

                case enQuestionLevel.MedLevel:
                    question.num1 = RandomNumber(10, 50);
                    question.num2 = RandomNumber(10, 50);
                    break;

                case enQuestionLevel.HardLevel:
                    question.num1 = RandomNumber(50, 100);
                    question.num2 = RandomNumber(50, 100);
                    break;

            }

            question.correctAnswer = SimpleCalculator(question.num1, question.num2, question.opType);

            return question;

        }

        static string GetOpTypeSymbol(enOpType opType)
        {

            string[] arrOpType = { "+", "-", "*", "/", "Mix" };

            return arrOpType[(short)opType - 1];

        }

        static int ReadPlayerAnswer()
        {

            int answer = 0;

            answer = int.Parse(Console.ReadLine());

            return answer;

        }

        static void GenerateQuizQuestions(ref stQuiz quiz)
        {

            quiz.questionsList = new stQuestion[quiz.numberOfQuestions];

            for (short questionNumber = 0; questionNumber < quiz.numberOfQuestions; questionNumber++)
            {

                quiz.questionsList[questionNumber] = GenerateQuestion(quiz.questionLevel, quiz.opType);

            }

        }

        static void PrintTheQuestion(stQuiz quiz, short questionNumber)
        {

            Console.WriteLine("\nQuestion [" + (questionNumber + 1) + "/" + quiz.numberOfQuestions + "]\n");
            Console.WriteLine(quiz.questionsList[questionNumber].num1 + "\n" +
                              quiz.questionsList[questionNumber].num2 + " " + GetOpTypeSymbol(quiz.questionsList[questionNumber].opType));
            Console.WriteLine("____________");

        }

        static void SetScreenColor(bool right)
        {

            if (right)
            {

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;


            }
            else
            {

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\a");

            }

        }

        static void CorrectTheQuestionAnswer(ref stQuiz quiz, short questionNumber)
        {

            if (quiz.questionsList[questionNumber].playerAnswer == quiz.questionsList[questionNumber].correctAnswer)
            {

                quiz.questionsList[questionNumber].answerResult = true;
                quiz.numberOfRightAnswer++;
                Console.WriteLine("Right Answer :-)");

            }
            else
            {

                quiz.questionsList[questionNumber].answerResult = false;
                quiz.numberOfWrongAnswer++;
                Console.WriteLine("Wrong Answer :-(");
                Console.WriteLine("The Right Answer is " + quiz.questionsList[questionNumber].correctAnswer);

            }
            Console.WriteLine();

            SetScreenColor(quiz.questionsList[questionNumber].answerResult);

        }

        static void AskAndCorrectQuestionListAnswers(ref stQuiz quiz)
        {

            for (short questionNumber = 0; questionNumber < quiz.numberOfQuestions; questionNumber++)
            {

                PrintTheQuestion(quiz, questionNumber);

                quiz.questionsList[questionNumber].playerAnswer = ReadPlayerAnswer();

                CorrectTheQuestionAnswer(ref quiz, questionNumber);

            }

            quiz.isPass = (quiz.numberOfRightAnswer >= quiz.numberOfWrongAnswer);

        }

        static string GetFinalResultText(bool pass)
        {

            if (pass)
            {
                return "Pass :-)";
            }
            else
            {
                return "Fail :-(";
            }

        }

        static string GetQuestionLevelText(enQuestionLevel questionLevel)
        {

            string[] arrQuestionLevelText = { "Easy", "Med", "Hard", "Mix" };

            return arrQuestionLevelText[(short)questionLevel - 1];

        }

        static void PrintFinalResult(stQuiz quiz)
        {

            SetScreenColor(quiz.isPass);

            Console.WriteLine("\n__________________________________\n");
            Console.WriteLine("Final Result is " + GetFinalResultText(quiz.isPass));
            Console.WriteLine("__________________________________\n");

            Console.WriteLine("Number Of Questions    : " + quiz.numberOfQuestions);
            Console.WriteLine("Questions Level        : " + GetQuestionLevelText(quiz.questionLevel));
            Console.WriteLine("Operation Type         : " + GetOpTypeSymbol(quiz.opType));
            Console.WriteLine("Number Of Right Answers: " + quiz.numberOfRightAnswer);
            Console.WriteLine("Number Of Wrong Answers: " + quiz.numberOfWrongAnswer);
            Console.WriteLine("__________________________________\n");

        }

        static void ResetScreen()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

        }

        static void PlayMathGame()
        {

            stQuiz quiz = new stQuiz();

            quiz.numberOfQuestions = ReadNumberOfQuestions();
            quiz.questionLevel = ReadQuestionsLevel();
            quiz.opType = ReadOpType();

            GenerateQuizQuestions(ref quiz);

            AskAndCorrectQuestionListAnswers(ref quiz);

            PrintFinalResult(quiz);

        }

        static void StartGame()
        {

            char playAgain = 'Y';

            do
            {

                ResetScreen();

                PlayMathGame();

                Console.WriteLine("Do You Want To Play Again ? Y/N");
                playAgain = char.Parse(Console.ReadLine());

            } while (playAgain == 'y' || playAgain == 'Y');

        }


        static void Main(string[] args)
        {

            StartGame();

        }
    }
}