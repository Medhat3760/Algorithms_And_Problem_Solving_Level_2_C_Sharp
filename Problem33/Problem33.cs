namespace Problem33
{
    // Fill Array With Keys
    internal class Problem33
    {

        enum enCharType { SmallLetter = 1, CapitalLetter = 2, SpecialCharacter = 3, Digit = 4 }

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

        static char GetRandomCharacter(enCharType CharType)
        {

            switch (CharType)
            {

                case enCharType.SmallLetter:
                    return (char)RandomNumberInRange(97, 122);
                case enCharType.CapitalLetter:
                    return (char)RandomNumberInRange(65, 90);
                case enCharType.SpecialCharacter:
                    return (char)RandomNumberInRange(33, 47);
                case enCharType.Digit:
                    return (char)RandomNumberInRange(48, 57);
                default:
                    return ' ';

            }

        }

        static string GenerateWord(enCharType CharType, short Length)
        {

            string Word = "";
            for (int i = 1; i <= Length; i++)
            {

                Word += (char)GetRandomCharacter(CharType);

            }

            return Word;
        }

        static string GenerateKey()
        {

            string Key = "";

            Key += GenerateWord(enCharType.CapitalLetter, 4) + "-";
            Key += GenerateWord(enCharType.CapitalLetter, 4) + "-";
            Key += GenerateWord(enCharType.CapitalLetter, 4) + "-";
            Key += GenerateWord(enCharType.CapitalLetter, 4);

            return Key;

        }

        static void FillArrayWithKeys(string[] arr, int arrLength)
        {

            for (int i = 0; i < arrLength; i++)
            {

                arr[i] = GenerateKey();

            }

        }

        static void PrintStringArray(string[] arr, int arrLength)
        {

            for (int i = 0; i < arrLength; i++)
            {

                Console.WriteLine("Array[" + i + "] : " + arr[i]);


            }

        }

        static void Main(string[] args)
        {

            string[] arr = new string[100];
            int arrLength = ReadPositiveNumber("Enter How Many Keys Do You Want To Generate?");

            FillArrayWithKeys(arr, arrLength);

            Console.WriteLine("\nArray Elements:\n");
            PrintStringArray(arr, arrLength);

        }
    }
}