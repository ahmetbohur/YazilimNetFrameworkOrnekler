using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.Ornekler
{
    internal class Calculator
    {
        // Calculator programının çalışma durumunu belirleyen değişken
        private bool isRunning = true;

        // Calculator menüsünü gösterir ve kullanıcıdan işlem seçmesini ister
        internal void Calculate()
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("1. Add"); // Toplama işlemi
            Console.WriteLine("2. Subtract"); // Çıkarma işlemi
            Console.WriteLine("3. Divide"); // Bölme işlemi
            Console.WriteLine("4. Multiply"); // Çarpma işlemi
            Console.WriteLine("5. Exit"); // Çıkış yapma

            // Kullanıcıdan bir işlem seçmesini ister
            Console.Write("Select an operation: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            // Seçilen işleme göre ilgili metodu çağırır
            switch (operation)
            {
                case 1:
                    Add(); // Toplama işlemi
                    break;
                case 2:
                    Subtract(); // Çıkarma işlemi
                    break;
                case 3:
                    Divide(); // Bölme işlemi
                    break;
                case 4:
                    Multiply(); // Çarpma işlemi
                    break;
                case 5:
                    isRunning = false; // Çıkış işlemi
                    break;
                default:
                    Console.WriteLine("Invalid operation!"); // Geçersiz işlem uyarısı
                    break;
            }
        }

        // Sonsuz döngü içinde hesap makinesi menüsünü çalıştırır
        internal void InfinityLoopCalculator()
        {
            isRunning = true;
            while (isRunning)
            {
                Calculate(); // Menüyü sürekli olarak çalıştırır
            }
        }

        // Toplama işlemini gerçekleştirir
        internal void Add()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine()); // İlk sayıyı alır
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine()); // İkinci sayıyı alır
            double result = num1 + num2; // Toplamı hesaplar
            Console.WriteLine($"Result: {num1} + {num2} = {result}"); // Sonucu gösterir
        }

        // Çıkarma işlemini gerçekleştirir
        internal void Subtract()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine()); // İlk sayıyı alır
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine()); // İkinci sayıyı alır
            double result = num1 - num2; // Farkı hesaplar
            Console.WriteLine($"Result: {num1} - {num2} = {result}"); // Sonucu gösterir
        }

        // Bölme işlemini gerçekleştirir
        internal void Divide()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine()); // İlk sayıyı alır
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine()); // İkinci sayıyı alır

            if (num2 != 0) // Sıfıra bölme hatasını önlemek için kontrol
            {
                double result = num1 / num2; // Bölme işlemi
                Console.WriteLine($"Result: {num1} / {num2} = {result}"); // Sonucu gösterir
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed."); // Sıfıra bölme hatası mesajı
            }
        }

        // Çarpma işlemini gerçekleştirir
        internal void Multiply()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine()); // İlk sayıyı alır
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine()); // İkinci sayıyı alır
            double result = num1 * num2; // Çarpımı hesaplar
            Console.WriteLine($"Result: {num1} * {num2} = {result}"); // Sonucu gösterir
        }
    }
}
