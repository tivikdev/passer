namespace WinPasser.Scripts
{
    internal static class DataBank
    {
        public static Entry ActiveEntry { get; set; }

        public static Entry NewEntry { get; set; }

        public static string FilePath { get; set; }

        public static string Password { get; set; }
    }
}
