using Lab_2.AccountPackage;
using Lab_2.GamePackage;
using System;
using static Lab_2.GameManager;

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

        public static void ArgumentOutOfRangeTest1()
        {
            GameAccount test = new("test");
            GameAccount test0 = new("test0");
            try
            {
                PlayStandard(test, test0, -10);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ArgumentOutOfRangeTest2()
        {
            GameAccount test = new("test1");
            GameAccount test0 = new("test2");
            try
            {
                PlayStandard(test, test0, 0);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CheckUserTest()
        {
            GameAccount test = new("test1");
            Game answer = PlayStandard(test, test, 10);
            if(answer == null)
            {
                Console.WriteLine("PlayStandard return is null\n");
            }
        }
    }
}
