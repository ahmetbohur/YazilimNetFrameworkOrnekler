using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.Bilgiler
{
    /*
       Inheritance (Kalıtım)

       Kalıtım Nedir?
       Kalıtım, bir sınıfın başka bir sınıfın özelliklerini ve işlevlerini devralmasıdır.
       Bu, programda ortak özellikleri bir üst sınıfta tanımlayarak tekrar kullanımını sağlar.
       Böylece kod tekrarından kaçınılır ve bakım kolaylaşır.

       Inheritance Kullanımı:
       Kalıtımı kullanmak için, türetilen sınıf (alt sınıf) : taban sınıf (üst sınıf) şeklinde yazılır.
       Türetilen sınıf, üst sınıfın tüm public, protected ve internal üyelerine erişebilir.
       private üyeler türetilen sınıfta erişilemez.

       Inheritance Syntax:
       class [Alt Sınıf Adı] : [Üst Sınıf Adı]

       Alt sınıf, üst sınıfın tüm özelliklerini ve metotlarını devralır.
       Üst sınıftaki metotlar veya özellikler yeniden tanımlanabilir (override) edilebilir.
  */

    // Character adlı temel sınıf
    internal class Character
    {
        // Değişken Tanımları
        public int age = 18;                       // Tam sayı değişkeni
        protected float height = 1.75f;            // Ondalık sayı değişkeni
        protected double balance = 1000.50;        // Daha yüksek hassasiyete sahip ondalık sayı değişkeni
        public string playerName = "Character1";   // Metin verisi değişkeni
        public bool isActive = true;               // Doğru/yanlış değişkeni
        private char grade = 'A';                  // Tek bir karakter değişkeni
        public List<int> scores = new List<int>(); // Dinamik dizi değişkeni
        public decimal price = 19.99m;             // Finansal hesaplamalar için ondalık sayı
        private object data = "Sample Data";       // Herhangi bir veri tipini saklayabilen temel veri tipi
        private int[] fixedArray = new int[5];     // Sabit boyutlu dizi
        public string[] names = new string[] { "Alice", "Bob", "Charlie" }; // Sabit boyutlu dizi
        private float[] floatArray = new float[3]; // Ondalık sayı dizisi

        public enum GendersEnum
        {
            Male = 0,
            Female = 1,
        }

        private GendersEnum gender = GendersEnum.Male; // Enum değişkeni

        // Karakter bilgilerini görüntüleme metodu
        public void DisplayCharacterInfo()
        {
            Console.WriteLine("Character Name: " + playerName);
            Console.WriteLine("Character Age: " + age);
            Console.WriteLine("Character Height: " + height);
            Console.WriteLine("Character Balance: " + balance);
            Console.WriteLine("Is Character Active: " + isActive);
            Console.WriteLine("Character Grade: " + grade);
            Console.WriteLine("Character Scores: " + string.Join(", ", scores));
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Data: " + data);
            Console.WriteLine("Names: " + string.Join(", ", names));
        }
    }

    // Character sınıfından miras alan Player sınıfı
    internal class Player : Character
    {
        public string teamName;
        public int level;

        // Player sınıfının yapıcı metodu
        public Player(string playerName, int age, string teamName, int level)
        {
            this.playerName = playerName;  // Character sınıfından miras alınan değişken
            this.age = age;                // Character sınıfından miras alınan değişken
            this.teamName = teamName;      // Player sınıfına özgü değişken
            this.level = level;            // Player sınıfına özgü değişken
        }

        // Player sınıfına özel bir metot
        public void DisplayPlayerInfo()
        {
            Console.WriteLine("Player Name: " + playerName);
            Console.WriteLine("Player Age: " + age);
            Console.WriteLine("Player Team: " + teamName);
            Console.WriteLine("Player Level: " + level);

            // Character sınıfından miras alınan diğer bilgilere erişim
            Console.WriteLine("Is Player Active: " + isActive);
            Console.WriteLine("Player Balance: " + balance);
        }
    }

    class Inheritance
    {
        static void InheritanceExample()
        {
            // Player sınıfından bir nesne oluşturma
            Player player1 = new Player("John", 25, "Red Team", 3);

            // Player sınıfının metodunu kullanarak bilgileri yazdırma
            player1.DisplayPlayerInfo();

            // Character sınıfından devralınan bir metoda erişim
            player1.DisplayCharacterInfo();
        }
    }
}
