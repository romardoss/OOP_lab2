using Lab_2.GamePackage;
using Lab_2.AccountPackage;
using System;
using System.Collections.Generic;

namespace Lab_2
{
    internal static class GameManager
    {
        private static int GameID = 28462;
        public static List<Game> GameList = new();

        public static void PlayStandard(GameAccount player1, GameAccount player2, int rating)
        {
            if(CheckAll(player1, player2, rating))
            {
                int id = GameID;
                GameID++;
                //Треба створити гру
                //І метод для повернення базової гри
                Game game = new StandardGame(true, rating, player1, player2, id);
                GameList.Add(game);
                //і логіку при виграші/програші
                player1.WinGame(player2, game, id);
                player2.LoseGame(player1, game, id);
            }
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

        private static bool CheckUser(GameAccount player1, GameAccount player2)
        {
            try
            {
                if (player1.UserName == player2.UserName)
                {
                    throw new ArgumentException("User can not play with itself");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message + $" ({player1.UserName})");
                return false;
            }
            
            return true;
        }

        private static bool CheckRatingArgument(int rating)
        {
            try
            {
                if (rating <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(rating), "Argument must be positive");
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        private static bool CheckAll(GameAccount player1, GameAccount player2, int rating)
        {
            return (CheckUser(player1, player2) && CheckRatingArgument(rating));
        }
    }
}
