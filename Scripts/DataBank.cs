namespace WinPasser.Scripts
{
    internal static class DataBank
    {
        public static Entry ActiveEntry { get; set; }

        public static Entry NewEntry { get; set; }

        public static string FilePath { get; set; }

        public static byte[] Key { get; set; }

        public static bool NeedToExit { get; set; }

        public static string GeneratedPassword { get; set; }
    }
}
