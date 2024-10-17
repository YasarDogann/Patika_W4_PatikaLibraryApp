using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_patikaLibraryApp
{
    public  class Kitaplar
    {
        //Toplam oluşturulan kitap nesnesini tutan statik alan
        private static int bookCount = 0; 

        // Fields
        private string bookName;
        private string authorName;
        private string authorSurname;
        private int pageCount;
        private string publishingHouse;
        private DateTime publishingDate;


        //Kitap bilgisine erişim 
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname {  get; set; }
        public int PageCount { get; set; }
        public string PublishingHouse { get; set; }
        public DateTime PublishingDate { get { return publishingDate; } private set { publishingDate = value; } }

        // Parametresiz Varsasıyaln Yapıcı Method
        public Kitaplar()
        {
            publishingDate = DateTime.Now; //kayıt tarihi otomatik olarak nesne oluşturulunca atanıyor o zamanki zaman'a göre 
            bookCount++;
        }
        
        // Parametreli Yapıcı Method ve this() varsayılan yapıcı methodu çağırıyor
        public Kitaplar (string _bookName, string _authorName, string _authorSurname, int _pageCount, string _publishingHouse): this()//sınıfın başka constructur'ı çağırıldı
        {
            BookName = _bookName;   //kitap adı atanır
            AuthorName = _authorName; //yazar adı atanır
            AuthorSurname = _authorSurname; //yazar soyadı atanır
            PageCount = _pageCount; // sayfa sayısı atanır
            PublishingHouse = _publishingHouse; // yayınevi atanır
            //PublishingDate = _publishingDate;     datetime koymadım çünkü default yapıcı methodu çağırdım
        }

        //kitap detaylarını ekrana yazdıran methd
        public void Display()
        {
            Console.WriteLine($"Kitap Adı: {BookName}");
            Console.WriteLine($"Yazar Adı: {AuthorName}");
            Console.WriteLine($"Yazar Soyadı: {AuthorSurname}");
            Console.WriteLine($"Sayfa Sayısı: {PageCount}");
            Console.WriteLine($"Yayınevi: {PublishingHouse}");
            Console.WriteLine($"Yayın Tarihi: {PublishingDate}");
        }
        
        //oluşturulan kitap sayısını döndüren static method
        public static int GetBookCount()
        {
            return bookCount;
        }


    }
}
