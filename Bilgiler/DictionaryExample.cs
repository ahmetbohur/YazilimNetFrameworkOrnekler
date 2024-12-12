using System;
using System.Collections.Generic;

namespace YazilimNetFrameworkOrnekler.Bilgiler
{
    internal class DictionaryExample
    {
        /*
         Dictionary Nedir?
         
         Dictionary, C# programlama dilinde anahtar-değer (key-value) çiftlerini saklamak için kullanılan bir koleksiyon türüdür.
         Dictionary, benzersiz anahtarlar kullanarak değerleri hızlı bir şekilde erişmek için tasarlanmıştır.
         Anahtarlar benzersiz olmalıdır, ancak değerler aynı olabilir.
         
         Kullanım Alanları:
         - Verilere anahtarlar üzerinden erişim gerektiğinde
         - Hızlı arama ve güncelleme işlemleri için
         
         Dictionary Tanımı:
         Dictionary<TKey, TValue> sınıfı, TKey anahtar türü ve TValue değer türü ile çalışır.

         Temel Özellikler:
         - Add(key, value): Yeni bir anahtar-değer çifti ekler.
         - Remove(key): Belirtilen anahtarı ve değerini siler.
         - ContainsKey(key): Belirtilen anahtarın var olup olmadığını kontrol eder.
         - TryGetValue(key, out value): Anahtar mevcutsa, değeri döner.
         - Count: Toplam eleman sayısını döner.
        */

        private void BasicDictionaryUsage()
        {
            // Dictionary tanımlama ve eleman ekleme
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Ali");
            students.Add(2, "Ayse");
            students.Add(3, "Mehmet");

            Console.WriteLine("Dictionary İçeriği:");
            foreach (var student in students)
            {
                Console.WriteLine($"Numara: {student.Key}, İsim: {student.Value}");
            }

            // ContainsKey Kullanımı
            int searchKey = 2;
            if (students.ContainsKey(searchKey))
            {
                Console.WriteLine($"Anahtar {searchKey} mevcut, değer: {students[searchKey]}");
            }
            else
            {
                Console.WriteLine($"Anahtar {searchKey} mevcut değil.");
            }

            // Remove Kullanımı
            students.Remove(1);
            Console.WriteLine("1 numaralı öğrenci silindi. Güncel içerik:");
            foreach (var student in students)
            {
                Console.WriteLine($"Numara: {student.Key}, İsim: {student.Value}");
            }

            // TryGetValue Kullanımı
            if (students.TryGetValue(3, out string value))
            {
                Console.WriteLine($"3 numaralı öğrenci bulundu: {value}");
            }
            else
            {
                Console.WriteLine("3 numaralı öğrenci bulunamadı.");
            }

            // Eleman Sayısı
            Console.WriteLine($"Toplam öğrenci sayısı: {students.Count}");
        }

        private void AdvancedDictionaryUsage()
        {
            // Nested Dictionary Kullanımı
            Dictionary<int, Dictionary<string, string>> studentDetails = new Dictionary<int, Dictionary<string, string>>();

            studentDetails.Add(1, new Dictionary<string, string>
            {
                { "Name", "Ali" },
                { "Class", "10A" },
                { "Grade", "85" }
            });

            studentDetails.Add(2, new Dictionary<string, string>
            {
                { "Name", "Ayse" },
                { "Class", "10B" },
                { "Grade", "92" }
            });

            Console.WriteLine("Detaylı Öğrenci Bilgileri:");
            foreach (var student in studentDetails)
            {
                Console.WriteLine($"Öğrenci No: {student.Key}");
                foreach (var detail in student.Value)
                {
                    Console.WriteLine($"  {detail.Key}: {detail.Value}");
                }
            }
        }

        public void RunExamples()
        {
            Console.WriteLine("*** Basic Dictionary Usage ***");
            BasicDictionaryUsage();

            Console.WriteLine("\n*** Advanced Dictionary Usage ***");
            AdvancedDictionaryUsage();
        }
    }
}
