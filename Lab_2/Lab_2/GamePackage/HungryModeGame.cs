using Lab_2.AccountPackage;

namespace Lab_2.GamePackage
{
    internal class HungryModeGame : Game
    {
        public HungryModeGame(bool isWin, int rating, GameAccount player, GameAccount opponent, int gameID) 
            : base(isWin, rating, player, opponent, gameID)
        {
            Type = "Hungry Mod Game";
        }

        public override int CalculateRating(GameAccount g)
        {
            bool win = IsWin;
            if (g == Opponent)
            {
                win = !win;
            }

            if (win)
            {
                return 2 * Rating;
            }
            else
            {
                return 5 * Rating;
            }
        }

        public override Game Copy(bool isWin, int rating, GameAccount player, GameAccount opponent, int gameID)
        {
            return new HungryModeGame(isWin, rating, player, opponent, gameID);
        }
    }
}
