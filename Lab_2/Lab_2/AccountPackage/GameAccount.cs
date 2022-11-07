using Lab_2.GamePackage;
using System;
using System.Collections.Generic;

namespace Lab_2.AccountPackage
{
    internal class GameAccount
    {
        public string UserName { get; }
        public int CurrentRating
        {
            get
            {
                int rating = 1;
                foreach (var item in GameHistory)
                {
                    if (item.IsWin)
                    {
                        rating += item.Rating;
                    }
                    else
                    {
                        rating -= item.Rating;
                    }

                    if (rating < 1)
                    {
                        rating = 1;
                    }
                }
                return rating;
            }
        }
        public int GamesCount
        {
            get
            {
                return GameHistory.Count;
            }
        }
        private static readonly List<string> AllNames = new();
        private readonly List<Game> GameHistory = new();

        public GameAccount(string name)
        {
            if (AllNames.Contains(name))
            {
                throw new ArgumentException("This name is unavailable");
            }
            UserName = name;
            AllNames.Add(name);
        }

        public virtual void WinGame(GameAccount opponent, int rating, int gameID)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Argument must be positive");
            }

            var game = new Game(true, rating, this, opponent, gameID);
            GameHistory.Add(game);
            //adding a win game for this
        }

        public virtual void LoseGame(GameAccount opponent, int rating, int gameID)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Argument must be positive");
            }

            var game = new Game(false, rating, this, opponent, gameID);
            GameHistory.Add(game);

        }

        public string GetStats()
        {
            var stats = new System.Text.StringBuilder();
            int wholeRaiting = 1;

            stats.AppendLine("Game statistics of " + this.UserName);
            stats.AppendLine("ID\tResult\tRating\tChange\tOpponent");
            foreach (var item in GameHistory)
            {
                string rating;

                if (item.IsWin)
                {
                    wholeRaiting += item.Rating;
                }
                else
                {
                    int minusRating = (wholeRaiting <= item.Rating) ? (1 - wholeRaiting) : -item.Rating;
                    wholeRaiting += minusRating;
                }

                rating = item.IsWin ? ("+" + item.Rating) : ("-" + item.Rating);
                if (rating == "0" && !item.IsWin)
                {
                    rating = "-0";
                }
                string winOrLose = item.IsWin ? "Win" : "Lose";

                stats.AppendLine($"{item.GameIndex}\t" +
                    $"{winOrLose}\t{wholeRaiting}\t{rating}\t{item.Opponent.UserName}");
            }

            return stats.ToString();
        }
    }
}
