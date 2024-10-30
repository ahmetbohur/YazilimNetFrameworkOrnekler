using System;

namespace YazilimNetFrameworkOrnekler
{
    /*
     Sınıflar (Classes)

     Sınıf Nedir?
     Sınıflar, nesne yönelimli programlamada veri ve davranışları bir araya getiren yapı taşlarıdır. 
     Bir sınıf, özellikler (değişkenler) ve metodlar (fonksiyonlar) içerebilir.

     Sınıf Nasıl Tanımlanır - Sınıf Tanımlama Kuralları Nelerdir?

     [Erişim Belirleyici] class [Sınıf Adı]

     Erişim Belirleyici: Sınıfın erişim düzeyini belirler.
     Örnekler:
         public: Her yerden erişilebilir.
         private: Sadece tanımlandığı sınıf içinde erişilebilir.
         protected: Sadece tanımlandığı sınıf ve alt sınıflar tarafından erişilebilir.
         internal: Aynı derleme (assembly) içindeki diğer sınıflardan erişilebilir.

     Sınıf Adı: Sınıfın adıdır. Genellikle PascalCase formatında yazılır.
     Örneğin: Player, Enemy, GameManager.

     Özellikler: Sınıfın verilerini tutan değişkenlerdir.
     Metodlar: Sınıfın işlevlerini tanımlayan fonksiyonlardır.

     Constructor: Sınıfın yeni bir örneği oluşturulduğunda çağrılan özel bir metoddur. 
     Sınıfın özelliklerini başlatmak için kullanılır.

     Örnek Sınıf Kullanımı:
     - Player sınıfı: Bir oyuncunun adını, yaşını ve boyunu saklar ve bilgilerini gösterir.
     - Enemy sınıfı: Bir düşmanın türünü ve sağlığını saklar, hasar aldığında kalan sağlığını gösterir.
 */

    // Sınıf Tanımları
    public class Player
    {
        // Özellikler
        public string playerName;  // Oyuncunun adı
        public int playerAge;      // Oyuncunun yaşı
        private float playerHeight; // Oyuncunun boyu (private erişim)

        // Constructor
        public Player(string name, int age, float height)
        {
            playerName = name;
            playerAge = age;
            playerHeight = height;
        }

        // Metod
        public void DisplayInfo()
        {
            Console.WriteLine($"Player Name: {playerName}, Age: {playerAge}, Height: {playerHeight}");
        }
    }

    public class Enemy
    {
        // Özellikler
        public string enemyType; // Düşmanın tipi
        public int health;       // Düşmanın sağlığı

        // Constructor
        public Enemy(string type, int health)
        {
            enemyType = type;
            this.health = health; // "this" anahtar kelimesi, parametre ile sınıfın özelliği arasındaki ayrımı yapar.
        }

        // Metod
        public void TakeDamage(int damage)
        {
            health -= damage; // Düşmanın sağlığını hasar miktarı kadar azaltır.
            Console.WriteLine($"{enemyType} took {damage} damage! Remaining health: {health}");
        }
    }

    class Classes
    {
        // Programın giriş noktası
        static void ClassesExample(string[] args)
        {
            // Player Sınıfından bir nesne oluşturma
            Player player1 = new Player("Alice", 25, 1.70f); // Yeni bir Player nesnesi oluşturuluyor.
            player1.DisplayInfo(); // Oyuncunun bilgilerini göster.

            // Enemy Sınıfından bir nesne oluşturma
            Enemy enemy1 = new Enemy("Goblin", 100); // Yeni bir Enemy nesnesi oluşturuluyor.
            enemy1.TakeDamage(20); // Düşmana 20 hasar veriliyor.
        }
    }
}
