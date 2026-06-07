namespace Library;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("1984","Оруэлл", 1949, 328);
        Book book2 = new Book("1984", "Оруэлл");
        Book book3 = new Book();
        Console.WriteLine(book1.GetInfo());
        Console.WriteLine(book2.GetInfo());
        Console.WriteLine(book3.GetInfo());
    }
}
class Book
{
    private string title;
    private string author;
    private int year;
    private int pageCount;

    public Book(string title, string author, int year, int pageCount)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.pageCount = pageCount;
    }

    public Book(string title, string author):this(title, author, 2024, 0)
    {
    }

    public Book(): this("Без названия", "Неизвестен")
    {
        
    }
    
    public string GetInfo()
    {
        return $"<{title}> - {author} - {year} - {pageCount}";
    }
    
}