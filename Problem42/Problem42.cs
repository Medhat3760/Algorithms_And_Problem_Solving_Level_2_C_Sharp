namespace Problem42
{
    // Count Odd Numbers In Array
    internal class Problem42
    {

        enum enOddOrEven { Odd = 1, Even = 2 };

        static enOddOrEven CheckOddOrEven(int Num)
        {

            if (Num % 2 == 0)
            {

                return enOddOrEven.Even;

            }

            return enOddOrEven.Odd;
        }

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
        static int RandomNumberInRange(int From, int To)
        {

            int randNum = random.Next(From, To + 1);
            return randNum;

        }

        static void FillArrayWithRandomNumbers(int[] arr, ref int arrLength)
        {

            arrLength = ReadPositiveNumber("Enter number of elements?");

            for (int i = 0; i < arrLength; i++)
            {

                arr[i] = RandomNumberInRange(0, 100);

            }

        }

        static int OddNumbersCountInArray(int[] arr, int arrLength)
        {
            int Count = 0;
            for (int i = 0; i < arrLength; i++)
            {

                if (arr[i] % 2 != 0)
                {
                    Count++;
                }

            }

            return Count;
        }

        static void PrintArray(int[] arr, int arrLength)
        {

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            int[] arr = new int[100];
            int arrLength = 0;

            FillArrayWithRandomNumbers(arr, ref arrLength);

            Console.WriteLine("\nArray Elements: ");
            PrintArray(arr, arrLength);

            Console.WriteLine("\nOdd Numbers Count is: " + OddNumbersCountInArray(arr, arrLength));

        }
    }
}