using Lab_2.AccountPackage;

namespace Lab_2.GamePackage
{
    internal class Game
    {
        public bool IsWin { get; }
        public GameAccount Player { get; }
        public GameAccount Opponent { get; }
        public int Rating { get; }
        public string GameIndex { get; }

        public Game(bool isWin, int rating, GameAccount player, GameAccount player2, int gameID)
        {
            GameIndex = gameID.ToString();
            IsWin = isWin;
            Player = player;
            Opponent = player2;
            Rating = rating;
        }
    }
}
