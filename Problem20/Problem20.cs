namespace Problem20
{
    // Random Small Letter, Capital Letter, Special C and Digit in Order
    internal class Problem20
    {

        enum enCharType { SmallLetter = 1, CapitalLetter = 2, SpecialCharacter = 3, Digit = 4 };

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
                    {
                        return (char)RandomNumber(97, 122);
                    }
                case enCharType.CapitalLetter:
                    {
                        return (char)RandomNumber(65, 90);
                    }
                case enCharType.SpecialCharacter:
                    {
                        return (char)RandomNumber(33, 47);
                    }
                case enCharType.Digit:
                    {
                        return (char)RandomNumber(48, 57);
                    }
                default:
                    {
                        return ' ';
                    }

            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine(GetRandomCharacter(enCharType.SmallLetter));
            Console.WriteLine(GetRandomCharacter(enCharType.CapitalLetter));
            Console.WriteLine(GetRandomCharacter(enCharType.SpecialCharacter));
            Console.WriteLine(GetRandomCharacter(enCharType.Digit));

        }
    }
}