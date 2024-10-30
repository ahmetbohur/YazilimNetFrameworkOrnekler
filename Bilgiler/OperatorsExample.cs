/*
    Operatörler (Operators)

    Operatör Nedir?
    Operatörler, değişkenler ve değerler üzerinde işlem yapmamızı sağlayan özel sembollerdir.
    Farklı türde işlemler gerçekleştirmek için çeşitli operatörler kullanılır.

    Operatör Türleri:

    1. Aritmetik Operatörler:
       Aritmetik işlemler yapmak için kullanılır.
       - Toplama (+): İki sayıyı toplar.
       - Çıkarma (-): İki sayıdan birini çıkarır.
       - Çarpma (*): İki sayıyı çarpar.
       - Bölme (/): Bir sayıyı diğerine böler.
       - Modül (%): İki sayı arasındaki kalanı bulur.

    2. Karşılaştırma Operatörleri:
       İki değeri karşılaştırmak için kullanılır.
       - Eşit mi? (==): İki değerin eşit olup olmadığını kontrol eder.
       - Eşit değil mi? (!=): İki değerin eşit olmadığını kontrol eder.
       - Büyüktür (>): İlk değerin ikinci değerden büyük olup olmadığını kontrol eder.
       - Küçüktür (<): İlk değerin ikinci değerden küçük olup olmadığını kontrol eder.
       - Büyük veya eşit mi? (>=): İlk değerin ikinci değerden büyük veya ona eşit olup olmadığını kontrol eder.
       - Küçük veya eşit mi? (<=): İlk değerin ikinci değerden küçük veya ona eşit olup olmadığını kontrol eder.

    3. Mantıksal Operatörler:
       Koşullu ifadeleri birleştirmek için kullanılır.
       - Mantıksal AND (&&): Her iki koşul da doğruysa true döner.
       - Mantıksal OR (||): Herhangi bir koşul doğruysa true döner.
       - Mantıksal NOT (!): Koşulun tersini döner.

    4. Atama Operatörleri:
       Değişkenlere değer atamak için kullanılır.
       - Atama (=): Bir değeri bir değişkene atar.
       - Toplayarak atama (+=): Mevcut değeri belirtilen değerle toplar ve sonucu değişkene atar.
       - Çıkarak atama (-=): Mevcut değeri belirtilen değer kadar çıkarır ve sonucu değişkene atar.
       - Çarparak atama (*=): Mevcut değeri belirtilen değerle çarpar ve sonucu değişkene atar.
       - Bölerek atama (/=): Mevcut değeri belirtilen değere böler ve sonucu değişkene atar.
       - Modül atama (%=): Mevcut değeri belirtilen değerin modülünü alır ve sonucu değişkene atar.

    5. Artırma ve Azaltma Operatörleri:
       Değişkenin değerini artırmak veya azaltmak için kullanılır.
       - Artırma (++) : Değişkenin değerini 1 artırır.
       - Azaltma (--) : Değişkenin değerini 1 azaltır.

    6. Diğer Operatörler:
       - Koşul operatörü (ternary): Belirli bir koşula bağlı olarak iki değer arasında seçim yapmak için kullanılır. 
         Örnek: (koşul) ? değer1 : değer2;
       - Null-coalescing operatörü (??): Bir değerin null olup olmadığını kontrol eder ve null ise alternatif bir değer döner.
       - Tür kontrolü (is): Bir nesnenin belirli bir türde olup olmadığını kontrol eder.
       - Tür dönüşümü (as): Bir nesneyi belirtilen türde bir değişkene dönüştürmeye çalışır, dönüşüm mümkün değilse null döner.

    Örnek Operatör Kullanımı:
    - Aritmetik operatörler, matematiksel hesaplamalar için kullanılır.
    - Karşılaştırma operatörleri, iki değerin karşılaştırılması için idealdir.
    - Mantıksal operatörler, koşulları birleştirmek için kullanılır.
    - Atama operatörleri, bir değeri bir değişkene atamak için hızlı bir yol sunar.
    - Artırma ve azaltma operatörleri, sayısal değerlerin güncellenmesi için yaygın olarak kullanılır.
    - Diğer operatörler ise özel durumlar için pratik çözümler sağlar.
*/

using System;

namespace YazilimNetFrameworkOrnekler
{
    class OperatorsExample
    {
        public void DisplayOperatorsExample()
        {
            // Aritmetik Operatörler Örnekleri
            int a = 10, b = 5;
            Console.WriteLine("Toplama: " + (a + b)); // 15
            Console.WriteLine("Çıkarma: " + (a - b)); // 5
            Console.WriteLine("Çarpma: " + (a * b)); // 50
            Console.WriteLine("Bölme: " + (a / b)); // 2
            Console.WriteLine("Modül: " + (a % b)); // 0

            // Karşılaştırma Operatörleri Örnekleri
            Console.WriteLine("Eşit mi?: " + (a == b)); // false
            Console.WriteLine("Eşit değil mi?: " + (a != b)); // true
            Console.WriteLine("Büyüktür: " + (a > b)); // true
            Console.WriteLine("Küçüktür: " + (a < b)); // false

            // Mantıksal Operatörler Örnekleri
            bool condition1 = true, condition2 = false;
            Console.WriteLine("Mantıksal AND: " + (condition1 && condition2)); // false
            Console.WriteLine("Mantıksal OR: " + (condition1 || condition2)); // true

            // Atama Operatörleri Örnekleri
            a = 10; // Başlangıç değeri
            Console.WriteLine("Atama: " + (a = 5)); // 5
            a += 5; // 5 + 5
            Console.WriteLine("Toplayarak atama: " + a); // 10
        }
    }
}