using System;

namespace MyCaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and intialize Plain Text, Key, and Cipher Text
            string PlainText = "CMU";
            int Key = 3;
            string CipherText = "";

            // Print the PT to the console.
            Console.WriteLine($"Message in PlainText: {PlainText}");

            // To encrypt PT message, use the Encrypt method w/ PT and Key.
            CipherText = Utility.Encrypt(PlainText, Key);

            // Print the CT to the console.
            Console.WriteLine($"Message in CipherText: {CipherText}");
            
        }
    }
}
