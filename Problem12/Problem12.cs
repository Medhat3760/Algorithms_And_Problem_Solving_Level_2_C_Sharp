namespace Problem12
{
    // Inverted Number Pattern
    internal class Problem12
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

        static void PrintInvertedNumberPattern(int Number)
        {

            for (int i = Number; i >= 1; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();

            }

        }

        static void Main(string[] args)
        {

            PrintInvertedNumberPattern(ReadPositiveNumbers("Enter a Positive Number?"));

        }
    }
}
