namespace Problem37
{
    // Resolve Problem#28 Copy Array Using AddArrayElement
    internal class Problem37
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

        static void AddArrayElement(int Number, int[] arr, ref int arrLength)
        {

            arrLength++;
            arr[arrLength-1] = Number;

        }

        static void CopyArrayUsingAddArrayElement(int[] arrSource, int[] arrDestenation, int arrLength, ref int arrDestinationLength)
        {
            for (int i = 0; i < arrLength; i++)
            {

                AddArrayElement(arrSource[i], arrDestenation, ref arrDestinationLength);

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

            int[] arr = new int[100];
            int arrLength = ReadPositiveNumber("Enter Number Of Elements?");

            FillArrayWithRandomNumbers(arr, arrLength);

            Console.WriteLine("\nArray 1 Elements: ");
            PrintArray(arr, arrLength);

            int[] arr2 = new int[100];
            int arr2Length = 0;

            CopyArrayUsingAddArrayElement(arr, arr2, arrLength, ref arr2Length);

            Console.WriteLine("\nArray 2 Elements After Copy: ");
            PrintArray(arr2, arr2Length);

        }
    }
}