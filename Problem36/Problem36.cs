namespace Problem36
{
    // Add Array Element Simi Dynamic
    internal class Problem36
    {

        static int ReadNumber(string Message)
        {
            int Num = 0;

            Console.WriteLine(Message);
            Num = int.Parse(Console.ReadLine());

            return Num;
        }

        static int ReadNumberInRange(int From, int To, string Message)
        {
            int Num = 0;
            do
            {

                Console.WriteLine(Message);
                Num = int.Parse(Console.ReadLine());

            } while (Num < From || Num > To);

            return Num;
        }

        static bool DoMore()
        {

            short Answer = (short)ReadNumberInRange(0, 1, "Do You Want To Add More Numbers? [0]No,[1]Yes?");

            return Answer == 1;

        }

        static void AddArrayElement(int Number, int[] arr, ref int arrLength)
        {

            arrLength++;
            arr[arrLength - 1] = Number;

        }

        static void InputUserNumbersInArray(int[] arr, ref int arrLength)
        {

            do
            {

                AddArrayElement(ReadNumber("Enter a Number To Store Them In Array?"), arr, ref arrLength);

            } while (DoMore());

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
            InputUserNumbersInArray(arr, ref arrLength);

            Console.WriteLine("\nArray Length: " + arrLength);
            Console.Write("\nArrayElements: ");
            PrintArray(arr, arrLength);

        }
    }
}