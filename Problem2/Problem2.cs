namespace Problem2
{
    internal class Problem2
    {

        // Problem #2       (Print All Prime Numbers From 1 to N)

        enum enPrimeNotprime { Prime = 1, NotPrime = 2 };

        static int ReadPositiveNumber(string Message)
        {

            int Num;
            do
            {

                Console.WriteLine(Message);
                Num = int.Parse(Console.ReadLine());

            } while (Num <= 0);

            return Num;

        }

        static enPrimeNotprime CheckPrime(int Num)
        {
            // Mathematical rule 
            if (Num == 1)
                return enPrimeNotprime.NotPrime;

            int M = (int)Math.Round((float)Num / 2);
            for (int i = 2; i <= M; i++)
            {

                if (Num % i == 0)
                {
                    return enPrimeNotprime.NotPrime;
                }

            }

            return enPrimeNotprime.Prime;

        }

        static void PrintPrimeNumbersFrom1toN(int N)
        {

            Console.WriteLine("\nPrime Numbers From 1 to " + N + " are :");
            for (int i = 1; i <= N; i++)
            {

                if (CheckPrime(i) == enPrimeNotprime.Prime)
                {

                    Console.WriteLine(i);

                }

            }

        }

        static void Main(string[] args)
        {

            int N = ReadPositiveNumber("Enter a Positive Number ?");

            PrintPrimeNumbersFrom1toN(N);

        }
    }
}