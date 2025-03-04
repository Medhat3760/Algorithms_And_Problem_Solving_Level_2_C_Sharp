namespace Project_1_Stone__Paper__Scissors
{
    // Rock Paper Scissors Game
    internal class Project_1_Stone__Paper__Scissors
    {

        enum enGameChoice { Stone = 1, Paper = 2, Scissors = 3 }

        enum enWinner { Player = 1, Computer = 2, Draw = 3 }

        struct stGameResults
        {

            public short gameRounds;
            public short playerWonTimes;
            public short computerWonTimes;
            public short drawTimes;
            public enWinner gameWinner;
            public string winnerName;

        }

        struct stRoundInfo
        {

            public short roundNumber;
            public enGameChoice playerChoice;
            public enGameChoice computerChoice;
            public enWinner Winner;
            public string winnerName;

        }

        static Random random = new Random();
        static int RandomNumber(int From, int To)
        {

            int randNum = random.Next(From, To + 1);

            return randNum;
        }

        static short ReadHowManyRounds()
        {

            short gameRounds = 0;
            do
            {

                Console.Write("How Many Rounds 1 to 10 ?");
                gameRounds = short.Parse(Console.ReadLine());

            } while (gameRounds < 1 || gameRounds > 10);

            return gameRounds;
        }

        static enGameChoice ReadPlayerChoice()
        {
            short choice = 1;
            do
            {

                Console.WriteLine("Your Choice: [1]:Stone [2]:Paper [3]:Scissors ?");
                choice = short.Parse(Console.ReadLine());

            } while (choice < 1 || choice > 3);

            return (enGameChoice)choice;
        }

        static enGameChoice GetComputerChoice()
        {

            return (enGameChoice)RandomNumber(1, 3);

        }

        static enWinner WhoWonTheRound(stRoundInfo roundInfo)
        {

            if (roundInfo.playerChoice == roundInfo.computerChoice)
            {

                return enWinner.Draw;

            }

            switch (roundInfo.playerChoice)
            {

                case enGameChoice.Stone:
                    if (roundInfo.computerChoice == enGameChoice.Paper)
                        return enWinner.Computer;
                    break;
                case enGameChoice.Paper:
                    if (roundInfo.computerChoice == enGameChoice.Scissors)
                        return enWinner.Computer;
                    break;
                case enGameChoice.Scissors:
                    if (roundInfo.computerChoice == enGameChoice.Stone)
                        return enWinner.Computer;
                    break;

            }

            return enWinner.Player;
        }

        static enWinner WhoWonTheGame(short playerWinTimes, short computerWinTimes)
        {

            if (playerWinTimes > computerWinTimes)
            {
                return enWinner.Player;
            }
            else if (computerWinTimes > playerWinTimes)
            {
                return enWinner.Computer;
            }
            else
            {
                return enWinner.Draw;
            }

        }

        static string ChoiceName(enGameChoice choice)
        {

            string[] arrChoiceName = { "Stone", "Paper", "Scissors" };

            return arrChoiceName[(short)choice - 1];

        }

        static string WinnerName(enWinner winner)
        {

            string[] arrWinnerName = { "Player", "Computer", "Draw" };

            return arrWinnerName[(short)winner - 1];

        }

        static void SetScreenColor(enWinner winner)
        {

            switch (winner)
            {

                case enWinner.Player:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                case enWinner.Computer:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.Write("\a");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;

            }

        }

        static void PrintRoundResult(stRoundInfo roundInfo)
        {
            SetScreenColor(roundInfo.Winner);

            Console.WriteLine("\nــــــــــــــــــــــRound [" + roundInfo.roundNumber + "]ــــــــــــــــــــــ\n");
            Console.WriteLine("Player Choice  : " + ChoiceName(roundInfo.playerChoice));
            Console.WriteLine("Computer Choice: " + ChoiceName(roundInfo.computerChoice));
            Console.WriteLine("Round Winner   : [" + roundInfo.winnerName + "]");
            Console.WriteLine("ـــــــــــــــــــــــــــــــــــــــــــــــــــــ\n");

        }

        static stGameResults FillGameResults(short howManyRounds, short playerWinTimes, short computerWinTimes, short drawTimes)
        {

            stGameResults gameResults;

            gameResults.gameRounds = howManyRounds;
            gameResults.playerWonTimes = playerWinTimes;
            gameResults.computerWonTimes = computerWinTimes;
            gameResults.drawTimes = drawTimes;
            gameResults.gameWinner = WhoWonTheGame(playerWinTimes, computerWinTimes);
            gameResults.winnerName = WinnerName(gameResults.gameWinner);

            return gameResults;
        }

        static stGameResults PlayGame(short howManyRounds)
        {

            stRoundInfo roundInfo = new stRoundInfo();

            short playerWinsTimes = 0, computerWinsTimes = 0, drawTimes = 0;

            for (short gameRound = 1; gameRound <= howManyRounds; gameRound++)
            {

                Console.WriteLine("\nRound [" + gameRound + "] Begins: ");
                roundInfo.roundNumber = gameRound;
                roundInfo.playerChoice = ReadPlayerChoice();
                roundInfo.computerChoice = GetComputerChoice();
                roundInfo.Winner = WhoWonTheRound(roundInfo);
                roundInfo.winnerName = WinnerName(roundInfo.Winner);

                switch (roundInfo.Winner)
                {

                    case enWinner.Player:
                        playerWinsTimes++;
                        break;
                    case enWinner.Computer:
                        computerWinsTimes++;
                        break;
                    default:
                        drawTimes++;
                        break;

                }

                PrintRoundResult(roundInfo);

            }

            return FillGameResults(howManyRounds, playerWinsTimes, computerWinsTimes, drawTimes);

        }

        static string Tabs(short numberOfTabs)
        {

            string tabs = "";

            for (short i = 1; i <= numberOfTabs; i++)
            {

                tabs += "\t";

            }

            return tabs;

        }

        static void ShowGameOverScreen()
        {

            Console.WriteLine(Tabs(2) + "ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ\n");
            Console.WriteLine(Tabs(4) + "+++ G a m e  O v e r +++\n");
            Console.WriteLine(Tabs(2) + "ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ\n");

        }

        static void ShowGameResults(stGameResults gameResults)
        {

            SetScreenColor(gameResults.gameWinner);

            ShowGameOverScreen();

            Console.WriteLine(Tabs(2) + "ــــــــــــــــــــــــ [Game Results] ــــــــــــــــــــــــ\n");
            Console.WriteLine(Tabs(2) + "Game Rounds       : " + gameResults.gameRounds);
            Console.WriteLine(Tabs(2) + "Player Won Times  : " + gameResults.playerWonTimes);
            Console.WriteLine(Tabs(2) + "Computer Won Times: " + gameResults.computerWonTimes);
            Console.WriteLine(Tabs(2) + "Draw Times        : " + gameResults.drawTimes);
            Console.WriteLine(Tabs(2) + "Final Winner      : [" + gameResults.winnerName + "]");
            Console.WriteLine(Tabs(2) + "ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ\n");

        }

        static void ResetScreen()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

        }

        static void StartGame()
        {

            char playAgain = 'y';

            do
            {

                ResetScreen();

                stGameResults gameResults = PlayGame(ReadHowManyRounds());

                ShowGameResults(gameResults);

                Console.WriteLine("Do You Want To Play Again? Y/N");
                playAgain = char.Parse(Console.ReadLine());

            } while (playAgain == 'y' || playAgain == 'Y');

        }

        static void Main(string[] args)
        {

            StartGame();

        }
    }
}