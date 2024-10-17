# Patika+ Week4 Kütüphane Uygulaması
Merhaba,
Bu proje C# ile Patika+ 4.hafta kütüphane uygulaması için yapılmıştır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Method kullanımı ve yapısını anlamak.
- Class yapısını anlamak
- Encapsulation yapısını öğrenmek
- Constructor Method yapısını öğrenmek
- static kullanımı

## İstenilen Görev
Patika Kütüphanesi için bir kitap kayıt uygulaması oluşturmak istiyoruz. Bu nedenle bu aşamada kitap nesneleri oluşturmamız gerekiyor.
Ad, Yazar Adı, Yazar Soyadı, Sayfa Sayısı, Yayınevi, Kayit Tarihi bilgileri ile kitaplar kaydetmek istiyoruz.
Örnek olarak:

Ayşe Kulin'in 398 sayfalık, Remzi Kitabevi yayınevinden çıkan Adı Aylin kitabını oluşturunuz.
2 Adet constructor alternatifi olsun.
Bir tanesi default constructor tarzında parmetre almadan çalışan bir metot
Diğeri Kitap adı, Yazar Adı, Sayfa Sayısı, Yayınevi  bilgilerini alıp bu değerleri nesne üretim aşamasında atayan bir metot.
KayıtTarihi nesne oluşturulunca otomatik olarak o an olarak atansın. (Her iki constructor için de geçerli)
Kodlarınızın altına birer yorum satırıyla örnek üzerinden Class , Property , New , Constructor kavramlarını açıklayınız.

## Kod
```csharp
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
```
Kitaplar adında bir Class oluşturuldu. Oluşturulan her bir nesne'nin sayısını almak için statik değişken oluşturuldu. Daha sonra her kitap için ortak özellikler private olarak tanımlandı.
private özelliklere erişim için get set oluşturuldu. 
Daha sonra parametre almayan bir yapıcı method oluşturuldu bunun içinde her nesnede çağırılacağı için bir oluşturma tarihi oluşturdum birde oluşturulan her nesnede
bir artması için statik değişkeni ekledim.
Parametre alan yapıcı method ve değişken eklendi. Parametrelerin sonuna this ile paramatresiz yapıcı method çağırıldı böylelikle oluşturma tarihi çağırıldı aynı zamanda kitap sayısı da arttılrıldı.


```csharp
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
```




