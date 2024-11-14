using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.Ornekler.Games.RockPaperScissors
{
    internal class RockPaperScissorsManager
    {
        internal enum RockPaperScissors
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3
        }


        private int playerScore = 0;
        private int computerScore = 0;
        private int round = 0;

        internal void GameLoop()
        {
            while(round < 5)
            {
                Console.WriteLine("1: Taş, 2: Kağıt, 3: Makas");
                RockPaperScissors player = (RockPaperScissors)int.Parse(Console.ReadLine());
                RockPaperScissors computer = (RockPaperScissors)new Random().Next(1, 4);
                CheckWinner(player, computer);
            }
            Console.WriteLine("Oyun bitti!");
            Console.WriteLine($"Oyuncu: {playerScore} - Bilgisayar: {computerScore}");
        }
        private void CheckWinner(RockPaperScissors player, RockPaperScissors computer)
        {
            if (player == computer)
            {
                Console.WriteLine("Berabere!");
            }
            else if (player == RockPaperScissors.Rock && computer == RockPaperScissors.Scissors)
            {
                Console.WriteLine("Oyuncu kazandı!");
                playerScore++;
            }
            else if (player == RockPaperScissors.Paper && computer == RockPaperScissors.Rock)
            {
                Console.WriteLine("Oyuncu kazandı!");
                playerScore++;
            }
            else if (player == RockPaperScissors.Scissors && computer == RockPaperScissors.Paper)
            {
                Console.WriteLine("Oyuncu kazandı!");
                playerScore++;
            }
            else
            {
                Console.WriteLine("Bilgisayar kazandı!");
                computerScore++;
            }
            round++;
        }
        internal int GetPlayerScore() => playerScore;
        internal int GetComputerScore() => computerScore;

    }
}
