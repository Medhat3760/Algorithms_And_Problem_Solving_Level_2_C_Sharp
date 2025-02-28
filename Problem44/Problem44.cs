namespace Problem44
{
    // Count Positive Numbers In Array
    internal class Problem44
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

                arr[i] = RandomNumberInRange(-100, 100);

            }

        }

        static int PositiveNumbersCountInArray(int[] arr, int arrLength)
        {
            int Count = 0;
            for (int i = 0; i < arrLength; i++)
            {

                if (arr[i] > 0)
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

            Console.WriteLine("\nPositive Numbers Count is: " + PositiveNumbersCountInArray(arr, arrLength));

        }
    }
}