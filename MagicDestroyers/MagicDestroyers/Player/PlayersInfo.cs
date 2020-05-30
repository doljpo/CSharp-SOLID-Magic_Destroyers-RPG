namespace MagicDestroyers.Player
{
    public static class PlayersInfo
    {
        private static string playersInfoDirectory;
        private static string fullInfo;
        private static string scores;
        private static string levels;

        public static string PlayersInfoDirectory
        {
            get => playersInfoDirectory;
            set => playersInfoDirectory = value;
        }
        public static string FullInfo
        {
            get => fullInfo;
            set => fullInfo = value;
        }
        public static string Scores
        {
            get => scores;
            set => scores = value;
        }
        public static string Levels
        {
            get => levels;
            set => levels = value;
        }

        public static void Initialize()
        { }

        public static void Save()
        { }

        public static void UpdateFullInfo()
        { }

        public static void RetrieveFullInfo()
        { }

        public static void PrintFullInfo()
        { }

        public static void EraseFullInfo()
        { }

        public static void UpdateScores()
        { }

        public static void RetrieveScores()
        { }

        public static void PrintScores()
        { }

        public static void EraseScores()
        { }

        public static void UpdateLevels()
        { }

        public static void RetrieveLevels()
        { }

        public static void PrintLevels()
        { }

        public static void EraseLevels()
        { }
    }
}
