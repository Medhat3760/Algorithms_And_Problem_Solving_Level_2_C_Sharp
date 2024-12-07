namespace Problem6
{
    internal class Problem6
    {

        // Problem #6       (Sum Of Digits)

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

        static int SumOfDigits(int Number)
        {

            int Remainder;
            int Sum = 0;
            while (Number > 0)
            {

                Remainder = Number % 10;
                Number /= 10;
                Sum += Remainder;

            }
            return Sum;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Sum Of Digits = " + SumOfDigits(ReadPositiveNumbers("Enter a Positive Number?")));

        }
    }
}