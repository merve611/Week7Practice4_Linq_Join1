using Week7Practice4_Linq_Join1;

internal class Program
{
    public static void Main(string[] args)
    {

        //Yazar listesi oluşturuldu
        List<Author> authors = new List<Author> ();
        authors.Add(new Author { AuthorId = 1, Name = "Orhan Pamuk" });
        authors.Add(new Author { AuthorId = 2, Name = "Elif Şafak" });
        authors.Add(new Author { AuthorId = 3, Name = "Ahmet Ümit" });



        //book listes oluşturuldu
        List<Book> books = new List<Book> ();
        books.Add(new Book { BookId = 1, Title = "Kar", AuthorId = 1 });
        books.Add(new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 });
        books.Add(new Book { BookId = 3, Title = "10 Minutes 38 Second in This Strange World", AuthorId = 2 });
        books.Add(new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 });



        //Kitapları ve yazarları birleştiren bir LINQ sorgusu oluşturun. Bu sorgu, her kitabın başlığını ve yazarının adını içermelidir


        //sorgu söz dizimi kullanılarak yazar ve kitap tabloları birleştirildi
        var authorBooks = from author in authors
                         join book in books on author.AuthorId equals book.AuthorId
                         select new
                         {
                             AuthorName = author.Name,
                             BookTitle = book.Title,
                         };

        //oluşturuan yeni nesne üzerinden bilgiler alınarak ekrana yazıldı
        
        foreach (var author in authorBooks)
        {
            Console.WriteLine($"Yazar adı : {author.AuthorName} Kitabı : {author.BookTitle}");              
        }

    }
}