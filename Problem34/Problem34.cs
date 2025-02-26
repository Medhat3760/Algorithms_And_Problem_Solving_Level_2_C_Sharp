namespace Problem34
{
    // Return Number Index In Array
    internal class Problem34
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

        static void Main(string[] args)
        {

            int[] arr = new int[100];
            int arrLength = ReadPositiveNumber("Enter Number Of Elements?");

            FillArrayWithRandomNumbers(arr, arrLength);

            Console.WriteLine("\nArray1 Elements:");
            PrintArray(arr, arrLength);

            int Number = ReadPositiveNumber("\nEnter a Number To Search For?");

            Console.WriteLine("\nNumber You Are Looking For is: " + Number);
            short NumberPosition = FindNumberPositionInArray(Number, arr, arrLength);

            if (NumberPosition == -1)
            {

                Console.WriteLine("The Number is Not Found :-(");

            }
            else
            {

                Console.WriteLine("The Number Found At Position: " + NumberPosition);
                Console.WriteLine("The Number Found its Order  : " + (NumberPosition + 1));

            }

        }
    }
}