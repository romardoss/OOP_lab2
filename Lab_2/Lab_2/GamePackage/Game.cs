using Lab_2.AccountPackage;

namespace Lab_2.GamePackage
{
    internal class Game
    {
        public bool IsWin { get; }
        public GameAccount Player1 { get; }
        public GameAccount Player2 { get; }
        public int Rating { get; }
        private static int GameID = 28462;
        public string GameIndex { get; }

        public Game(bool isWin, int rating, GameAccount player1, GameAccount player2)
        {
            GameIndex = ((int)GameID).ToString();
            GameID++;
            IsWin = isWin;
            Player1 = player1;
            Player2 = player2;
            Rating = rating;
        }
    }
}
