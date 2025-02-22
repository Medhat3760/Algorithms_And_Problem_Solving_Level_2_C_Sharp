namespace Problem16
{
    // Print Words From AAA to ZZZ
    internal class Problem16
    {

        static void PrintWordsFromAAAtoZZZ()
        {

            for (int i = 65; i <= 90; i++)
            {

                for (int j = 65; j <= 90; j++)
                {

                    for (int k = 65; k <= 90; k++)
                    {

                        Console.WriteLine((char)i + "" + (char)j + "" + (char)k);

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {

            PrintWordsFromAAAtoZZZ();

        }
    }
}