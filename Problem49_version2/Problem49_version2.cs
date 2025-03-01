namespace Problem49_version2
{
    // My Ceil
    internal class Problem49_version2
    {

        static float ReadNumber(string Message)
        {

            float Num = 0;
            Console.WriteLine(Message);
            Num = float.Parse(Console.ReadLine());
            return Num;

        }

        static int MyCeil(float Num)
        {

            if (Num != (int)Num)
            {

                if (Num > 0)
                {
                    return (int)Num + 1;
                }

            }

            return (int)Num;

        }

        static void Main(string[] args)
        {

            float Num = ReadNumber("Enter a Number?");

            Console.WriteLine("\nMy Ceil: " + MyCeil(Num));
            Console.WriteLine("\nC# Ceil: " + Math.Ceiling(Num));

        }
    }
}