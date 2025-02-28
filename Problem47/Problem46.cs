namespace Problem46
{
    // My ABS
    internal class Problem46
    {

        static float ReadNumber(string Message)
        {

            float Num = 0;
            Console.WriteLine(Message);
            Num = float.Parse(Console.ReadLine());
            return Num;

        }

        static float MyAbs(float num)
        {

            if (num < 0)
            {

                return num * -1;
               
            }

            return num;
        }

        static void Main(string[] args)
        {

            float Num = ReadNumber("Enter a Number?");

            Console.WriteLine("\nMy Abs Result: " + MyAbs(Num));

            Console.WriteLine("\nC# Abs Result: " + Math.Abs(Num));

        }
    }
}