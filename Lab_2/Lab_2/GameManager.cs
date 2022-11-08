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

        public static Game PlayStandard(GameAccount winner, GameAccount looser, int rating)
        {
            if(CheckAll(winner, looser, rating))
            {
                Game game = new StandardGame(true, rating, winner, looser, GameID);
                Play(winner, looser, game);
                return game;
            }
            return null;
        }

        public static Game PlayTraining(GameAccount winner, GameAccount looser, int rating)
        {
            if (CheckAll(winner, looser, rating))
            {
                Game game = new TrainingGame(true, rating, winner, looser, GameID);
                Play(winner, looser, game);
                return game;
            }
            return null;
        }

        public static Game PlayLucky(GameAccount winner, GameAccount looser, int rating)
        {
            if (CheckAll(winner, looser, rating))
            {
                Game game = new LuckyGame(true, rating, winner, looser, GameID);
                Play(winner, looser, game);
                return game;
            }
            return null;
        }

        public static Game PlayHungry(GameAccount winner, GameAccount looser, int rating)
        {
            if (CheckAll(winner, looser, rating))
            {
                Game game = new HungryModeGame(true, rating, winner, looser, GameID);
                Play(winner, looser, game);
                return game;
            }
            return null;
        }

        private static void Play(GameAccount winner, GameAccount looser, Game game)
        {
            GameList.Add(game);
            winner.WinGame(looser, game, GameID);
            looser.LoseGame(winner, game, GameID);
            GameID++;
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

        public static string GetHistory()
        {
            var stats = new System.Text.StringBuilder();
            stats.AppendLine("History of all games: ");
            stats.AppendLine("ID\tResult\tRating\tPlayer\tOpponent\tGame type");

            foreach (var item in GameList)
            {
                stats.AppendLine($"{item.GameIndex}\t" +
                    $"{item.IsWin}\t{item.Rating}\t{item.Player.UserName}" +
                    $"\t{item.Opponent.UserName}\t\t{item.GameType}");
            }

            return stats.ToString();
        }
    }
}
