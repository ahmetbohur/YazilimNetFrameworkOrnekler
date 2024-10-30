﻿using System;

namespace YazilimNetFrameworkOrnekler
{
    internal class RecursiveFunctions
    {
        /*
           Özyinelemeli Fonksiyonlar

           Özyinelemeli fonksiyonlar, kendini çağırarak belirli bir problemi çözmek için kullanılır.
           Özyineleme, genellikle daha karmaşık problemlerin daha basit alt problemlere bölünmesi gerektiğinde kullanılır.

           Temel durum, fonksiyonun ne zaman sona ereceğini belirlerken,
           rekürsif durum, fonksiyonun kendini ne zaman çağıracağını belirler.

           Örneğin: Faktöriyel hesaplama, Fibonacci sayıları gibi birçok problem özyinelemeli olarak çözülebilir.
        */

        // Faktöriyel hesaplayan özyinelemeli fonksiyon
        public int Factorial(int n)
        {
            // Temel durum
            if (n <= 1)
            {
                return 1; // 0! ve 1! = 1
            }
            // Rekürsif durum
            return n * Factorial(n - 1);
        }

        // Faktöriyel hesaplama örneği
        public void DisplayFactorialExample()
        {
            int number = 5;
            int result = Factorial(number);
            Console.WriteLine("Faktöriyel of " + number + ": " + result);
        }
    }
}
