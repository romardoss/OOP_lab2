using Lab_2.AccountPackage;
using System;

namespace Lab_2
{
    internal class Testing
    {
        public static void UnavailableNameTest()
        {
            try
            {
                var GameAccount = new GameAccount("User");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Can`t create first account");
            }

            try
            {
                var GameAccount = new GameAccount("User");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Can`t create second account");
            }

        }

/*        public static void ArgumentOutOfRangeTest1()
        {
            GameAccount test = new("test");
            GameAccount test0 = new("test0");
            try
            {
                test.WinGame(test0, -1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }*/

 /*       public static void ArgumentOutOfRangeTest2()
        {
            GameAccount test = new("test1");
            GameAccount test0 = new("test2");
            try
            {
                test.WinGame(test0, 0);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }*/

 /*       public static void ArgumentOutOfRangeTest3()
        {
            GameAccount test = new("test3");
            GameAccount test0 = new("test4");
            try
            {
                test.LoseGame(test0, -1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }*/

  /*      public static void ArgumentOutOfRangeTest4()
        {
            GameAccount test = new("test5");
            GameAccount test0 = new("test6");
            try
            {
                test.LoseGame(test0, 0);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }*/
    }
}
