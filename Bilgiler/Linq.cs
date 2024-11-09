using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.Bilgiler
{
    /*
          LINQ (Language Integrated Query) Nedir?
          LINQ, C# içerisinde veri sorgulamak ve işlemek için kullanılan bir yapıdır. 
          Farklı veri kaynaklarına (List, Array, XML, SQL vb.) sorgular yazarak hızlı ve kolay veri çekmek veya manipüle etmek mümkündür.

          LINQ Yöntemleri:

          - Where: Belirtilen koşula uyan elemanları seçip filtreler.

          - Select: Elemanları belirli bir işleme tabi tutarak projekte eder,
            yani her elemanı verilen bir fonksiyona göre dönüştürür.

          - OrderBy: Elemanları artan sırada sıralar.

          - OrderByDescending: Elemanları azalan sırada sıralar.

          - ThenBy: OrderBy'den sonra gelen elemanlar için ek bir artan sıralama sağlar,
            yani ikincil sıralama kriteri olarak kullanılır.

          - ThenByDescending: OrderBy veya ThenBy'den sonra ek bir azalan sıralama sağlar,
            yani ikincil sıralama kriteri olarak kullanılır.

          - GroupBy: Elemanları belirtilen kritere göre gruplar,
            her grup aynı kritere uyan elemanlardan oluşur.

          - Join: İki koleksiyonu belirli bir kritere göre birleştirir,
            özellikle iki veri kaynağı arasında ilişkisel veri çekmek için kullanılır.

          - Sum: Koleksiyondaki sayıların toplamını döndürür.

          - Average: Koleksiyondaki sayıların ortalamasını döndürür.

          - Count: Belirtilen koşula uyan eleman sayısını döndürür.

          - Max: Koleksiyondaki en büyük değeri döndürür.

          - Min: Koleksiyondaki en küçük değeri döndürür.

          - Take: Koleksiyonun başından itibaren belirtilen sayıda elemanı alır.

          - Skip: Koleksiyonun başından itibaren belirtilen sayıda elemanı atlar ve kalan elemanları döndürür.

          - Any: Koleksiyonda belirtilen koşula uyan en az bir eleman olup olmadığını kontrol eder,
            true veya false döner.

          - All: Koleksiyondaki tüm elemanların belirtilen koşula uyup uymadığını kontrol eder,
            true veya false döner.

          - First: Koleksiyondaki ilk elemanı döndürür, koşul varsa ona uyan ilk eleman döner. 
            Koleksiyon boşsa hata verir.

          - FirstOrDefault: İlk elemanı döndürür, yoksa varsayılan değeri döndürür,
            yani boşsa null veya default değer döner.

          - Last: Koleksiyondaki son elemanı döndürür, koşul varsa ona uyan son eleman döner.
            Koleksiyon boşsa hata verir.

          - LastOrDefault: Son elemanı döndürür, yoksa varsayılan değeri döndürür,
            yani boşsa null veya default değer döner.

          - Distinct: Koleksiyondaki tekrar eden elemanları kaldırır, sadece benzersiz elemanları döndürür.

          - Concat: İki koleksiyonu birleştirir ve yeni bir koleksiyon döndürür.
       */

    internal class Linq
    {

        internal void LinqExamples()
        {
            Console.WriteLine("Linq Konu Anlatım");

            CiftSayilariFiltrele();
            CiftSayilariSirala();
            IsimUzunluklariniBul();
            IsimFiltreleVeBuyukHarfYap();
            OndanBuyukSayiVarMi();
            HepsiSifirdanBuyukMu();
            AileBaslayanIlkMeyve();
            GileBaslayanIlkMeyveVeyaVarsa();
            OndanBuyukSayilariSay();
            UcAtlaYedisiniAl();
            MinimumDegeriBul();
            MaksimumDegeriBul();
            OrtalamaDegeriBul();
        }

        internal void LinqMethodsExamples()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> names = new List<string> { "Ali", "Ayşe", "Mehmet", "Fatma", "Ahmet", "Aylin" };

            /* Where: Belirtilen koşula uyan elemanları seçip filtreler */
            var ciftSayilar = numbers.Where(n => n % 2 == 0).ToList();

            /* Select: Elemanları belirli bir işleme tabi tutarak projekte eder,
             * yani her elemanı verilen bir fonksiyona göre dönüştürür.
             */
            var sayiKareleri = numbers.Select(n => n * n).ToList();

            /* OrderBy: Elemanları artan sırada sıralar. */
            var artanSiraliSayilar = numbers.OrderBy(n => n).ToList();

            /* OrderByDescending: Elemanları azalan sırada sıralar. */
            var azalanSiraliSayilar = numbers.OrderByDescending(n => n).ToList();

            /* ThenBy: OrderBy'den sonra gelen elemanlar için ek bir artan sıralama sağlar,
             * yani ikincil sıralama kriteri olarak kullanılır.
             */
            var isimlerSirali = names.OrderBy(name => name.Length).ThenBy(name => name).ToList();

            /* ThenByDescending: OrderBy veya ThenBy'den sonra ek bir azalan sıralama sağlar,
             * yani ikincil sıralama kriteri olarak kullanılır.
             */
            var tersIsimSirasi = names.OrderBy(name => name.Length).ThenByDescending(name => name).ToList();

            /* GroupBy: Elemanları belirtilen kritere göre gruplar,
             * her grup aynı kritere uyan elemanlardan oluşur.
             */
            var uzunlugaGoreGrupla = names.GroupBy(name => name.Length);

            /* Join: İki koleksiyonu belirli bir kritere göre birleştirir,
             * özellikle iki veri kaynağı arasında ilişkisel veri çekmek için kullanılır.
             */
            List<int> ids = new List<int> { 1, 2, 3 };
            List<string> namesById = new List<string> { "Ali", "Ayşe", "Mehmet" };
            var idAdlariBirlesik = ids.Join(
                namesById,
                id => ids.IndexOf(id),
                name => namesById.IndexOf(name),
                (id, name) => new { Id = id, Name = name });

            /* Sum: Koleksiyondaki sayıların toplamını döndürür. */
            var toplam = numbers.Sum();

            /* Average: Koleksiyondaki sayıların ortalamasını döndürür. */
            var ortalama = numbers.Average();

            /* Count: Belirtilen koşula uyan eleman sayısını döndürür. */
            var tekSayilarSayisi = numbers.Count(n => n % 2 != 0);

            /* Max: Koleksiyondaki en büyük değeri döndürür. */
            var maxSayi = numbers.Max();

            /* Min: Koleksiyondaki en küçük değeri döndürür. */
            var minSayi = numbers.Min();

            /* Take: Koleksiyonun başından itibaren belirtilen sayıda elemanı alır. */
            var ilkBesSayi = numbers.Take(5).ToList();

            /* Skip: Koleksiyonun başından itibaren belirtilen sayıda elemanı atlar ve kalan elemanları döndürür. */
            var sonBesSayi = numbers.Skip(5).ToList();

            /* Any: Koleksiyonda belirtilen koşula uyan en az bir eleman olup olmadığını kontrol eder,
             * true veya false döner.
             */
            var tekSayiVarMi = numbers.Any(n => n % 2 != 0);

            /* All: Koleksiyondaki tüm elemanların belirtilen koşula uyup uymadığını kontrol eder,
             * true veya false döner.
             */
            var hepsiPozitifMi = numbers.All(n => n > 0);

            /* First: Koleksiyondaki ilk elemanı döndürür, koşul varsa ona uyan ilk eleman döner. 
             * Koleksiyon boşsa hata verir.
             */
            var ilkSayi = numbers.First();

            /* FirstOrDefault: İlk elemanı döndürür, yoksa varsayılan değeri döndürür,
             * yani boşsa null veya default değer döner.
             */
            var ilkCiftSayi = numbers.FirstOrDefault(n => n % 2 == 0);

            /* Last: Koleksiyondaki son elemanı döndürür, koşul varsa ona uyan son eleman döner.
             * Koleksiyon boşsa hata verir.
             */
            var sonSayi = numbers.Last();

            /* LastOrDefault: Son elemanı döndürür, yoksa varsayılan değeri döndürür,
             * yani boşsa null veya default değer döner.
             */
            var sonTekSayi = numbers.LastOrDefault(n => n % 2 != 0);

            /* Distinct: Koleksiyondaki tekrar eden elemanları kaldırır, sadece benzersiz elemanları döndürür. */
            var benzersizSayilar = numbers.Distinct().ToList();

            /* Concat: İki koleksiyonu birleştirir ve yeni bir koleksiyon döndürür. */
            var birlesikListe = numbers.Concat(new List<int> { 11, 12, 13 }).ToList();
        }

        // Çift sayıları filtreler
        private void CiftSayilariFiltrele()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Çift Sayılar: " + string.Join(",", evenNumbers));
        }

        // Çift sayıları sıralar (büyükten küçüğe)
        private void CiftSayilariSirala()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sortedEvenNumbers = numbers.Where(n => n % 2 == 0).OrderByDescending(n => n);
            Console.WriteLine("Sıralı Çift Sayılar: " + string.Join(",", sortedEvenNumbers));
        }

        // İsimlerin uzunluklarını liste olarak alır
        private void IsimUzunluklariniBul()
        {
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };
            var nameLenghts = names.Select(name => name.Length).ToList();
            Console.WriteLine("İsim Uzunlukları: " + string.Join(",", nameLenghts));
        }

        // İsmi uzunluğu 4'ten büyük olanları büyük harf yapar
        private void IsimFiltreleVeBuyukHarfYap()
        {
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };
            var filteredAndUppercaseNames = names.Where(name => name.Length > 4).Select(name => name.ToUpper());
            Console.WriteLine("Filtrelenmiş ve Büyük Harfli İsimler: " + string.Join(",", filteredAndUppercaseNames));
        }

        // Listede 10'dan büyük sayı olup olmadığını kontrol eder
        private void OndanBuyukSayiVarMi()
        {
            List<int> numbers2 = new List<int> { 15, 2, 3, 6, 8, 12, 7, 9 };
            bool anyGreaterThanTen = numbers2.Any(n => n > 10);
            Console.WriteLine("10'dan Büyük Sayi Var mı: " + anyGreaterThanTen);
        }

        // Listedeki tüm sayıların sıfırdan büyük olup olmadığını kontrol eder
        private void HepsiSifirdanBuyukMu()
        {
            List<int> numbers2 = new List<int> { 15, 2, 3, 6, 8, 12, 7, 9 };
            bool allGreaterThanZero = numbers2.All(n => n > 0);
            Console.WriteLine("Hepsi Sıfırdan Büyük mü: " + allGreaterThanZero);
        }

        // "A" harfi ile başlayan ilk meyveyi bulur
        private void AileBaslayanIlkMeyve()
        {
            List<string> fruits = new List<string> { "Apple", "Orange", "Banana", "Pineapple", "Strawberry", "Apricot" };
            string firstStartingWithA = fruits.First(f => f.StartsWith("A"));
            Console.WriteLine("A ile Başlayan İlk Meyve: " + firstStartingWithA);
        }

        // "G" harfi ile başlayan ilk meyveyi bulur, yoksa null döner
        private void GileBaslayanIlkMeyveVeyaVarsa()
        {
            List<string> fruits = new List<string> { "Apple", "Orange", "Banana", "Pineapple", "Strawberry", "Apricot" };
            string firstStartingWithG = fruits.FirstOrDefault(f => f.StartsWith("G"));
            Console.WriteLine("G ile Başlayan İlk Meyve (Varsa): " + (firstStartingWithG ?? "Yok"));
        }

        // 10'dan büyük olan sayıların sayısını bulur
        private void OndanBuyukSayilariSay()
        {
            List<int> numbers3 = new List<int> { 10, 7, 15, 9, 4, 14, 5 };
            int countGreaterThanNine = numbers3.Count(n => n > 10);
            Console.WriteLine("10'dan Büyük Olan Sayıların Sayısı: " + countGreaterThanNine);
        }

        // İlk 3 sayıyı atlar ve sonraki 7 sayıyı alır
        private void UcAtlaYedisiniAl()
        {
            List<int> numbers4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            IEnumerable<int> skipAndTakeNumbers = numbers4.Skip(3).Take(7);
            Console.WriteLine("3 Atla ve 7 Al: " + string.Join(",", skipAndTakeNumbers));
        }

        // Listenin minimum değerini bulur
        private void MinimumDegeriBul()
        {
            List<int> numbersMinMax = new List<int> { 3, 1, 4, 2, 5 };
            int min = numbersMinMax.Min();
            Console.WriteLine("Minimum Değer: " + min);
        }

        // Listenin maksimum değerini bulur
        private void MaksimumDegeriBul()
        {
            List<int> numbersMinMax = new List<int> { 3, 1, 4, 2, 5 };
            int max = numbersMinMax.Max();
            Console.WriteLine("Maksimum Değer: " + max);
        }

        // Listenin ortalama değerini bulur
        private void OrtalamaDegeriBul()
        {
            List<int> numbersAverage = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double average = numbersAverage.Average();
            Console.WriteLine("Ortalama Değer: " + average);
        }

    }
}
