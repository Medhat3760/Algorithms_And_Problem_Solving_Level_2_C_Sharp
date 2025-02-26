namespace Problem32
{
    // Copy Array In Reverse Order
    internal class Problem32
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

        static void FillArrayWithRandomNumbers(int[] arr, int arrLength)
        {

            for (int i = 0; i < arrLength; i++)
            {

                arr[i] = RandomNumberInRange(1, 100);

            }

        }

        static void CopyArrayInReversedOrder(int[] arrSource, int[] arrDestination, int arrLength)
        {

            for (int i = 0; i < arrLength; i++)
            {

                arrDestination[i] = arrSource[arrLength - 1 - i];

            }

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

            int[] arr = new int[100], arr2 = new int[100];
            int arrLength = ReadPositiveNumber("Enter Number Of Elements?");

            FillArrayWithRandomNumbers(arr, arrLength);

            CopyArrayInReversedOrder(arr, arr2, arrLength);

            Console.WriteLine("\nArray 1 Elements: ");
            PrintArray(arr, arrLength);

            Console.WriteLine("\nArray 2 Elements After Copying Array 1 In Reversed Order: ");
            PrintArray(arr2, arrLength);

        }
    }
}