namespace Lab_2.AccountPackage
{
    internal class VIPGameAccount : GameAccount
    {
        public VIPGameAccount(string name) : base(name)
        {
        }

        public override void WinGame(GameAccount opponent, int rating, int gameID)
        {
            rating = (int) (rating*1.5);
            base.WinGame(opponent, rating, gameID);
        }

        public override void LoseGame(GameAccount opponent, int rating, int gameID)
        {
            rating = (int)(rating * 0.5);
            base.LoseGame(opponent, rating, gameID);
        }
    }
}
