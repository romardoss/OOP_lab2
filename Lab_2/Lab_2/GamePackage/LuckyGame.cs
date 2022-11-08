using Lab_2.AccountPackage;

namespace Lab_2.GamePackage
{
    internal class LuckyGame : Game
    {
        readonly GameAccount Victim;

        public LuckyGame(bool isWin, int rating, GameAccount player, GameAccount opponent, int gameID) 
            : base(isWin, rating, player, opponent, gameID)
        {
            GameType = "Lucky Game";
            //Вибір випадкової жертви
            System.Random random = new();
            int choseVictim = random.Next(0, 2);
            if(choseVictim == 0)
            {
                Victim = player;
            }
            else
            {
                Victim = opponent;
            }
        }

        public override int CalculateRating(GameAccount g)
        {
            if(Victim.Equals(g))
            {
                return Rating;
            }
            return 0;
        }

        public override Game Copy(bool isWin, int rating, GameAccount player, GameAccount opponent, int gameID)
        {
            return new LuckyGame(isWin, rating, player, opponent, gameID);
        }
    }
}
