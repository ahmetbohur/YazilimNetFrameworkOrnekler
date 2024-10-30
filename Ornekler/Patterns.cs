using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.Ornekler
{
    internal class Patterns
    {

        internal void DrawSquareFrame(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // İlk ve son satır veya ilk ve son sütun için yıldız çiz
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        internal void DrawCross(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // Çapraz çizgiler için koşullar
                    if (i == j || j == size - i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        internal void DrawArrow(int size)
        {
            // Yukarı kısmı (genişleyen üçgen)
            for (int i = 0; i < size; i++)
            {
                // Boşlukları ekle
                for (int j = 0; j < size - i - 1; j++)
                {
                    Console.Write(" ");
                }
                // Yıldızları ekle
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Aşağı kısmı (dik çizgi)
            for (int i = 0; i < size - 1; i++)
            {
                // Boşlukları ekle
                for (int j = 0; j < size - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }

        internal void DrawDiamond(int size)
        {
            // Üst kısım (artan yıldız sayısı)
            for (int i = 1; i <= size; i += 2)
            {
                // Boşlukları yazdır
                for (int j = 0; j < (size - i) / 2; j++)
                {
                    Console.Write(" ");
                }

                // Yıldızları yazdır
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Alt kısım (azalan yıldız sayısı)
            for (int i = size - 2; i > 0; i -= 2)
            {
                // Boşlukları yazdır
                for (int j = 0; j < (size - i) / 2; j++)
                {
                    Console.Write(" ");
                }

                // Yıldızları yazdır
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

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
