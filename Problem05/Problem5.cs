namespace Problem5
{
    internal class Problem5
    {

        // Problem #5       (Print Reverse Digits)
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

        static void ReverseDigits(int Number)
        {

            int Remainder;
            while (Number > 0)
            {
                Remainder = Number % 10;
                Number /= 10;
                Console.WriteLine(Remainder);
            }

        }

        static void Main(string[] args)
        {

            ReverseDigits(ReadPositiveNumbers("Enter a Positive Number?"));

        }
    }
}
