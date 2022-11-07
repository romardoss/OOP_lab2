using Lab_2.GamePackage;
using Lab_2.AccountPackage;

namespace Lab_2
{
    internal class GameManager
    {
        private static int GameID = 28462;

        public static void PlayStandard(GameAccount player1, GameAccount player2, int rating)
        {
            int id = GameID;
            GameID++;
            player1.WinGame(player2, rating, id);
            player2.LoseGame(player1, rating, id);
        }

        public static void PlayTraining(GameAccount player1, GameAccount player2)
        {

        }

        public static void PlayLucky(GameAccount player1, GameAccount player2)
        {

        }

        public static void PlayHungry(GameAccount player1, GameAccount player2)
        {

        }
    }
}
