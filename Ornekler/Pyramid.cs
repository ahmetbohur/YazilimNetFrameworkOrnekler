using System;

namespace YazilimNetFrameworkOrnekler.Ornekler
{
    internal class Pyramid
    {
        // Dikey piramit çizme metodu
        internal void DrawVerticalPyramid(int height)
        {
            for (int i = height; i > 0; i--)
            {
                // Boşlukları yazdır
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }

                // Yıldızları yazdır
                for (int k = 0; k < (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        // Yatay piramit çizme metodu
        internal void DrawHorizontalPyramid(int width)
        {
            // Artan bölüm
            for (int i = 1; i <= width; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Azalan bölüm
            for (int i = width - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
