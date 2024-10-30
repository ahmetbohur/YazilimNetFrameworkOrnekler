using System;
using System.Collections.Generic;

namespace GameNamespace // Oyun ile ilgili sınıfların bulunduğu ad alanı
{
    /*
       Namespace Tanımlama Kuralları

       [namespace Anahtar Kelimesi] [Namespace Adı]
       
       Namespace, programlama dillerinde sınıfları, arayüzleri, yapıları ve diğer veri türlerini gruplamak için kullanılan bir yapıdır.
       Namespace'ler, isim çakışmalarını önlemek ve kod organizasyonunu geliştirmek amacıyla kullanılır.

       Namespace Nasıl Tanımlanır?
       Aşağıdaki biçimde tanımlanır:

       namespace NamespaceAdı // Namespace Tanımı
       {
           // Sınıflar, arayüzler ve diğer veri türleri burada tanımlanır.
       }

       Kullanım Örneği:
       Farklı isim alanları içinde aynı isimde sınıflar tanımlanabilir ve böylece isim çakışmaları önlenir.
       
       Örnek:
       namespace GameNamespace // Bu, oyunun ana ad alanını tanımlar
       {
           public class Player // Player sınıfı
           {
               public string Name; // Oyuncu ismi
           }
       }

       namespace EnemyNamespace // Düşman ad alanı
       {
           public class Player // Bu, farklı bir ad alanındaki Player sınıfıdır
           {
               public string Name; // Düşman ismi
           }
       }
    */

    namespace PlayerNamespace // Oyuncu sınıflarının bulunduğu ad alanı
    {
        public class Player
        {
            public string playerName = "Player1"; // Oyuncunun ismi
            public int playerScore = 0;           // Oyuncunun skoru

            public void DisplayPlayerInfo()
            {
                Console.WriteLine("Player Name: " + playerName);
                Console.WriteLine("Player Score: " + playerScore);
            }
        }
    }

    namespace EnemyNamespace // Düşman sınıflarının bulunduğu ad alanı
    {
        public class Enemy
        {
            public string enemyName = "Goblin"; // Düşmanın ismi
            public int enemyHealth = 100;       // Düşmanın sağlığı

            public void DisplayEnemyInfo()
            {
                Console.WriteLine("Enemy Name: " + enemyName);
                Console.WriteLine("Enemy Health: " + enemyHealth);
            }
        }
    }

    namespace ItemNamespace // Eşya sınıflarının bulunduğu ad alanı
    {
        public class Item
        {
            public string itemName = "Health Potion"; // Eşyanın ismi
            public int itemValue = 50;                // Eşyanın değeri

            public void DisplayItemInfo()
            {
                Console.WriteLine("Item Name: " + itemName);
                Console.WriteLine("Item Value: " + itemValue);
            }
        }
    }

    namespace UtilityNamespace // Yardımcı sınıfların bulunduğu ad alanı
    {
        public static class GameHelper
        {
            public static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Game!");
            }

            public static int CalculateDamage(int baseDamage, int multiplier)
            {
                return baseDamage * multiplier; // Hasar hesaplama fonksiyonu
            }
        }
    }
}
