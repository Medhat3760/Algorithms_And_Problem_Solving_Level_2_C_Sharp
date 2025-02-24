namespace Problem22
{
    // Repeated Elements Count In Array
    internal class Problem22
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

        static void ReadArray(int[] Arr, ref int Length)
        {

            Length = ReadPositiveNumber("Enter How Many Elements Of Array?");
            Console.WriteLine("\nEnter Array Elements: ");

            for (int i = 0; i <= Length - 1; i++)
            {

                Console.Write("Element[" + (i + 1) + "]: ");
                Arr[i] = int.Parse(Console.ReadLine());

            }

        }

        static void PrintArray(int[] Arr, int Length)
        {
            for (int i = 0; i <= Length - 1; i++)
            {


                Console.Write(Arr[i] + " ");


            }

        }

        static int TimesRepeated(int[] Arr, int Length, int NumberToCheck)
        {

            int Count = 0;

            for (int i = 0; i <= Length - 1; i++)
            {

                if (NumberToCheck == Arr[i])
                {

                    Count++;

                }

            }

            return Count;
        }

        static void Main(string[] args)
        {

            int[] Arr = new int[100];
            int Length = 0, NumberToCheck = 0;

            ReadArray(Arr, ref Length);

            NumberToCheck = ReadPositiveNumber("\nEnter The Number You Want To Check?");

            Console.Write("\nOriginal Array: ");
            PrintArray(Arr, Length);

            Console.WriteLine("\n\n" + NumberToCheck + " is Repeated " + TimesRepeated(Arr, Length, NumberToCheck) + " time(s)");

        }
    }
}