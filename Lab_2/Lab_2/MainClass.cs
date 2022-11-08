using Lab_2.AccountPackage;
using System;
using static Lab_2.GameManager;

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


            //GameAccount Roma = new("Roma");
            BoostGameAccount Roma = new("Roma");
            VIPGameAccount Dima = new("Dima");
            InARowWinGameAccount Vasya = new("Vasya");
            var Andrew = new GameAccount("Andrew");

            PlayStandard(Roma, Dima, 30);
            PlayStandard(Roma, Vasya, 31);
            PlayStandard(Dima, Roma, 34);
            PlayStandard(Roma, Dima, 34);
            PlayStandard(Roma, Vasya, 34);
            PlayStandard(Vasya, Roma, 25);
            PlayStandard(Dima, Andrew, 29);
            PlayStandard(Roma, Andrew, 22);
            PlayStandard(Vasya, Andrew, 30);
            //PlayStandard(Roma, Roma, 20);
            PlayStandard(Dima, Vasya, 30);
            PlayStandard(Vasya, Andrew, 10);
            PlayStandard(Vasya, Andrew, 10);
            PlayStandard(Vasya, Andrew, 10);
            PlayStandard(Vasya, Andrew, 10);
            PlayStandard(Vasya, Andrew, 10);
            PlayStandard(Vasya, Andrew, 10);

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
