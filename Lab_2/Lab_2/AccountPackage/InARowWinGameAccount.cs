namespace Lab_2.AccountPackage
{
    internal class InARowWinGameAccount : GameAccount
    {
        int WinCounter;

        public InARowWinGameAccount(string name) : base(name)
        {
            WinCounter = 0;
        }

        public override void WinGame(GameAccount opponent, int rating, int gameID)
        {
            rating = (int) (rating * (1 + ((double) WinCounter) / 10));
            WinCounter++;
            base.WinGame(opponent, rating, gameID);
        }

        public override void LoseGame(GameAccount opponent, int rating, int gameID)
        {
            WinCounter = 0;
            base.LoseGame(opponent, rating, gameID);
        }
    }
}
