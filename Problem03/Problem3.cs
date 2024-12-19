namespace Problem3
{
    internal class Problem3
    {

        // Problem #3       (Check Perfect Number)

        static int ReadPositiveNumber(string txt)
        {

            int Num;
            do
            {

                Console.WriteLine(txt);
                Num = int.Parse(Console.ReadLine());

            } while (Num <= 0);

            return Num;

        }

        static bool IsPerfect(int Num)
        {

            int Sum = 0;
            for (int i = 1; i < Num; i++)
            {

                if (Num % i == 0)

                    Sum += i;

            }

            return Num == Sum;

        }

        static void PrintNumberType(int Num)
        {

            if (IsPerfect(Num))
            {
                Console.WriteLine(Num + " is Perfect Number");
            }
            else
            {
                Console.WriteLine(Num + " is Not Perfect Number");
            }

        }

        static void Main(string[] args)
        {

            PrintNumberType(ReadPositiveNumber("Enter a Positive Number?"));

        }
    }
}
