namespace Problem29
{
    // Copy Only Prime Numbers
    internal class Problem29
    {

        enum enPrimeNotPrime { Prime = 1, NotPrime = 2 }

        static enPrimeNotPrime CheckPrime(int Num)
        {

            if (Num <= 1)
                return enPrimeNotPrime.NotPrime;

            int M = (int)Math.Round((float)Num / 2);

            for (int i = 2; i <= M; i++)
            {

                if (Num % i == 0)
                    return enPrimeNotPrime.NotPrime;

            }
            return enPrimeNotPrime.Prime;
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
        static int RandomNumber(int From, int To)
        {

            int randNum = random.Next(From, To + 1);
            return randNum;

        }

        static void FillArrayWithRandomNumbers(int[] arr, ref int arrLength)
        {

            arrLength = ReadPositiveNumber("Enter Number of Elements?");

            for (int i = 0; i < arrLength; i++)
            {

                arr[i] = RandomNumber(1, 100);

            }

        }

        static void CopyOnlyPrimeNumbers(int[] arrSource, int[] arrDestination, int arrLength, ref int arr2Length)
        {

            int Counter = 0;
            for (int i = 0; i < arrLength; i++)
            {

                if (CheckPrime(arrSource[i]) == enPrimeNotPrime.Prime)
                {

                    arrDestination[Counter] = arrSource[i];
                    Counter++;
                }

            }

            arr2Length = Counter;
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

            int[] arr2 = new int[100];
            int arr2Length = 0;
            CopyOnlyPrimeNumbers(arr, arr2, arrLength, ref arr2Length);

            Console.WriteLine("\nArray Elements: ");
            PrintArray(arr, arrLength);

            Console.WriteLine("\nArray 2 Prime Numbers: ");
            PrintArray(arr2, arr2Length);

        }
    }
}
