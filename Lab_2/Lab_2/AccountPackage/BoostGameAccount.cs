namespace Lab_2.AccountPackage
{
    internal class BoostGameAccount : GameAccount
    {
        public BoostGameAccount(string name) : base(name)
        {
        }

        public override void LoseGame(GameAccount opponent, int rating, int gameID)
        {
            base.LoseGame(opponent, rating/2, gameID);
        }
    }
}
