namespace Problem28
{
    // Copy Array
    internal class Problem28
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

        static void CopyArray(int[] arrSource, int[] arrDestination, int arrLength)
        {

            for (int i = 0; i < arrLength; i++)
            {

                arrDestination[i] = arrSource[i];

            }

        }

        static void Main(string[] args)
        {

            int[] arr = new int[100];
            int Length = 0;
            FillArrayWithRandomNumbers(arr, ref Length);

            int[] arr2 = new int[100];
            CopyArray(arr, arr2, Length);

            Console.Write("\nArray Elements: ");
            PrintArray(arr, Length);
            Console.Write("\nArray 2 Elements After Copy: ");
            PrintArray(arr2, Length);


        }
    }
}