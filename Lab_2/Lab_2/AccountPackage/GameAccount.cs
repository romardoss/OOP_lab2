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
                    rating += item.Rating;
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
        protected readonly List<Game> GameHistory = new();

        public GameAccount(string name)
        {
            if (AllNames.Contains(name))
            {
                throw new ArgumentException("This name is unavailable");
            }
            UserName = name;
            AllNames.Add(name);
        }

        public virtual void WinGame(GameAccount opponent, Game game, int gameID)
        {
            int rating = game.CalculateRating(this);
            Game newGame = game.Copy(true, rating, this, opponent, gameID);
            GameHistory.Add(newGame);
        }

        public virtual void LoseGame(GameAccount opponent, Game game, int gameID)
        {
            int rating = game.CalculateRating(this);
            rating = (CurrentRating > rating) ? -rating : 1 - this.CurrentRating;
            Game newGame = game.Copy(false, rating, this, opponent, gameID);
            GameHistory.Add(newGame);

        }

        public string GetStats()
        {
            var stats = new System.Text.StringBuilder();
            int wholeRaiting = 1;

            stats.AppendLine("Game statistics of " + UserName);
            stats.AppendLine("ID\tResult\tRating\tChange\tOpponent");
            foreach (var item in GameHistory)
            {
                string rating;

                wholeRaiting += item.Rating;

                rating = item.IsWin ? ("+" + item.Rating) : ("" + item.Rating);
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
