namespace Problem10
{
    internal class Problem10
    {

        // Problem #10      (Print Digits in Order)

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

        static int ReverseNumber(int Number)
        {

            int Remainder = 0, Number2 = 0;
            while (Number > 0)
            {

                Remainder = Number % 10;
                Number /= 10;
                Number2 = Number2 * 10 + Remainder;

            }

            return Number2;

        }

        static void PrintDigits(int ReversedNumber)
        {
            int Remainder = 0;
            while (ReversedNumber > 0)
            {

                Remainder = ReversedNumber % 10;
                ReversedNumber /= 10;
                Console.WriteLine(Remainder);

            }

        }

        static void Main(string[] args)
        {

            PrintDigits(ReverseNumber(ReadPositiveNumbers("Enter Main Number?")));

        }
    }
}