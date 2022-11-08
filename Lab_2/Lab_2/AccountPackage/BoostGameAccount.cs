using Lab_2.GamePackage;

namespace Lab_2.AccountPackage
{
    internal class BoostGameAccount : GameAccount
    {
        public BoostGameAccount(string name) : base(name)
        {
        }

        public override void LoseGame(GameAccount opponent, Game game, int gameID)
        {
            int rating = game.CalculateRating(this);
            rating /= 2;
            rating = (CurrentRating > rating) ? -rating : 1 - this.CurrentRating;
            Game newGame = game.Copy(true, rating, this, opponent, gameID);
            GameHistory.Add(newGame);
        }
    }
}
