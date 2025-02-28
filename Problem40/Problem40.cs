namespace Problem40
{
    // Copy Destinct Numbers to Array
    internal class Problem40
    {

        static bool IsNumberInArray(int Number, int[] arr, int arrLength)
        {

            for (int i = 0; i < arrLength; i++)
            {

                if (arr[i] == Number)
                    return true;

            }

            return false;
        }



        static void AddArrayElement(int Number, int[] arrDestination, ref int arrDestinationLength)
        {

            arrDestinationLength++;
            arrDestination[arrDestinationLength - 1] = Number;

        }

        static void CopyDistinctNumbersToArray(int[] arrSource, int[] arrDestination, int SourceLength, ref int DentinationLength)
        {


            for (int i = 0; i < SourceLength; i++)
            {

                if (!IsNumberInArray(arrSource[i], arrDestination, DentinationLength))
                {

                    AddArrayElement(arrSource[i], arrDestination, ref DentinationLength);

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

            int[] arr = { 10, 10, 10, 50, 50, 70, 70, 70, 70, 90, 10 }, arr2 = new int[100];
            int arrLenght = arr.Length, arr2Length = 0;

            CopyDistinctNumbersToArray(arr, arr2, arrLenght, ref arr2Length);

            Console.WriteLine("\nArray 1 Elements: ");
            PrintArray(arr, arrLenght);

            Console.WriteLine("\nArray 2 Elements: ");
            PrintArray(arr2, arr2Length);

        }
    }
}