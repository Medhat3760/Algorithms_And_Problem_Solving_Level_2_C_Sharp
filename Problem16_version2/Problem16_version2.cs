namespace Problem16_version2
{
    // Print Words From AAA to ZZZ
    internal class Problem16_version2
    {

        static void PrintWordsFromAAAtoZZZ()
        {

            string Word = "";

            for (int i = 65; i <= 90; i++)
            {

                for (int j = 65; j <= 90; j++)
                {

                    for (int k = 65; k <= 90; k++)
                    {

                        Word += (char)i;
                        Word += (char)j;
                        Word += (char)k;

                        Console.WriteLine(Word);

                        Word = "";

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