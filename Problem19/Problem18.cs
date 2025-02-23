namespace Problem18
{
    // Encrypt And Decrypt Text
    internal class Problem18
    {

        static string ReadText(string Message)
        {

            string Text;
            Console.WriteLine(Message);
            Text = Console.ReadLine();
            return Text;

        }

        static string EncryptText(string Text, short EncryptionKey)
        {
            char[] ArrayText = Text.ToCharArray();

            for (int i = 0; i <= ArrayText.Length - 1; i++)
            {

                ArrayText[i] = (char)(ArrayText[i] + EncryptionKey);

            }
            return new string(ArrayText);
        }

        static string DecryptText(string Text, short EncryptionKey)
        {

            char[] ArrayText = Text.ToCharArray();

            for (int i = 0; i <= ArrayText.Length - 1; i++)
            {

                ArrayText[i] = (char)(ArrayText[i] - EncryptionKey);

            }

            return new string(ArrayText);

        }

        static void Main(string[] args)
        {

            string Text = ReadText("Enter a Text ?");
            const short EncryptionKey = 2;
            string TextAfterEncryption = EncryptText(Text, EncryptionKey);
            string TextAfterDecryption = DecryptText(TextAfterEncryption, EncryptionKey);

            Console.WriteLine("\nText Before Encryption : " + Text);
            Console.WriteLine("Text After Encryption : " + TextAfterEncryption);
            Console.WriteLine("Text After Decryption : " + TextAfterDecryption);

        }
    }
}