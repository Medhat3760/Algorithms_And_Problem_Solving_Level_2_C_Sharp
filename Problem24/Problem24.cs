namespace Problem24
{
    // Max Number Of Array
    internal class Problem24
    {

        static int ReadPositiveNumber(string Message)
        {

            int Num;
            do
            {

                Console.WriteLine(Message);
                Num = int.Parse(Console.ReadLine());

            } while (Num <= 0);
            return Num;
        }

        static Random random = new Random();

        static int RandomNumber(int From, int To)
        {

            int RandNum = random.Next(From, To + 1);
            return RandNum;

        }

        static void FillArrayWithRandomNumbers(int[] Arr, ref int Length)
        {

            Length = ReadPositiveNumber("Enter How Many items you Want To Fill?");

            for (int i = 0; i < Length; i++)
            {

                Arr[i] = RandomNumber(1, 100);

            }

        }

        static void PrintArray(int[] Arr, int Length)
        {

            for (int i = 0; i < Length; i++)
            {

                Console.Write(Arr[i] + " ");

            }
            Console.WriteLine();
        }

        static int MaxNumberOfArray(int[] Arr, int arrLength)
        {

            int Max = 0;
            Max = Arr[0];

            for (int i = 0; i < arrLength; i++)
            {

                if (Arr[i] > Max)
                {
                    Max = Arr[i];
                }

            }
            return Max;

        }

        static void Main(string[] args)
        {

            int[] arr = new int[100];
            int Length = 0;

            FillArrayWithRandomNumbers(arr, ref Length);

            Console.Write("\nArray Elements: ");
            PrintArray(arr, Length);
            Console.WriteLine("\nMax Number Of Array is " + MaxNumberOfArray(arr, Length));

        }
    }
}