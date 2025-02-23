namespace Problem17
{
    // Guess a 3-Letter Password
    internal class Problem17
    {

        static string ReadPassWord(string Message)
        {

            string Pass = "";
            Console.WriteLine(Message);
            Pass = Console.ReadLine();
            return Pass;

        }

        static bool GuessPasswordFromAAAtoZZZ(string Pass)
        {

            Console.WriteLine();

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
                    Console.WriteLine();

                }
                Console.WriteLine();

            }

            return false;

        }

        static void Main(string[] args)
        {

            GuessPasswordFromAAAtoZZZ(ReadPassWord("Enter a 3-Letter Password (all capital)?"));

        }
    }
}