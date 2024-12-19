namespace Problem1
{
    internal class Problem1
    {

        // Problem #1       (Print Multiplication Table)

        static void PrintTableHeader()
        {

            Console.WriteLine("\n\t\t\t Multiplication Table From 1 to 10\n");

            for (int i = 1; i <= 10; i++)
            {

                Console.Write("\t" + i);

            }
            Console.WriteLine("\n" + "ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");

        }

        static string ColumnSeparator(int i)
        {

            if (i < 10)
            {
                return "   |";
            }
            else
            {
                return "  |";
            }

        }

        static void PrintMultiplicationTable()
        {

            PrintTableHeader();
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(" " + i + ColumnSeparator(i));

                for (int j = 1; j <= 10; j++)
                {

                    Console.Write("\t" + i * j);

                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {

            PrintMultiplicationTable();

        }
    }
}
