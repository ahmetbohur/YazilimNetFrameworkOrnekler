using System;
using System.Collections.Generic;

namespace LoopsExampleNamespace
{
    public class LoopsExample
    {
        /*
           Döngüler (Loops)
           
           Döngüler Nedir?
           Döngüler, belirli bir koşul sağlandığı sürece belirli bir kod bloğunu tekrar tekrar çalıştırmak için kullanılır. 
           Programlama dillerinde yaygın olarak kullanılan döngü türleri arasında `for`, `foreach`, `while` ve `do-while` döngüleri bulunmaktadır.

           1. for Döngüsü:
           `for` döngüsü, belirli bir sayıda tekrarı ifade eder. Genellikle bir sayaç kullanarak belirli bir koşul sağlandığı sürece döngüyü çalıştırır.
           
           Yapısı:
           for (başlangıç_değeri; koşul; artış) {
               // Tekrar eden kod bloğu
           }

           Örnek:
           for (int i = 0; i < 5; i++) {
               Console.WriteLine("i: " + i);
           }

           2. foreach Döngüsü:
           `foreach` döngüsü, bir koleksiyonun (örneğin, dizi veya liste) her bir elemanı üzerinde döngü kurmak için kullanılır.
           
           Yapısı:
           foreach (veri_tipi eleman in koleksiyon) {
               // Tekrar eden kod bloğu
           }

           Örnek:
           List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
           foreach (string name in names) {
               Console.WriteLine("Name: " + name);
           }

           3. while Döngüsü:
           `while` döngüsü, belirli bir koşul doğru olduğu sürece döngüyü çalıştırır.
           
           Yapısı:
           while (koşul) {
               // Tekrar eden kod bloğu
           }

           Örnek:
           int count = 0;
           while (count < 5) {
               Console.WriteLine("Count: " + count);
               count++;
           }

           4. do-while Döngüsü:
           `do-while` döngüsü, kod bloğunu en az bir kez çalıştırır ve ardından koşulu kontrol eder.
           
           Yapısı:
           do {
               // Tekrar eden kod bloğu
           } while (koşul);

           Örnek:
           int number = 0;
           do {
               Console.WriteLine("Number: " + number);
               number++;
           } while (number < 5);
        */

        public void RunLoopsExample()
        {
            // for döngüsü örneği
            Console.WriteLine("For Döngüsü:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i: " + i);
            }

            // foreach döngüsü örneği
            Console.WriteLine("\nForeach Döngüsü:");
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            foreach (string name in names)
            {
                Console.WriteLine("Name: " + name);
            }

            // while döngüsü örneği
            Console.WriteLine("\nWhile Döngüsü:");
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("Count: " + count);
                count++;
            }

            // do-while döngüsü örneği
            Console.WriteLine("\nDo-While Döngüsü:");
            int number = 0;
            do
            {
                Console.WriteLine("Number: " + number);
                number++;
            } while (number < 5);
        }
    }

}
