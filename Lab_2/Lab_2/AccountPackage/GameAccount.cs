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
                    int change;
                    bool isWin = item.IsWin;
                    if (item.Player1.UserName != this.UserName)
                    {
                        isWin = !isWin;
                    }

                    if (isWin)
                    {
                        change = item.Rating;
                    }
                    else
                    {
                        change = -item.Rating;
                    }
                    rating += change;
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

        public void WinGame(GameAccount opponent, int rating)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Argument must be positive");
            }

            var game = new Game(true, rating, this, opponent);
            GameHistory.Add(game);
            //adding a win game for this

            opponent.GameHistory.Add(game);
            //adding a lose game for opponent
        }

        public void LoseGame(GameAccount opponent, int rating)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Argument must be positive");
            }

            var game = new Game(false, rating, this, opponent);
            GameHistory.Add(game);
            opponent.GameHistory.Add(game);

        }

        public string GetStats()
        {
            var stats = new System.Text.StringBuilder();
            int wholeRaiting = 1;
            int gameCount = 0;

            stats.AppendLine("Game statistics of " + this.UserName);
            stats.AppendLine("ID\tGame number\tResult\tRating\tChange\tOpponent");
            foreach (var item in GameHistory)
            {
                gameCount++;
                string rating;
                bool isWin = item.IsWin;
                string opponent;
                if (item.Player2.UserName == this.UserName)
                {
                    isWin = !isWin;
                    opponent = item.Player1.UserName;
                }
                else
                {
                    opponent = item.Player2.UserName;
                }

                if (isWin)
                {
                    wholeRaiting += item.Rating;
                }
                else
                {
                    int minusRating = (wholeRaiting <= item.Rating) ? (1 - wholeRaiting) : -item.Rating;
                    wholeRaiting += minusRating;
                }

                rating = isWin ? ("+" + item.Rating) : ("-" + item.Rating);
                if (rating == "0" && !isWin)
                {
                    rating = "-0";
                }
                string winOrLose = isWin ? "Win" : "Lose";

                stats.AppendLine($"{item.GameIndex}\t{gameCount}\t" +
                    $"\t{winOrLose}\t{wholeRaiting}\t{rating}\t{opponent}");
            }

            return stats.ToString();
        }
    }
}
