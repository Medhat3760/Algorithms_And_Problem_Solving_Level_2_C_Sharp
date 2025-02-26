namespace Problem35
{
    // Check Number In Array
    internal class Problem35
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

        static void PrintArray(int[] arr, int arrLength)
        {

            for (int i = 0; i < arrLength; i++)
            {

                Console.Write(arr[i] + " ");

            }

            Console.WriteLine();
        }

        static short FindNumberPositionInArray(int Number, int[] arr, int arrLength)
        {

            for (short i = 0; i < arrLength; i++)
            {

                if (arr[i] == Number)
                {

                    return i;

                }

            }

            return -1;

        }

        static bool IsNumberInArray(int Number, int[] arr, int arrLength)
        {

            return FindNumberPositionInArray(Number, arr, arrLength) != -1;

        }

        static void Main(string[] args)
        {

            int[] arr = new int[100];
            int arrLength = ReadPositiveNumber("Enter Number Of Elements?");

            FillArrayWithRandomNumbers(arr, arrLength);

            Console.WriteLine("\nArray1 Elements:");
            PrintArray(arr, arrLength);

            int Number = ReadPositiveNumber("\nEnter a Number To Check?");
            Console.WriteLine("\nNumber you are looking for is: " + Number);

            if (!IsNumberInArray(Number, arr, arrLength))
            {
                Console.WriteLine("No, Number is Not Found :-(");
            }
            else
            {
                Console.WriteLine("Yes, Number is Found :-)");
            }

        }

    }
}