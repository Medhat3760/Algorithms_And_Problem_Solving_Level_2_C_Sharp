namespace Problem30
{
    // Sum Of Two Arrays To a Third One
    internal class Problem30
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

            int randNum = random.Next(From, To + 1);
            return randNum;

        }

        static void FillArrayWithRandomNumbers(int[] arr, int arrLength)
        {

            for (int i = 0; i < arrLength; i++)
            {

                arr[i] = RandomNumber(1, 100);

            }

        }

        static void SumOf2Arrays(int[] arr, int[] arr2, int[] arrSum, int arrLength)
        {

            for (int i = 0; i < arrLength; i++)
            {

                arrSum[i] = arr[i] + arr2[i];

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

            int[] arr = new int[100], arr2 = new int[100], arrSum = new int[100];
            int arrLength = ReadPositiveNumber("Enter Number of Elements?");

            FillArrayWithRandomNumbers(arr, arrLength);
            FillArrayWithRandomNumbers(arr2, arrLength);
            SumOf2Arrays(arr, arr2, arrSum, arrLength);

            Console.WriteLine("\nArray 1 Elements: ");
            PrintArray(arr, arrLength);
            Console.WriteLine("\nArray 2 Elements: ");
            PrintArray(arr2, arrLength);
            Console.WriteLine("\nSum Of Array1 and Array2 Elements: ");
            PrintArray(arrSum, arrLength);

        }
    }
}