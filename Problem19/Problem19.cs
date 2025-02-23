namespace Problem19
{
    // Random 3 Numbers From 1 to 10
    internal class Problem19
    {

        static Random random = new Random();

        static int RandomNumber(int From, int To)
        {

            int RandNum = random.Next(From, To + 1);

            return RandNum;

        }

        static void Main(string[] args)
        {

            Console.WriteLine(RandomNumber(1, 10));
            Console.WriteLine(RandomNumber(1, 10));
            Console.WriteLine(RandomNumber(1, 10));

        }
    }
}