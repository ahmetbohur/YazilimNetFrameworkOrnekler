using System;
using YazilimNetFrameworkOrnekler.Ornekler.Games.RockPaperScissors;

namespace YazilimNetFrameworkOrnekler
{
    internal class Program
    {
        static AccountManager accountManager = new AccountManager();

        static void Main(string[] args)
        {
            YazilimNetFrameworkOrnekler.Bilgiler.ActionAndDelegate actionAndDelegate = new YazilimNetFrameworkOrnekler.Bilgiler.ActionAndDelegate();

            actionAndDelegate.RunExamples();

            Console.ReadLine();

        }

    }
}
