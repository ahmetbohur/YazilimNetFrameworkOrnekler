using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.Ornekler.Games.RockPaperScissors
{
    internal class AccountManager
    {
        private List<Account> accounts = new List<Account>();
        private Account loggedInAccount;

        public Account GetLoggedInAccount() => loggedInAccount;

        public void MainScreen()
        {
            Console.WriteLine("Hesap oluşturmak için 1'e basınız.");
            Console.WriteLine("Giriş yapmak için 2'e basınız.");
            Console.WriteLine("Skor tablosunu görmek için 3'e basınız.");

            switch (Console.ReadLine())
            {
                case "1":
                    CreateAccount();
                    break;
                case "2":
                    Login();
                    break;
                case "3":
                    ShowLeaderboard();
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }

        public void CreateAccount()
        {
            Console.WriteLine("Kullanıcı adı:");
            string username = Console.ReadLine();
            Console.WriteLine("Şifre:");
            string password = Console.ReadLine();
            Console.WriteLine("Cinsiyet (1: Erkek, 2: Kadın):");
            Gender gender = (Gender)int.Parse(Console.ReadLine());
            Console.WriteLine("Yaş:");
            int age = int.Parse(Console.ReadLine());

            accounts.Add(new Account
            {
                Username = username,
                Password = password,
                Gender = gender,
                Age = age
            });
            Console.WriteLine("Hesap oluşturuldu.");
        }

        public void Login()
        {
            Console.WriteLine("Kullanıcı adı:");
            string username = Console.ReadLine();
            Console.WriteLine("Şifre:");
            string password = Console.ReadLine();

            foreach (var account in accounts)
            {
                if (account.Username == username && account.Password == password)
                {
                    loggedInAccount = account;
                    Console.WriteLine("Giriş yapıldı.");
                    return;
                }
            }

            Console.WriteLine("Kullanıcı adı veya şifre hatalı.");
        }

        public void Logout()
        {
            loggedInAccount = null;
        }

        public void ShowLeaderboard()
        {
            Account[] _temp = new Account[accounts.Count];
            int topScore = 0;

            // En yüksek skoru bul
            foreach (var account in accounts)
            {
                if (account.Score > topScore)
                {
                    topScore = account.Score;
                }
            }

            // En yüksek skora bakarak oyuncuları sırala
            int _tempIndex = 0;
            while (topScore > 0)
            {
                foreach (var account in accounts)
                {
                    if (account.Score == topScore)
                    {
                  
                        _temp[_tempIndex] = account;
                        _tempIndex++;
                    }
                }
                topScore--;
            }

            // Sıralanmış oyuncuları döndür
            foreach (var _player in _temp)
            {
                if(_player != null)
                {
                    Console.WriteLine($"{_player.Username} -- {_player.Score}");
                }      
            }
        }
    }
}
