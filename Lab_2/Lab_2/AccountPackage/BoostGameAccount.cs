namespace Lab_2.AccountPackage
{
    internal class BoostGameAccount : GameAccount
    {
        public BoostGameAccount(string name) : base(name)
        {
        }

        public override void WinGame(GameAccount opponent, int rating, int gameID)
        {
            base.WinGame(opponent, rating/2, gameID);
        }
    }
}
