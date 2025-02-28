﻿namespace Problem47_version2
{
    // My Round
    internal class Problem47_version2
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

            if (Num > 0)
                return (int)(Num + 0.5);
            else
                return (int)(Num - 0.5);

        }

        static void Main(string[] args)
        {

            float Number = ReadNumber("Enter a Number?");

            Console.WriteLine("\n My Round Result: " + MyRound(Number));

            Console.WriteLine("\n C# Round Result: " + Math.Round(Number));

        }
    }
}