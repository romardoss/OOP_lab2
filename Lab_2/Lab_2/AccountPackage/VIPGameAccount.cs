using Lab_2.GamePackage;

namespace Lab_2.AccountPackage
{
    internal class VIPGameAccount : GameAccount
    {
        public VIPGameAccount(string name) : base(name)
        {
        }

        public override void WinGame(GameAccount opponent, Game game, int gameID)
        {
            int rating = game.CalculateRating(this);
            rating = (int)(rating * 1.5);
            rating = (CurrentRating > rating) ? -rating : 1 - this.CurrentRating;
            Game newGame = game.Copy(true, rating, this, opponent, gameID);
            GameHistory.Add(newGame);
        }

        public override void LoseGame(GameAccount opponent, Game game, int gameID)
        {
            int rating = game.CalculateRating(this);
            rating = (int)(rating * 0.5);
            rating = (CurrentRating > rating) ? -rating : 1 - this.CurrentRating;
            Game newGame = game.Copy(false, rating, this, opponent, gameID);
            GameHistory.Add(newGame);
        }
    }
}
