using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.Bilgiler
{
    internal class ActionAndDelegate
    {
        /*
         Action ve Delegate
         
         Action ve Delegate, C# programlama dilinde metotları referans etmek ve çağırmak için kullanılan yapısal öğelerdir.
         
         Delegate Nedir?
         Delegate, metotları referans etmek ve çağırmak için kullanılan bir referans türüdür. 
         Delegate'ler, metotları bir değişken gibi saklayabilir ve bu metotları çağırabilir. 
         Delegate'ler, metotları bir başka metoda parametre olarak geçmek veya geri dönüş değeri olarak kullanmak için kullanışlıdır.
         
         Action Nedir?
         Action, C# programlama dilinde önceden tanımlanmış bir delegate türüdür. 
         Action, geri dönüş değeri olmayan metotları referans etmek için kullanılır. 
         Action, 16 farklı parametre alabilen bir delegate türüdür ve bu parametrelerin sayısı ve türü değiştirilebilir.
         
         Action Kullanımı:
         Action<int, string> action = (x, y) => Console.WriteLine($"x: {x}, y: {y}");
         action(5, "Hello");
         
         Yukarıdaki örnekte, Action<int, string> türünde bir action değişkeni tanımlanmıştır. 
         Bu action değişkeni, int ve string türünde iki parametre alan ve geri dönüş değeri olmayan metotları referans edebilir. 
         action(5, "Hello") ifadesi ile action değişkeni, 5 ve "Hello" parametreleri ile çağrılmıştır.
         
         Delegate ve Action, metotları referans etmek ve çağırmak için kullanılan önemli yapısal öğelerdir. 
         Bu yapısal öğeler, C# programlama dilinde metotların dinamik olarak kullanılmasını sağlar.
         */

        // Delegate Tanımlaması
        public delegate void MessageDelegate(string message);

        // Delegate ile Çalışma
        private void ShowMessage(string message)
        {
            Console.WriteLine("Delegate ile gelen mesaj: " + message);
        }

        private void ActionNumberAddition(int number1, int number2, Action<int> result)
        {
            result?.Invoke(number1 + number2);
        }

        private void ActionNumberSubtraction(int number1, int number2, Action<int> result)
        {
            result?.Invoke(number1 - number2);
        }

        private void PrintResult(int result)
        {
            Console.WriteLine("Sonuç: " + result);
        }

        public void RunExamples()
        {
            // Delegate Kullanımı
            MessageDelegate messageDelegate = ShowMessage;
            messageDelegate("Merhaba, YazilimNetFramework!");

            // Action Kullanımı
            ActionNumberAddition(1, 2, (result) => Console.WriteLine("Toplam: " + result));
            ActionNumberAddition(3, 4, PrintResult);

            ActionNumberSubtraction(5, 3, (result) => {
                Console.WriteLine("Fark: " + result);
                }
            );
            ActionNumberSubtraction(10, 5, PrintResult);

        }
    }
}