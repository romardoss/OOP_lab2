using Lab_2.AccountPackage;

namespace Lab_2.GamePackage
{
    internal abstract class Game
    {
        public bool IsWin { get; }
        // IsWin relates to the Player
        public GameAccount Player { get; }
        public GameAccount Opponent { get; }
        public int Rating { get; }
        public string GameIndex { get; }
        protected string GameType;

        public Game(bool isWin, int rating, GameAccount player, GameAccount opponent, int gameID)
        {
            GameIndex = gameID.ToString();
            IsWin = isWin;
            Player = player;
            Opponent = opponent;
            Rating = rating;
        }

        public abstract int CalculateRating(GameAccount g=null);


        public abstract Game Copy(bool isWin, int rating, GameAccount player, GameAccount opponent, int gameID);
    }
}
