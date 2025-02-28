namespace Problem41
{
    // Is Palindrome Array
    internal class Problem41
    {

        static void FillArray(int[] arr, ref int arrLength)
        {
            // 10 20 30 30 20 10
            arrLength = 6;
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 30;
            arr[4] = 20;
            arr[5] = 10;
        }

        static void PrintArray(int[] arr, int arrLength)
        {

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

        static bool IsPalindromeArray(int[] arr, int arrLength)
        {

            for (int i = 0; i < arrLength / 2; i++)
            {
                if (arr[i] != arr[arrLength - 1 - i])
                {
                    return false;
                }

            }

            return true;
        }

        static void Main(string[] args)
        {

            int[] arr = new int[100];
            int arrLength = 0;

            FillArray(arr, ref arrLength);

            Console.WriteLine("\nArray Elements: ");
            PrintArray(arr, arrLength);


            if (IsPalindromeArray(arr, arrLength))
            {
                Console.WriteLine("\nYes, Array is Palindrome");
            }
            else
            {
                Console.WriteLine("\nNo, Array is Not Palindrome");

            }

        }
    }
}