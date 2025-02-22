namespace Problem15_version3
{
    // Print Letter Pattern
    internal class Problem15_version3
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

        static void PrintLetterPattern(int Number)
        {

            for (int i = 1; i <= Number; i++)
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

            PrintLetterPattern(ReadPositiveNumbers("Enter a number?"));

        }
    }
}