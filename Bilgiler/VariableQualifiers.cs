using System;

namespace YazilimNetFrameworkOrnekler
{
    internal class VariableQualifiers
    {
        /*
            Değişken Nitelikleri (Variable Qualifiers)

            1. static: 
               - Sınıf düzeyinde bir değişkendir, tüm örnekler tarafından paylaşılır.
            2. const:
               - Sabit bir değeri temsil eder ve bir kez atandıktan sonra değiştirilemez.
            3. readonly:
               - Yalnızca tanımlandığı yapıcıda atanabilir ve daha sonra değiştirilemez.
            4. volatile:
               - Değeri her zaman ana bellekten okunmalıdır, çoklu iş parçacığı kullanımlarında tercih edilir.
            5. dynamic:
               - Türü çalışma zamanında belirlenen değişkeni temsil eder.
        */

        // Değişken Tanımları
        public static int staticVariable = 10;                // Statik değişken
        public const float constantValue = 3.14f;             // Sabit değişken
        public readonly int readOnlyVariable;                 // Sadece bir kez atanabilir
        public volatile int volatileVariable;                 // Çok iş parçacıklı kullanımlar için değişken
        private dynamic dynamicVariable = "Initial Value";    // Dinamik türde değişken

        // Yapıcı
        public VariableQualifiers()
        {
            readOnlyVariable = 100;  // Yapıcıda atanabilir
        }

        public void DisplayVariableQualifiers()
        {
            Console.WriteLine("Static Variable: " + staticVariable);          // Statik değişkenin kullanımı
            Console.WriteLine("Constant Value: " + constantValue);            // Sabit değişkenin kullanımı
            Console.WriteLine("Read Only Variable: " + readOnlyVariable);     // ReadOnly değişkenin kullanımı
            Console.WriteLine("Volatile Variable: " + volatileVariable);      // Volatile değişkenin kullanımı
            Console.WriteLine("Dynamic Variable: " + dynamicVariable);        // Dinamik değişkenin kullanımı

            // Dinamik değişkenin değerini değiştirme
            dynamicVariable = 42;  // Şimdi bir tam sayı olabilir
            Console.WriteLine("Dynamic Variable (after change): " + dynamicVariable);
        }
    }
}
