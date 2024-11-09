using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.Bilgiler
{
    /*
    ref ve out Anahtar Kelimeleri

    ref Anahtar Kelimesi:
    - **ref** anahtar kelimesi, bir metodun parametre olarak aldığı değerin dışarıya, yani metodun çağrıldığı yere geri dönmesini sağlar.
    - Bir parametre **ref** olarak tanımlandığında, metot içinde yapılan değişiklikler ana programda da geçerli olur.
    - **ref** parametrelerinin, metot çağrılmadan önce bir değere sahip olması gerekir.
    - **ref** ile gelen parametre metot içinde değiştirilebilir ve geri döndüğünde çağıran metoda güncel haliyle döner.

    ref Kullanımı:
    - ref parametreleri, metot çağrılmadan önce bir değere sahip olmalı ve bu değer metot içinde değiştirilip geri gönderilebilir.
    
    ref Örneği:
    public static void DoubleValue(ref int number)
    {
        number = number * 2;
    }

    static void Main()
    {
        int value = 5;
        DoubleValue(ref value);
        Console.WriteLine(value); // Çıktı: 10
    }

    out Anahtar Kelimesi:
    - **out** anahtar kelimesi, bir metodun parametresine değer atamasını zorunlu kılar.
    - **out** parametreleri, metot çağrılmadan önce bir değere sahip olmayabilirler. Ancak metot içinde kesinlikle bir değere atanmalıdır.
    - **out** parametreleri, metot sonunda değer döndürmek için kullanılır.
    - **out** parametreleri genellikle metotlarda birden fazla değeri geri döndürmek için kullanılır.
    
    out Kullanımı:
    - out parametreleri, metot çağrılmadan önce herhangi bir değere sahip olamaz, metot içinde bir değere atanmalıdır.
    
    out Örneği:
    public static void GetValues(out int number1, out int number2)
    {
        number1 = 5;
        number2 = 10;
    }

    static void Main()
    {
        int val1, val2;
        GetValues(out val1, out val2);
        Console.WriteLine($"Val1: {val1}, Val2: {val2}"); // Çıktı: Val1: 5, Val2: 10
    }

    ref ve out Arasındaki Farklar:
    1. **ref** parametreleri metot çağrılmadan önce bir değere sahip olmalı, metot içinde bu değeri değiştirebiliriz.
    2. **out** parametreleri metot çağrılmadan önce değeri olamayabilir, metot içinde kesinlikle bir değere atanmalıdır.
    3. **ref** ile parametreyi değiştirdiğimizde, bu değişiklik ana programda yansır ve çağrıldığında güncel değer ile döner.
    4. **out** ile parametreye metot içinde bir değer atanır ve metodun geri dönüş değeri olarak kullanılır.
*/


    class RefOutExample
    {
        // ref anahtar kelimesi ile metot parametrelerine değer aktarımı yapılır.
        // ref parametreleri, metot çağrıldığında değeri atanmış olmalıdır.
        public static void RefExample(ref int number)
        {
            // Ref ile gelen değeri değiştiriyoruz
            number = number * 2;
            Console.WriteLine("Ref ile gelen sayı 2 katına çıkarıldı: " + number);
        }

        // out anahtar kelimesi, metot içinde parametreye değer ataması yapılmasını sağlar.
        // out parametrelerinin, metot içinde kesinlikle bir değere atanmış olması gerekir.
        public static void OutExample(out int result)
        {
            // Out parametresi, metot içinde mutlaka bir değere atanmalıdır.
            result = 100;
            Console.WriteLine("Out ile atanmış sonuç: " + result);
        }

        static void OutRefExample()
        {
            // ref örneği
            int refNumber = 5;
            Console.WriteLine("Ref ile çağrılmadan önceki sayı: " + refNumber);

            // Ref metodu çağrısı
            RefExample(ref refNumber);
            Console.WriteLine("Ref ile çağrıldıktan sonraki sayı: " + refNumber);
            Console.WriteLine();

            // out örneği
            int outResult;
            Console.WriteLine("Out ile çağrılmadan önceki değer: (değer atanmamış)");

            // Out metodu çağrısı
            OutExample(out outResult);
            Console.WriteLine("Out ile çağrıldıktan sonraki değer: " + outResult);
        }
    }
}
