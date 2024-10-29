using System;

namespace InterfaceExample
{
    /*
    Arayüzler (Interfaces)

    Arayüz Nedir?
    Arayüzler, nesne yönelimli programlamada belirli bir davranış setini tanımlayan yapılar olarak kullanılır. 
    Bir arayüz, yalnızca metod imzaları içerebilir ve bu metodlar, arayüzü uygulayan sınıflar tarafından gerçekleştirilmelidir.
    */

    // Arayüz tanımları
    public interface IDamageable
    {
        void TakeDamage(int amount); // Hasar almayı temsil eden metod.
    }

    public interface IInteractable
    {
        void Interact(); // Etkileşimde bulunmayı temsil eden metod.
    }

    // Oyuncu sınıfı
    public class Player : IDamageable, IInteractable
    {
        private int health = 100;

        // IDamageable arayüzündeki TakeDamage metodunu uyguluyoruz.
        public void TakeDamage(int amount)
        {
            health -= amount;
            Console.WriteLine($"Player took {amount} damage. Remaining health: {health}");
        }

        // IInteractable arayüzündeki Interact metodunu uyguluyoruz.
        public void Interact()
        {
            Console.WriteLine("Player interacted with an object.");
        }
    }

    // Düşman sınıfı
    public class Enemy : IDamageable
    {
        private int health = 50;

        // IDamageable arayüzündeki TakeDamage metodunu uyguluyoruz.
        public void TakeDamage(int amount)
        {
            health -= amount;
            Console.WriteLine($"Enemy took {amount} damage. Remaining health: {health}");
        }
    }

    // Oyun yöneticisi sınıfı
    public class GameManager
    {
        public void StartGame()
        {
            // Oyuncu ve düşman nesnelerini oluşturma
            Player player = new Player();
            Enemy enemy = new Enemy();

            // Düşmana hasar verme
            enemy.TakeDamage(10);

            // Oyuncunun etkileşimde bulunması
            player.Interact();
        }
    }
}
