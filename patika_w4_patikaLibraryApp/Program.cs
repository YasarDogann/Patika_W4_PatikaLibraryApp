using System.CodeDom.Compiler;

namespace patika_w4_patikaLibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kitap sınıfından book1 adında nesne oluşturuldu ve varsayılan Parametresiz Yapıcı method kullanıldı
            Kitaplar book1 = new Kitaplar();
            book1.BookName = "Olasılıksız";
            book1.AuthorName = "Adam";
            book1.AuthorSurname = "Fawer";
            book1.PageCount = 500;
            book1.PublishingHouse = "Falan Filan Kitabevi";
            book1.Display(); //book1'in bilgilerini ekrana gösterdik

            Console.WriteLine("\r\n---------------------------------------------------------------\r\n");

            // Book2 adında bir nesne daha oluşturuyoruz ve 2. Yapıcı method Parametreli olan kullanıldı 
            Kitaplar book2 = new Kitaplar("1984", "George","Orwell", 250, "Dümenden Kitabevi");
            book2.Display();

            Console.WriteLine("\r\n---------------------------------------------------------------\r\n");

            // book3 adında bir nesne daa oluşturduk parametreli yapıcı method ile
            Kitaplar book3 = new Kitaplar("Adı Aylin", "Ayşe", "Kulin", 389, "Remzi Kitabevi");
            book3.Display();

            Console.WriteLine("\r\n*************************************************************\r\n");

            //oluşturulan kitap nesnesinin sayısını görebilmek için statik method çağırıldı
            Console.WriteLine("Oluşturulan Kitap Sayısı: {0}",Kitaplar.GetBookCount());




            #region Class, Property, New, Constructor Açıklama
            /**
             * Class: OOP'de benzer özelliklere ve işlevselliklere sahip nesneleri tanımlamak için kullanılır ÖRnek: Kitaplar
             * Property: Nesne'nin özelliklerine erişim sağlayan yoldur Örnek Kitabın adı veya sayfa sayısı gibi bütün kitaplarda ortaktır
             * New : Yeni bir nesne oluşturmak için kullanılan anahtar kelimedir.
             * Constuructor: sınıfın bir nesnesi oluşturulunca otomatik olarak çağırılan bir methoddur. Başlangıç değeri oluşturmada kullanılır             
             */
            #endregion

            Console.ReadKey();

        }
    }
}
 