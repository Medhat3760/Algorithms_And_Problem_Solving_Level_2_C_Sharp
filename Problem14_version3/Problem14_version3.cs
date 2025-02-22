namespace Problem14_version3
{
    // Print Inverted Letter Pattern
    internal class Problem14_version3
    {

        static int ReadPositiveNumbers(string Message)
        {

            int Num;
            do
            {

                Console.WriteLine(Message);
                Num = int.Parse(Console.ReadLine());

            } while (Num <= 0);

            return Num;

        }

        static void PrintInvertedLetterPattern(int Number)
        {

            for (int i = Number; i >= 1; i--)
            {

                for (int j = 1; j <= i; j++)
                {

                    Console.Write((char)(64 + i));

                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {

            PrintInvertedLetterPattern(ReadPositiveNumbers("Enter a number?"));

        }
    }
}