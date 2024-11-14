using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.Ornekler.Games.RockPaperScissors
{
    internal enum Gender
    {
        Undefined = 0,
        Male = 1,
        Female = 2
    }

    internal class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public int Score { get; set; }

    }
}
