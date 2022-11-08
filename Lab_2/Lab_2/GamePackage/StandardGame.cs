using Lab_2.AccountPackage;

namespace Lab_2.GamePackage
{
    internal class StandardGame : Game
    {
        public StandardGame(bool isWin, int rating, GameAccount player, GameAccount opponent, int gameID) 
            : base(isWin, rating, player, opponent, gameID)
        {
            GameType = "Standard Game";
        }

        public override int CalculateRating(GameAccount g = null)
        {
            return Rating;
        }

        public override Game Copy(bool isWin, int rating, GameAccount player, GameAccount opponent, int gameID)
        {
            return new StandardGame(isWin, rating, player, opponent, gameID);
        }
    }
}
