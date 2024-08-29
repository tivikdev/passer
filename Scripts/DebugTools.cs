using System;

namespace WinPasser.Scripts
{
    internal static class DebugTools
    {
        internal static Entry GenerateTestEntry()
        {
            Random random = new Random();
            Entry entry = new Entry()
            {
                Title = random.Next(0, Int32.MaxValue).ToString(),
                Login = random.Next(0, Int32.MaxValue).ToString(),
                Password = random.Next(0, Int32.MaxValue).ToString()
            };

            return entry;
        }
    }
}
