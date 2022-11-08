using Lab_2.GamePackage;

namespace Lab_2.AccountPackage
{
    internal class InARowWinGameAccount : GameAccount
    {
        int WinCounter;

        public InARowWinGameAccount(string name) : base(name)
        {
            WinCounter = 0;
        }

        public override void WinGame(GameAccount opponent, Game game, int gameID)
        {
            int rating = game.CalculateRating(this);
            rating = (int)(rating * (1 + ((double)WinCounter) / 10));
            WinCounter++;
            Game newGame = game.Copy(true, rating, this, opponent, gameID);
            GameHistory.Add(newGame);
        }

        public override void LoseGame(GameAccount opponent, Game game, int gameID)
        {
            WinCounter = 0;
            base.LoseGame(opponent, game, gameID);
        }
    }
}
