namespace Problem12
{
    // Reverse Number
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

        static void Main(string[] args)
        {

            Console.WriteLine("Reverse Number is :\n" +
                              ReverseNumber(ReadPositiveNumbers("Entre a Positive Number?")));

        }
    }
}