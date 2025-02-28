namespace Problem47
{
    // My Round
    internal class Problem47
    {

        static float ReadNumber(string Message)
        {

            float Num = 0;
            Console.WriteLine(Message);
            Num = float.Parse(Console.ReadLine());
            return Num;

        }

        static float GetFractionPart(float Num)
        {

            return Num - (int)Num;

        }

        static int MyRound(float Num)
        {

            int IntPart = (int)Num;
            float FractionPart = GetFractionPart(Num);

            if (Math.Abs(FractionPart) >= 0.5)
            {

                if (Num > 0)
                {
                    return ++IntPart;
                }
                else
                {
                    return --IntPart;
                }

            }

            return IntPart;

        }

        static void Main(string[] args)
        {

            float Number = ReadNumber("Enter a Number?");

            Console.WriteLine("\n My Round Result: " + MyRound(Number));

            Console.WriteLine("\n C# Round Result: " + Math.Round(Number));

        }
    }
}