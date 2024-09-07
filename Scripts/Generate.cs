using System;
using System.Collections.Generic;

namespace WinPasser.Scripts
{
    internal class Generate
    {
        private static readonly char[] randomChars = 
        {
            'A','a','B','b','C','c','D','d','E','e','F','f','G','g','H','h','I','i','J','j','K','k','L','l','M','m','N','n','O','o','P','p','Q','q','R','r','S','s','T','t','U','u','V','v','W','w','X','x','Y','y','Z','z',
            '1','2','3','4','5','6','7','8','9','0',
            '!','@','#','$','%','^','&','*','(',')','{','}',':','?','/','.',',','>','<'
        };

        internal static string Password()
        {
            Random random = new Random();
            string password = string.Empty;
            for (int i = 0; i < 12; i++)
            {
                password += randomChars[random.Next(randomChars.Length)];
            }
            return password;
        }

        internal static string CustomizedPassword(PasswordGeneratorProperties properties, int passwordLength)
        {
            if (passwordLength == 0)
                return string.Empty;

            List<char[]> charArrays = new List<char[]>();
            foreach (PasswordProperty property in properties)
            {
                if (property.Use)
                {
                    charArrays.Add(property.Characters);
                }
            }
            string generatedPassword = string.Empty;
            Random random = new Random();
            int charArraysLength = charArrays.Count;
            for (int i = 0; i < passwordLength; i++)
            {
                int randomArrayId = random.Next(charArraysLength);
                generatedPassword += (char)charArrays[randomArrayId][random.Next(charArrays[randomArrayId].Length)];
            }
            return generatedPassword;
        }
    }
}
