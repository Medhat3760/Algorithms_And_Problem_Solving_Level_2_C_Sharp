namespace Problem11
{
    // Check Palindrome Number
    internal class Problem11
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

        static bool isPalindromNumber(int Number)
        {

            return Number == ReverseNumber(Number);

        }

        static void PrintResult(int Number)
        {

            if (isPalindromNumber(Number))
            {
                Console.WriteLine("\n yes, its a Palindrome Number");
            }
            else
            {
                Console.WriteLine("\n NO, its Not a Palindrome Number");
            }

        }

        static void Main(string[] args)
        {

            PrintResult(ReadPositiveNumbers("Enter The Number that You Want to Check if its Palindrom?"));

        }
    }
}