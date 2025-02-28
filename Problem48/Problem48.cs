namespace Problem48
{
    // My Floor
    internal class Problem48
    {

        static float ReadNumber(string Message)
        {

            float Num = 0;
            Console.WriteLine(Message);
            Num = float.Parse(Console.ReadLine());
            return Num;

        }

        static int MyFloor(float Num)
        {

            if (Num > 0)
            {
                return (int)Num;
            }

            return (int)--Num;
        }

        static void Main(string[] args)
        {

            float Num = ReadNumber("Enter a Number?");

            Console.WriteLine("\nMy Floor: " + MyFloor(Num));
            Console.WriteLine("\nC# Floor: " + Math.Floor(Num));

        }
    }
}