using System;

namespace YazilimNetFrameworkOrnekler
{
    /*
    Koşul İfadeleri (If-Else, Else If ve Switch-Case)

    If-Else: Belirli bir koşulun doğru veya yanlış olup olmadığını kontrol etmek için kullanılır.
    Genel yapı:
    if (koşul)
    {
        // Koşul doğruysa çalışacak kod
    }
    else if (koşul2)
    {
        // İkinci koşul doğruysa çalışacak kod
    }
    else
    {
        // Koşullar sağlanmazsa çalışacak kod
    }

    Switch-Case: Bir değişkenin değerine göre farklı durumlara göre farklı kod blokları çalıştırmak için kullanılır.
    Genel yapı:
    switch (değişken)
    {
        case değer1:
            // değer1 için çalışacak kod
            break;
        case değer2:
            // değer2 için çalışacak kod
            break;
        default:
            // Hiçbir koşul sağlanmazsa çalışacak kod
            break;
    }

    Koşul Operatörleri:
    - < (Küçük): Bir sayının başka bir sayıdan küçük olup olmadığını kontrol eder.
    - > (Büyük): Bir sayının başka bir sayıdan büyük olup olmadığını kontrol eder.
    - <= (Küçük veya Eşit): Bir sayının başka bir sayıdan küçük veya ona eşit olup olmadığını kontrol eder.
    - >= (Büyük veya Eşit): Bir sayının başka bir sayıdan büyük veya ona eşit olup olmadığını kontrol eder.
    - == (Eşit): İki değerin birbirine eşit olup olmadığını kontrol eder.
    - != (Eşit Değil): İki değerin birbirine eşit olmadığını kontrol eder.
    
    Mantıksal Operatörler:
    - && (Mantıksal VE): Her iki koşulun da doğru olması durumunda true döner.
    - || (Mantıksal VEYA): Koşullardan en az birinin doğru olması durumunda true döner.
    
    Örnek Kullanım:
    if (a > 10 && b < 20) // a 10'dan büyük ve b 20'den küçükse
    {
        // Kod burada çalışır
    }
    if (a < 5 || b > 15) // a 5'ten küçük veya b 15'ten büyükse
    {
        // Kod burada çalışır
    }
    */

    class ConditionalStatementsExample
    {
        // Değişken Tanımları
        public static int playerScore = 85; // Oyuncunun puanı

        static void RunConditionalStatementsExample(string[] args)
        {
            // If-Else ve Else If Örneği
            if (playerScore >= 90)
            {
                Console.WriteLine("Mükemmel! Puanınız 90 ve üzeri.");
            }
            else if (playerScore >= 75 && playerScore < 90) // 75 ile 89 arasında
            {
                Console.WriteLine("İyi iş! Puanınız 75 ile 89 arasında.");
            }
            else if (playerScore >= 50 && playerScore < 75) // 50 ile 74 arasında
            {
                Console.WriteLine("Geçtiniz. Puanınız 50 ile 74 arasında.");
            }
            else
            {
                Console.WriteLine("Üzgünüm, geçemediniz. Puanınız 49 ve altı.");
            }

            // Switch-Case Örneği
            string grade;

            switch (playerScore / 10)
            {
                case 10:
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                case 6:
                    grade = "D";
                    break;
                default:
                    grade = "F";
                    break;
            }

            Console.WriteLine("Oyuncunun notu: " + grade);
        }
    }
}
