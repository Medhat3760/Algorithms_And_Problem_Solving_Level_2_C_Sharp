namespace Problem14_version2
{
    // Print Inverted Letter Pattern
    internal class Problem14_version2
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

            for (int i = 65 + Number - 1; i >= 65; i--)
            {

                for (int j = 1; j <= Number - (65 + Number - 1 - i); j++)
                {

                    Console.Write((char)i);

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