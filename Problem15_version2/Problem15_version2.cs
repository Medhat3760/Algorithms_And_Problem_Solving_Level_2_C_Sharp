namespace Problem15_version2
{
    // Print Letter Pattern
    internal class Problem15_version2
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

        static void PrintLetterPattern(int Number)
        {
            for (int i = 65; i <= 65 + Number - 1; i++)
            {
                for (int j = 1; j <= i - 65 + 1; j++)
                {
                    Console.Write((char)i);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {

            PrintLetterPattern(ReadPositiveNumbers("Enter a number?"));

        }
    }
}