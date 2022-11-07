using Lab_2.AccountPackage;
using System;

namespace Lab_2
{
    internal class MainClass
    {
        static void Main(string[] args)
        {

            //Testing.UnavailableNameTest();
            //Testing.ArgumentOutOfRangeTest1();
            //Testing.ArgumentOutOfRangeTest2();
            //Testing.ArgumentOutOfRangeTest3();
            //Testing.ArgumentOutOfRangeTest4();


            GameAccount Roma = new GameAccount("Roma");
            var Dima = new GameAccount("Dima");
            var Vasya = new GameAccount("Vasya");
            var Andrew = new GameAccount("Andrew");

            Roma.WinGame(Dima, 30);
            Vasya.LoseGame(Roma, 31);
            Dima.WinGame(Roma, 34);
            Roma.WinGame(Vasya, 34);
            Vasya.WinGame(Roma, 25);
            Andrew.WinGame(Dima, 29);
            Roma.WinGame(Andrew, 22);
            Andrew.LoseGame(Vasya, 30);

            Console.WriteLine(Dima.GetStats());
            Console.WriteLine(Roma.GetStats());
            Console.WriteLine(Vasya.GetStats());
            Console.WriteLine(Andrew.GetStats());
            Console.WriteLine(Roma.GamesCount + " games played by " + Roma.UserName);
            Console.WriteLine(Vasya.GamesCount + " games played by " + Vasya.UserName);
            Console.WriteLine(Roma.CurrentRating + " raiting achieved by " + Roma.UserName);
            Console.WriteLine(Andrew.CurrentRating + " raiting achieved by " + Andrew.UserName);
        }
    }
}
