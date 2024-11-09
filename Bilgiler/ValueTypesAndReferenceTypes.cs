using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.Bilgiler
{
    /*
       Değer Tipleri ve Referans Tipleri

       Değer Tipleri (Value Types): 
       - Değer tipleri, kendi verilerini doğrudan tutar. 
       - Değer tiplerinin her biri bağımsız bir kopya oluşturur ve birbirlerinden bağımsızdır. 
       - Örnekler: int, float, double, char, bool, struct (yapılar)

       Referans Tipleri (Reference Types): 
       - Referans tipleri, verileri bir referans aracılığıyla tutar. 
       - Bir referans tipi değişkeni başka bir değişkenle aynı veri alanını paylaşabilir.
       - Örnekler: string, object, array, class, delegate, interface

       **Değer Tipleri**:
       - Değer tipleri genellikle stack (yığın) bellek üzerinde saklanır. 
       - Değer tipleri, bir değişken başka bir değişkene atandığında kopyalanır.

       **Referans Tipleri**:
       - Referans tipleri heap (yığın) bellek üzerinde saklanır.
       - Referans tipleri, bir değişken başka bir değişkene atandığında referansı (adres) kopyalar.

        Değer Tipi Örnekleri
        public int valueTypeInt = 10;          // Değer tipi: int
        public float valueTypeFloat = 3.14f;   // Değer tipi: float
        public double valueTypeDouble = 3.14159; // Değer tipi: double
        public bool valueTypeBool = true;      // Değer tipi: bool
        public char valueTypeChar = 'A';       // Değer tipi: char

        Referans Tipi Örnekleri
        public string referenceTypeString = "Hello, World!";  // Referans tipi: string
        public object referenceTypeObject = new object();     // Referans tipi: object
        public List<int> referenceTypeList = new List<int>();  // Referans tipi: List<int>
        public int[] referenceTypeArray = new int[3];          // Referans tipi: array
        public Person referenceTypeClass = new Person();       // Referans tipi: class

        public struct PersonStruct               // Yapı (struct) örneği: Değer tipi
        {
            public string Name;
            public int Age;
        }

        public class Person                       // Sınıf (class) örneği: Referans tipi
        {
            public string Name;
            public int Age;
        }

       Bu farkı anlamak için aşağıdaki örneği inceleyelim.

      */

    internal class ValueTypesAndReferenceTypes
    {
        // Değer Tipleri
        public int age = 25; // Değer tip: int
        public double price = 50.99; // Değer tip: double
        public char grade = 'A'; // Değer tip: char
        public bool isActive = true; // Değer tip: bool

        // Referans Tipleri
        public string playerName = "Player1"; // Referans tip: string
        public List<int> scores = new List<int>(); // Referans tip: List<T>
        public object data = "Sample Data"; // Referans tip: object
        public int[] numbers = new int[] { 1, 2, 3, 4, 5 }; // Referans tip: array

        // Değer ve Referans Tipi farklarını gösteren metod
        public void ShowTypes()
        {
            // Değer tipleri: Her biri kendi kopyasına sahiptir
            int x = age;
            x = 30;
            Console.WriteLine("Original age: " + age); // 25
            Console.WriteLine("New x value: " + x);   // 30

            // Referans tipleri: Aynı veri alanını paylaşır
            List<int> scoresCopy = scores;
            scores.Add(85);
            Console.WriteLine("Original scores: " + string.Join(", ", scores));   // [85]
            Console.WriteLine("Copy of scores: " + string.Join(", ", scoresCopy)); // [85]

            // Referans tipleri ve değer tipleri arasında atanacak farklı tipler
            Console.WriteLine("\nDemonstrating assignment between value and reference types:");

            // Değer tipleri arasındaki fark
            int a = 10;
            int b = a; // b'nin kopyası a'nın değeriyle başlatılır
            b = 20;
            Console.WriteLine($"Value types: a = {a}, b = {b}"); // a = 10, b = 20 (farklı kopyalar)

            // Referans tipleri arasındaki fark
            List<int> listA = new List<int> { 1, 2, 3 };
            List<int> listB = listA; // listB, listA'nın referansını alır
            listB.Add(4);
            Console.WriteLine($"Reference types: listA = {string.Join(", ", listA)}, listB = {string.Join(", ", listB)}");
            // listA = [1, 2, 3, 4], listB = [1, 2, 3, 4] (aynı listeyi paylaşıyorlar)
        }

        // Method to show data types in memory
        public void ShowMemoryUsage()
        {
            Console.WriteLine("\nMemory Usage Demonstration:");
            Console.WriteLine("Değer tipleri, stack üzerinde depolanır.");
            Console.WriteLine("Referans tipleri, heap üzerinde depolanır.");
            Console.WriteLine("Değer tiplerinin kopyalanması daha hızlıdır.");
            Console.WriteLine("Referans tiplerinin kopyalanması daha maliyetlidir, çünkü kopyalanan sadece adres olur.");
        }

    }
}
