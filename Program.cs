using System;
using YazilimNetFrameworkOrnekler.Ornekler.Games.RockPaperScissors;

namespace YazilimNetFrameworkOrnekler
{
    internal class Program
    {
        static AccountManager accountManager = new AccountManager();

        static void Main(string[] args)
        {
            while (accountManager.GetLoggedInAccount() == null)
            {
                accountManager.MainScreen();
            }

            RockPaperScissorsManager rockPaperScissorsManager = new RockPaperScissorsManager();

            rockPaperScissorsManager.GameLoop();

            accountManager.GetLoggedInAccount().Score = rockPaperScissorsManager.GetPlayerScore();

            accountManager.Logout();

            Main(args);

        }

    }
}
