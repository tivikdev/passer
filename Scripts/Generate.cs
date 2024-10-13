using System;
using System.Collections.Generic;

namespace WinPasser.Scripts
{
    internal class Generate
    {
        internal static string CustomizedPassword(PasswordGeneratorProperties properties, uint passwordLength)
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
