/*
    Try-Catch Yapısı (Try-Catch Statement)

    Try-Catch Nedir?
    Try-Catch yapısı, programlarda hata yönetimi sağlamak için kullanılan bir kontrol yapısıdır.
    Bu yapı, programın beklenmedik durumlarda çökmesini önler ve hataların kontrol altına alınmasını sağlar.

    Try Bloğu:
    - Hata alabilecek kodların yer aldığı bloktur.
    - Eğer bu blok içindeki kodlarda bir hata oluşursa, kontrol Catch bloğuna geçer.

    Catch Bloğu:
    - Try bloğunda bir hata meydana geldiğinde çalışan kod bloğudur.
    - Bir veya birden fazla Catch bloğu tanımlanabilir ve belirli hata türlerine göre özelleştirilebilir.

    Finally Bloğu (İsteğe Bağlı):
    - Try veya Catch bloğundan sonra her durumda çalışacak olan kodları içerir.
    - Kaynakların serbest bırakılması veya belirli temizlik işlemleri için kullanılır.

    Örnek Senaryo:
    - Kullanıcıdan bir sayı alınıp bu sayıya 10 bölünmeye çalışılır.
    - Kullanıcı sıfır girerse, bir hata meydana gelir ve bu hata Catch bloğu tarafından yakalanır.

    Kullanım Örneği:
*/

using System;

namespace YazilimNetFrameworkOrnekler
{
    class TryCatchExample
    {
        public void DisplayTryCatchExample()
        {
            try
            {
                Console.Write("Bir sayı girin: ");
                int number = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan sayı alma
                int result = 10 / number; // Kullanıcının girdiği sayıya bölme
                Console.WriteLine($"Sonuç: {result}");
            }
            catch (FormatException ex) // Hatalı format durumu için
            {
                Console.WriteLine("Hata: Lütfen geçerli bir sayı girin.");
                Console.WriteLine("Hata Mesajı: " + ex.Message);
            }
            catch (DivideByZeroException ex) // Sıfıra bölme hatası için
            {
                Console.WriteLine("Hata: Sıfıra bölme hatası meydana geldi!");
                Console.WriteLine("Hata Mesajı: " + ex.Message);
            }
            catch (Exception ex) // Diğer hatalar için genel bir yakalama
            {
                Console.WriteLine("Bir hata meydana geldi: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program sona erdi.");
            }
        }
    }
}
