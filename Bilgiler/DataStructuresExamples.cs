using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.Bilgiler
{
    internal class DataStructuresExamples
    {
        /*
    Queue, Stack, HashSet, LinkedList ve SortedList
         
    C# dilinde sıkça kullanılan bazı koleksiyon ve veri yapıları bulunmaktadır. Bu yapılar, farklı veri işleme senaryolarına uygun çözümler sunar. 
    Aşağıda açıklanan veri yapıları, belirli kullanım durumları için oldukça kullanışlıdır:
    
    - Queue (Kuyruk): 
      Queue, FIFO (First In, First Out) mantığına göre çalışan bir koleksiyon türüdür. Bu, ilk eklenen öğenin ilk çıkarılacağı anlamına gelir. 
      Kuyruklar genellikle işler veya görevler sırasıyla işlendiğinde kullanılır, örneğin bir görev kuyruğunda işler sırayla ele alınır.
      Queue, işlemleri sıralı bir şekilde işleme gereksinimi duyduğumuzda yaygın olarak kullanılır. 
      Kullanım örneği: Web sunucusu, gelen istekleri sırayla işler, önceden gelen istekler önce işlenir.

    - Stack (Yığın):
      Stack, LIFO (Last In, First Out) mantığına göre çalışan bir koleksiyon türüdür. Bu, son eklenen öğenin ilk çıkarılacağı anlamına gelir.
      Stack, özellikle geri alma (undo) ve ileri alma (redo) işlemleri gibi son yapılan işlemlerin ilk işleme mantığı gerektiren durumlarda kullanılır.
      Yığınlar, işlem geçmişini tutmak ve kullanıcı etkileşimlerine göre hızlıca geri dönmek için yaygın olarak kullanılır.
      Kullanım örneği: Tarayıcı geçmişi, son ziyaret edilen sayfalar önce geri alınır.

    - HashSet (Benzersiz Koleksiyon):
      HashSet, elemanların benzersiz olarak saklandığı ve sırasız bir koleksiyon yapısıdır. Aynı öğe birden fazla kez eklenemez, çünkü HashSet sadece benzersiz öğeleri kabul eder.
      Bu yapı, hızlı eleman ekleme ve sorgulama gereksinimleri için kullanılır. HashSet’ler, elemanların sırasız şekilde depolanmasına rağmen içeriklerin benzersiz olmasını sağlar.
      Kullanım örneği: E-posta adreslerinin benzersizliğini sağlamak için kullanılır. Bir kişi aynı e-posta adresine sahip olamaz.

    - LinkedList (Bağlantılı Liste):
      LinkedList, her elemanın bir sonraki öğe ile bağlantı kurduğu ve sırasıyla bağlı olduğu bir koleksiyon türüdür. Elemanlar sırasıyla eklenir ve listede gezinme işlemi için her elemanın bir "bağlantı" (referans) bilgisi bulunur.
      Bu yapı, sıralı verileri saklamak ve her pozisyonda hızlı ekleme veya silme işlemleri yapmak için idealdir.
      Kullanım örneği: Playlist'ler veya geçmişteki işlemler gibi sıralı ve dinamik bir yapıyı gerektiren durumlar.

    - SortedList (Sıralı Anahtar-Değer Çifti):
      SortedList, anahtar-değer çiftlerini sıralı bir şekilde saklayan bir koleksiyon yapısıdır. Elemanlar, eklenme sırasına değil, anahtar değerine göre sıralanır.
      Bu yapı, anahtarların sıralı olması gereken durumlar için idealdir. Anahtar-değer çiftlerinin sıralı bir şekilde depolanması ve hızlı bir şekilde erişilmesi gereken durumlarda kullanılır.
      Kullanım örneği: Sıralı ürün listeleri, ürünlere ait fiyatlar gibi anahtar-değer verilerini saklamak için kullanılır.
 
    Bu veri yapılarının her birinin kendine özgü avantajları vardır ve belirli kullanım senaryolarına göre tercih edilirler.
*/

        // Queue Kullanımı (Kuyruk)
        public void QueueExample()
        {
            Console.WriteLine("Queue (Kuyruk) Kullanımı:");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Bir");
            queue.Enqueue("İki");
            queue.Enqueue("Üç");

            // Eleman çıkarma (Dequeue) işlemi FIFO mantığı ile yapılır
            Console.WriteLine(queue.Dequeue()); // Bir
            Console.WriteLine(queue.Dequeue()); // İki
            Console.WriteLine(queue.Dequeue()); // Üç
        }

        // Stack Kullanımı (Yığın)
        public void StackExample()
        {
            Console.WriteLine("\nStack (Yığın) Kullanımı:");

            Stack<string> stack = new Stack<string>();
            stack.Push("Bir");
            stack.Push("İki");
            stack.Push("Üç");

            // Eleman çıkarma (Pop) işlemi LIFO mantığı ile yapılır
            Console.WriteLine(stack.Pop()); // Üç
            Console.WriteLine(stack.Pop()); // İki
            Console.WriteLine(stack.Pop()); // Bir
        }

        // HashSet Kullanımı (Benzersiz Koleksiyon)
        public void HashSetExample()
        {
            Console.WriteLine("\nHashSet (Benzersiz Koleksiyon) Kullanımı:");

            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);
            hashSet.Add(2); // Aynı öğe eklenemez, çünkü HashSet sadece benzersiz öğeleri kabul eder

            // Elemanlar sırasızdır, ancak benzersizdir
            foreach (var item in hashSet)
            {
                Console.WriteLine(item); // 1, 2, 3 (sıra değişebilir)
            }
        }

        // LinkedList Kullanımı
        public void LinkedListExample()
        {
            Console.WriteLine("\nLinkedList Kullanımı:");

            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("Bir");
            linkedList.AddLast("İki");
            linkedList.AddLast("Üç");

            // Elemanları baştan sona dolaşma
            foreach (var item in linkedList)
            {
                Console.WriteLine(item); // Bir, İki, Üç
            }

            // İlk elemana erişim
            LinkedListNode<string> firstNode = linkedList.First;
            Console.WriteLine($"İlk eleman: {firstNode.Value}");

            // Sonraki elemana erişim
            LinkedListNode<string> nextNode = firstNode.Next;
            Console.WriteLine($"İkinci eleman: {nextNode.Value}");
        }

        // SortedList Kullanımı (Sıralı Anahtar-Değer Çifti)
        public void SortedListExample()
        {
            Console.WriteLine("\nSortedList (Sıralı Anahtar-Değer Çifti) Kullanımı:");

            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(3, "Üç");
            sortedList.Add(1, "Bir");
            sortedList.Add(2, "İki");

            // Anahtarlara göre sıralı olarak erişim yapılır
            foreach (var kvp in sortedList)
            {
                Console.WriteLine($"Anahtar: {kvp.Key}, Değer: {kvp.Value}");
                // 1: Bir, 2: İki, 3: Üç (Anahtar sırasına göre)
            }
        }

        // Tüm veri yapıları örneklerini çalıştıran metod
        public void RunExamples()
        {
            QueueExample();
            StackExample();
            HashSetExample();
            LinkedListExample();
            SortedListExample();
        }
    }
}
