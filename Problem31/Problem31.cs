namespace Problem31
{
    // Shuffle Ordered Array
    internal class Problem31
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

        static void Swap(ref int A, ref int B)
        {

            int Temp = A;
            A = B;
            B = Temp;

        }



        static Random random = new Random();
        static int RandomNumber(int From, int To)
        {

            int randNum = random.Next(From, To + 1);
            return randNum;

        }

        static void ShuffleArray(int[] arr, int arrLength)
        {

            for (int i = 0; i < arrLength; i++)
            {

                Swap(ref arr[RandomNumber(1, arrLength) - 1], ref arr[RandomNumber(1, arrLength) - 1]);

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



        }
    }
}