namespace Problem9
{
    internal class Problem9
    {

        // Problem #9       (All Digits Frequency)
        
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

        static void PrintAllDigitsFrequency(int Number)
        {

            int DigitFrequency = 0;

            for (short i = 0; i <= 9; i++)
            {

                DigitFrequency = CountDigitFrequancy(i, Number);

                if (DigitFrequency > 0)
                {

                    Console.WriteLine("Digit " + i + " Frequency is " + DigitFrequency + " Time(s)");

                }

            }

        }
        

        static void Main(string[] args)
        {

            PrintAllDigitsFrequency(ReadPositiveNumber("Enter The Main Number?"));

        }
    }
}
