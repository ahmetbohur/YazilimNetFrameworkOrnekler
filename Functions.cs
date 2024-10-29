using System;

namespace YazilimNetFrameworkOrnekler
{
    internal class Functions
    {
        /*
           Fonksiyonlar (Methodlar)

           Fonksiyonlar Nedir?
           Fonksiyonlar, belirli bir görevi yerine getirmek için bir araya getirilen kod bloklarıdır.
           Fonksiyonlar, kodun tekrar kullanılabilirliğini artırır ve kodun daha düzenli olmasına yardımcı olur.

           Fonksiyon Nasıl Tanımlanır - Fonksiyon Tanımlama Kuralları Nelerdir?

           [Erişim Belirleyici] [Veri Tipi] [Fonksiyon Adı]([Parametreler])
           {
               // Fonksiyonun içeriği
           }

           Erişim Belirleyici: Fonksiyonun erişim düzeyini belirler.
           Veri Tipi: Fonksiyonun geriye döndüreceği değerin türünü belirtir.
           Fonksiyon Adı: Fonksiyonun tanımlandığı isimdir.
           Parametreler: Fonksiyona dışarıdan veri geçmek için kullanılır.
        */

        // Toplama işlemi yapan bir fonksiyon
        public int Add(int a, int b)
        {
            return a + b;
        }

        // İki sayının ortalamasını hesaplayan bir fonksiyon
        public float CalculateAverage(float[] numbers)
        {
            float sum = 0f;
            foreach (float number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }

        // Metinleri birleştiren bir fonksiyon
        public string ConcatenateStrings(string str1, string str2)
        {
            return str1 + " " + str2;
        }

        // Belirli bir sayının karekökünü hesaplayan bir fonksiyon
        public float CalculateSquareRoot(float number)
        {
            return (float)Math.Sqrt(number);
        }

        // Fonksiyonları kullanma örnekleri
        public void DisplayFunctionsExamples()
        {
            int sum = Add(5, 10);
            Console.WriteLine("Sum: " + sum);

            float[] scores = { 85.5f, 90.0f, 78.0f };
            float average = CalculateAverage(scores);
            Console.WriteLine("Average Score: " + average);

            string fullName = ConcatenateStrings("John", "Doe");
            Console.WriteLine("Full Name: " + fullName);

            float squareRoot = CalculateSquareRoot(16.0f);
            Console.WriteLine("Square Root of 16: " + squareRoot);
        }
    }
}
