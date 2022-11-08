using Lab_2.AccountPackage;

namespace Lab_2.GamePackage
{
    internal class TrainingGame : Game
    {
        public TrainingGame(bool isWin, int rating, GameAccount player, GameAccount opponent, int gameID) 
            : base(isWin, rating, player, opponent, gameID)
        {
            GameType = "Training Game";
        }

        public override int CalculateRating(GameAccount g=null)
        {
            return 0;
        }

        public override Game Copy(bool isWin, int rating, GameAccount player, GameAccount opponent, int gameID)
        {
            return new TrainingGame(isWin, rating, player, opponent, gameID);
        }
    }
}
