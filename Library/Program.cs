namespace Library;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Book book2 = new Book();
        book1.SetData("1984", "Дж. Оруэлл", 1949, 328);
        book2.SetData("Война и Мир", "толстой", 1869, 1225);
        Console.WriteLine(book1.GetInfo());
        Console.WriteLine(book2.GetInfo());
    }
}
class Book
{
    private string title;
    private string author;
    private int year;
    private int pageCount;

    public void SetData(string title, string author, int year, int pageCount)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.pageCount = pageCount;
    }
    
    public string GetInfo()
    {
        return $"<{title}> - {author} - {year} - {pageCount}";
    }
    
}