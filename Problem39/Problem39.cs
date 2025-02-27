namespace Problem39
{
    // Copy Prime Numbers To a New Array
    internal class Problem39
    {

        enum enPrimeNotPrime { Prime = 1, NotPrime = 2 }

        static enPrimeNotPrime CheckPrime(int Num)
        {

            if (Num < 2)
                return enPrimeNotPrime.NotPrime;

            if (Num == 2)
                return enPrimeNotPrime.Prime; // 2 is the only even prime

            if (Num % 2 == 0)
                return enPrimeNotPrime.NotPrime; // Exclude all even numbers

            int sqrtNum = (int)Math.Sqrt(Num);
            for (int i = 3; i <= sqrtNum; i += 2) // Check only odd numbers
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
            arr[arrLength - 1] = Number;

        }

        static void CopyArrayPrimeNumbers(int[] arrSource, int[] arrDestination, int arrLength, ref int arrDestinationLength)
        {

            for (int i = 0; i < arrLength; i++)
            {

                if (CheckPrime(arrSource[i]) == enPrimeNotPrime.Prime)
                {
                    AddArrayElement(arrSource[i], arrDestination, ref arrDestinationLength);
                }

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
            int arrLength = ReadPositiveNumber("Enter Number Of Elements?"), arr2Length = 0;

            FillArrayWithRandomNumbers(arr, arrLength);

            CopyArrayPrimeNumbers(arr, arr2, arrLength, ref arr2Length);

            Console.WriteLine("\nArray 1 Elements: ");
            PrintArray(arr, arrLength);

            Console.WriteLine("\nArray 2 Prime Numbers: ");
            PrintArray(arr2, arr2Length);

        }
    }
}