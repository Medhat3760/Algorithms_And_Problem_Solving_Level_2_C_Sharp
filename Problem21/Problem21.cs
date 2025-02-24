namespace Problem21
{
    // Generate Keys
    internal class Problem21
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

        static int RandomNumber(int From, int To)
        {

            int RandNum = random.Next(From, To + 1);
            return RandNum;

        }

        static char GetRandomCharacter(enCharType CharType)
        {

            switch (CharType)
            {

                case enCharType.SmallLetter:
                    return (char)RandomNumber(97, 122);
                case enCharType.CapitalLetter:
                    return (char)RandomNumber(65, 90);
                case enCharType.SpecialCharacter:
                    return (char)RandomNumber(33, 47);
                case enCharType.Digit:
                    return (char)RandomNumber(48, 57);
                default:
                    return ' ';
            }

        }

        static string GenerateWord(enCharType CharType, short Length)
        {

            string Word = "";
            for (int i = 1; i <= Length; i++)
            {
                Word += GetRandomCharacter(CharType);
            }
            return Word;
        }

        static string GenerateKey()
        {

            string Key = "";

            Key += GenerateWord(enCharType.CapitalLetter, 4) + "-" +
                   GenerateWord(enCharType.CapitalLetter, 4) + "-" +
                   GenerateWord(enCharType.CapitalLetter, 4) + "-" +
                   GenerateWord(enCharType.CapitalLetter, 4);

            return Key;

        }

        static void GenerateKeys(int NumberOfKeys)
        {

            Console.WriteLine();

            for (int i = 1; i <= NumberOfKeys; i++)
            {

                Console.WriteLine("Key[" + i + "] : " + GenerateKey());

            }

        }

        static void Main(string[] args)
        {

            GenerateKeys(ReadPositiveNumber("Enter How Many Keys To Generate?"));

        }
    }
}