namespace Problem13
{
    // Print Number Pattern
    internal class Problem13
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

        static void PrintNumberpattern(int Num)
        {

            for (int i = 1; i <= Num; i++)
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

            PrintNumberpattern(ReadPositiveNumbers("Enter a Positive Number?"));

        }
    }
}