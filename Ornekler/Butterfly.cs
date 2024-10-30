using System;

namespace YazilimNetFrameworkOrnekler.Ornekler
{
    internal class Butterfly
    {
        internal void DrawButterfly(int size)
        {
            // Üst kısım (artan yıldız sayısı)
            for (int i = 1; i <= size; i++)
            {
                // Sol taraftaki yıldızları yazdır
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                // Ortadaki boşlukları yazdır
                for (int j = 0; j < (size - i) * 2; j++)
                {
                    Console.Write(" ");
                }

                // Sağ taraftaki yıldızları yazdır
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Alt kısım (azalan yıldız sayısı)
            for (int i = size; i > 0; i--)
            {
                // Sol taraftaki yıldızları yazdır
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                // Ortadaki boşlukları yazdır
                for (int j = 0; j < (size - i) * 2; j++)
                {
                    Console.Write(" ");
                }

                // Sağ taraftaki yıldızları yazdır
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
