using System;

namespace YazilimNetFrameworkOrnekler.Bilgiler
{
    internal class NamingConventionExample
    {
        /*
        Naming Convention (İsimlendirme Kuralları)
        
        İsimlendirme, yazılım geliştirmede önemli bir konu olup, kodun okunabilirliğini ve bakımını büyük ölçüde etkiler.
        C# dilinde de standartlar belirlenmiş ve yaygın olarak kullanılan bazı isimlendirme kuralları vardır.
        
        1. **Sınıf ve Yapı (Class/Struct)**: 
            - Sınıf ve yapı isimleri her zaman PascalCase (Kelime başları büyük) olmalıdır.
            - Sınıf ismi, genellikle bir isim veya bir şeyi tanımlayan bir terim olmalıdır.
            
            Örnek: `Student`, `CarModel`, `InvoiceProcessor`

        2. **Metodlar (Methods)**:
            - Metod isimleri PascalCase olmalıdır.
            - Metod adı, ne yaptığını açıklayan fiil+isim kombinasyonu olmalıdır.
            
            Örnek: `CalculateTotal`, `GetUserData`, `PrintInvoice`

        3. **Değişkenler ve Alanlar (Variables/Fields)**:
            - Değişken isimleri camelCase olmalıdır. (İlk harf küçük, sonraki kelimelerin başı büyük)
            - Değişken isimleri, ne amaçla kullanıldığını açıkça belirtmelidir.
            
            Örnek: `userAge`, `invoiceAmount`, `totalAmount`

        4. **Sürekli Kullanılan Değişkenler (Constants)**:
            - Sabit (constant) isimleri tümüyle büyük harflerle yazılmalı ve kelimeler arasına alt çizgi (_) konulmalıdır.
            
            Örnek: `MAX_LENGTH`, `PI`

        5. **Özellikler (Properties)**:
            - Özellikler de PascalCase olarak isimlendirilmelidir.
            
            Örnek: `TotalAmount`, `UserName`, `InvoiceDate`

        6. **Parametreler (Parameters)**:
            - Parametre isimleri camelCase olmalıdır.
            
            Örnek: `invoiceAmount`, `userName`, `productCode`

        7. **Eventler (Events)**:
            - Event isimleri genellikle bir fiil (verb) ile başlar ve PascalCase olarak yazılır.
            
            Örnek: `DataUpdated`, `UserLoggedIn`

        8. **Interface'ler**:
            - Interface isimleri genellikle "I" ile başlar, ardından PascalCase uygulanır.
            
            Örnek: `IPrintable`, `IProcessable`, `IDataService`

        9. **Generic Tipler (Generic Types)**:
            - Generic tip parametreleri genellikle tek harflerden oluşur ve büyük harf ile yazılır.
            
            Örnek: `T`, `TItem`, `TKey`, `TValue`

            ### **CamelCase (Deve Case)**:
            - **Tanım**: CamelCase, kelimeler arasındaki boşluklar olmadan, ilk kelimenin küçük harflerle yazılması ve sonraki kelimelerin ilk harflerinin büyük olması durumudur.
            - **Kullanım Alanı**: Genellikle **değişkenler**, **parametreler** ve **metodlar** için kullanılır.
            - **Örnekler**:
              - `userAge`, `invoiceAmount`, `productCode`, `getUserData`

            ### **PascalCase**:
            - **Tanım**: PascalCase, kelimeler arasındaki boşluklar olmadan, her kelimenin ilk harflerinin büyük yazılması durumudur.
            - **Kullanım Alanı**: **Sınıflar**, **Metodlar**, **Özellikler**, **Eventler** için kullanılır.
            - **Örnekler**:
              - `Student`, `CarModel`, `CalculateTotal`, `TotalAmount`, `InvoiceDate`, `UserLoggedIn`

            ### **UpperCase (Büyük Harfler)**:
            - **Tanım**: UpperCase, tüm harflerin büyük olduğu bir yazım stilidir. Kelimeler arasına genellikle alt çizgi (`_`) eklenir.
            - **Kullanım Alanı**: **Sabitler (Constants)**, bazı çevresel değişken isimleri için kullanılır.
            - **Örnekler**:
              - `MAX_LENGTH`, `PI`, `USER_ID`, `DATABASE_URL`

            ### **KebabCase (Kebap Case)**:
            - **Tanım**: KebabCase, kelimeler arasına kısa çizgi (`-`) koyarak yazma stilidir. Her kelimenin tamamı küçük harflerle yazılır.
            - **Kullanım Alanı**: **URL'ler**, **dosya isimleri**, web geliştirme için yaygın olarak kullanılır.
            - **Örnekler**:
              - `user-name`, `invoice-date`, `product-code`, `total-amount`

            ### **SnakeCase (Yılan Case)**:
            - **Tanım**: SnakeCase, kelimeler arasına alt çizgi (`_`) koyarak yazma stilidir. Her kelime küçük harflerle yazılır.
            - **Kullanım Alanı**: Genellikle **Python**, **Veritabanı alanları**, bazı **dosya isimleri** ve **değişkenler** için yaygın kullanılır.
            - **Örnekler**:
              - `user_name`, `invoice_amount`, `product_code`

            ---

            ### İsimlendirme Stillerinin Kullanım Alanları

            | **Stil**          | **Kullanım Alanları**                               | **Örnekler**                            |
            |-------------------|-----------------------------------------------------|-----------------------------------------|
            | **PascalCase**    | Sınıflar, metodlar, özellikler, eventler            | `Student`, `CalculateTotal`, `InvoiceDate` |
            | **CamelCase**     | Değişkenler, parametreler, metodlar                 | `userAge`, `invoiceAmount`, `getUserData` |
            | **UpperCase**     | Sabitler (constants), çevresel değişkenler          | `MAX_LENGTH`, `PI`, `USER_ID`            |
            | **KebabCase**     | URL'ler, dosya isimleri, web uygulamaları           | `user-name`, `invoice-date`, `product-code` |
            | **SnakeCase**     | Python gibi dillerde, dosya isimleri, bazı veritabanı alanları | `user_name`, `invoice_amount`, `product_code` |

            ---

            Bu isimlendirme kuralları, yazılım projelerinizde kodun tutarlı, okunabilir ve anlaşılabilir olmasını sağlar. Hangi stili kullanmanız gerektiği, projenizin gereksinimlerine ve kullanılan teknolojilere bağlı olarak değişebilir.



        */

        // PascalCase - Sınıf ismi
        public class CarModel
        {
            // CamelCase - Değişken ismi
            private string carBrand;

            // PascalCase - Metod ismi
            public void SetCarBrand(string brand)
            {
                // CamelCase - Parametre ismi
                carBrand = brand;
            }

            public string GetCarBrand()
            {
                return carBrand;
            }
        }

        // PascalCase - Interface ismi
        public interface IPrintable
        {
            void Print();
        }

        public class Invoice : IPrintable
        {
            // CamelCase - Değişken ismi
            private double invoiceAmount;

            // PascalCase - Metod ismi
            public void SetInvoiceAmount(double amount)
            {
                invoiceAmount = amount;
            }

            public void Print()
            {
                Console.WriteLine($"Invoice Amount: {invoiceAmount}");
            }
        }

        // Sabitler - ALL CAPS with underscores
        private const double MAX_DISCOUNT = 0.30;

        public void RunExamples()
        {
            // PascalCase - Metod ismi
            var car = new CarModel();
            car.SetCarBrand("Toyota");
            Console.WriteLine($"Car Brand: {car.GetCarBrand()}");

            var invoice = new Invoice();
            invoice.SetInvoiceAmount(150.0);
            invoice.Print();

            Console.WriteLine($"Max Discount: {MAX_DISCOUNT * 100}%");
        }
    }
}
