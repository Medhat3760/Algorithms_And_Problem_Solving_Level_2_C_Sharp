namespace Problem8
{
    internal class Problem8
    {

        // Problem #8       (Digit Frequency)

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

        static int CountDigitFrequancy(short DigitToCheck, int Number)
        {

            int Remainder = 0, FreqCount = 0;

            while (Number > 0)
            {

                Remainder = Number % 10;
                Number /= 10;

                if (DigitToCheck == Remainder)
                {

                    FreqCount++;

                }

            }

            return FreqCount;

        }

        static void Main(string[] args)
        {

            int Number = ReadPositiveNumber("Please enter the main number?");
            short DigitToCheck = (short)ReadPositiveNumber("Please enter one digit to check?");


            Console.WriteLine("\nDigit " + DigitToCheck + " Frequancy is " +
                               CountDigitFrequancy(DigitToCheck, Number) + " Time(s).");

        }
    }
}