namespace Problem50
{
    // My Sqrt
    internal class Problem50
    {

        static float ReadNumber(string Message)
        {

            float Num = 0;
            Console.WriteLine(Message);
            Num = float.Parse(Console.ReadLine());
            return Num;

        }

        static float MySqrt(float Num)
        {

            return (float)Math.Pow(Num, 0.5);

        }

        static void Main(string[] args)
        {

            float Num = ReadNumber("Enter a Number?");

            Console.WriteLine("\nMySqrt Result: " + MySqrt(Num));

            Console.WriteLine("\nC# Sqrt Result: " + Math.Sqrt(Num));

        }
    }
}