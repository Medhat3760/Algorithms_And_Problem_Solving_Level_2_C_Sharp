namespace Problem4
{
    internal class Problem4
    {

        // Problem #4       (Print Perfect Number From 1 to N)

        static int ReadPositiveNumber(string message)
        {

            int Num;
            do
            {

                Console.WriteLine(message);
                Num = int.Parse(Console.ReadLine());

            } while (Num <= 0);

            return Num;

        }

        static bool IsPerfectNumber(int Num)
        {

            int Sum = 0;
            int M = Num / 2;
            for (int i = 1; i <= M; i++)
            {

                if (Num % i == 0)
                    Sum += i;

            }

            return Sum == Num;

        }

        static void PrintPerfectNumbersFrom1toN(int N)
        {
            Console.WriteLine("Perfect Numbers From 1 to " + N + " are:\n");
            for (int i = 1; i <= N; i++)
            {

                if (IsPerfectNumber(i))

                    Console.WriteLine(i);

            }

        }

        static void Main(string[] args)
        {

            PrintPerfectNumbersFrom1toN(ReadPositiveNumber("Enter a Positive Number?"));

        }
    }
}