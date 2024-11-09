using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.Bilgiler
{
    /*
      Polimorfizm Nedir?

      Polimorfizm, nesne yönelimli programlamada aynı isimdeki metodların, farklı türlerdeki nesneler için farklı davranışlar sergileyebilmesini sağlayan bir kavramdır. 
      Başka bir deyişle, bir nesne birden fazla formda (ya da türde) davranabilir. 

      Polimorfizm, genellikle türetilmiş sınıflarda (alt sınıflarda) geçersiz kılma (override) yoluyla uygulanır. 
      Bu sayede, üst sınıftan (base class) türetilen sınıflar, aynı isimli metodları kendi ihtiyaçlarına göre farklı şekilde uygulayabilirler.

      Polimorfizm Örnek Kullanımı:
      - Temel sınıf (base class) ve türetilmiş sınıflar (derived classes) arasında, aynı metod adı kullanılarak farklı davranışlar elde edilir.
      - Bu kavram, kodun esnekliğini artırır ve genellikle daha az kod tekrarı ile daha geniş kapsamlı çözümler geliştirilmesine olanak sağlar.

      Polimorfizm iki şekilde uygulanabilir:
      1. **Metod Overriding (Geçersiz Kılma)**: Türetilmiş sınıflarda, temel sınıfın metodunun üzerine yazılması.
      2. **Metod Overloading (Aşırı Yükleme)**: Aynı metod adıyla farklı parametrelerle birden fazla metod tanımlanması.

      Aşağıdaki örnekte, polimorfizmi `Animal` sınıfı ve onun türetilmiş alt sınıfları (Dog, Cat, Bird) üzerinden görüyoruz.

      */

    // Temel sınıf (Base Class) olan Animal
    public class Animal
    {
        // Sanal bir metot tanımlıyoruz (virtual). Bu metot, alt sınıflarda geçersiz kılınabilir.
        public virtual void MakeSound()
        {
            Console.WriteLine("Hayvan ses çıkarıyor.");
        }
    }

    // Animal sınıfından türetilmiş bir alt sınıf olan Dog
    public class Dog : Animal
    {
        // Dog sınıfı, Animal sınıfındaki MakeSound metodunu geçersiz kılar (override)
        public override void MakeSound()
        {
            Console.WriteLine("Hav hav!");
        }
    }

    // Animal sınıfından türetilmiş bir alt sınıf olan Cat
    public class Cat : Animal
    {
        // Cat sınıfı, Animal sınıfındaki MakeSound metodunu geçersiz kılar (override)
        public override void MakeSound()
        {
            Console.WriteLine("Miyav!");
        }
    }

    // Animal sınıfından türetilmiş bir alt sınıf olan Bird
    public class Bird : Animal
    {
        // Bird sınıfı, Animal sınıfındaki MakeSound metodunu geçersiz kılar (override)
        public override void MakeSound()
        {
            Console.WriteLine("Cik cik!");
        }
    }


    public class AnyAnimal : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
        }

    }

        class Polimorfizm
    {
        static void PolimorfizmExample()
        {
            // Polimorfizm kullanarak Animal türünden nesneler oluşturuyoruz
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();    // Dog türünde bir nesne oluşturuluyor, ancak Animal türünde referans alınıyor
            Animal myCat = new Cat();    // Cat türünde bir nesne oluşturuluyor, ancak Animal türünde referans alınıyor
            Animal myBird = new Bird();  // Bird türünde bir nesne oluşturuluyor, ancak Animal türünde referans alınıyor
            Animal anyAnimal = new AnyAnimal(); // Herhangi bir hayvan türünde bir nesne oluşturuluyor, ancak Animal türünde referans alınıyor
                // Aynı metodu (MakeSound) çağırıyoruz, ancak her bir nesne kendi türündeki uygulamayı kullanıyor
            myAnimal.MakeSound();  // Genel hayvan sesi
            myDog.MakeSound();     // Köpek sesi
            myCat.MakeSound();     // Kedi sesi
            myBird.MakeSound();    // Kuş sesi
            anyAnimal.MakeSound(); // Genel hayvan sesi
        }
    }
}
