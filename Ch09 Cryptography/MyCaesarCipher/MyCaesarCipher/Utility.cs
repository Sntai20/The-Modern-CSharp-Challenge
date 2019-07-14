using System;
using System.Collections.Generic;

namespace MyCaesarCipher
{
    internal class Utility
    {
        // Encryption Method Caesar
        internal static string Encrypt(string PlainText, int Key)
        {
            // To shift characters, change strings to an array of characters.
            // Select an appropriate data structure: array, circular linked list, 
            //List<char> CipherText = new List<char>();
            char[] chars = new char[PlainText.Length];

            // Iterate through each char.
            for (int i = 0; i < PlainText.Length; i++)
            {
                // Get the numerical value of each char.
                int ch = PlainText[i] - 'A';
                // To shift each char add the Key
                ch = (ch + Key + 26) % 26;
                // Cast the numerical value to char.
                chars[i] = (char)('A' + ch);
            }

            // Cipher text "FPX"
            string CipherText = new string(chars);
            //Console.WriteLine(CipherText);
            return CipherText;
        }

        // Decryption Method
        //public static string Decrypt(string PlainText, int Key)
        //{
            
        //}

        







        
    }
}