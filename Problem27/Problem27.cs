namespace Problem27
{
    // Average Of Random Array
    internal class Problem27
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

        static int SumArray(int[] Arr, int arrLength)
        {

            int Sum = 0;
            for (int i = 0; i < arrLength; i++)
            {

                Sum += Arr[i];

            }
            return Sum;
        }

        static float AverageOfArray(int[] Arr, int arrLength)
        {

            return (float)SumArray(Arr, arrLength) / arrLength;

        }

        static void Main(string[] args)
        {

            int[] arr = new int[100];
            int Length = 0;

            FillArrayWithRandomNumbers(arr, ref Length);

            Console.Write("\nArray Elements: ");
            PrintArray(arr, Length);

            Console.WriteLine("\nAverage Of All Numbers is: " + AverageOfArray(arr, Length));

        }
    }
}