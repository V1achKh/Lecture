namespace Library;

class Program
{
    static void Main(string[] args)
    {
        Book book1 =
            new Book( "Война и мир"
                , "Л. Толстой"
                , 1869, 1225);
        Console .WriteLine(book1.GetInfo());
        Console .WriteLine(book1.GetInfo(showPages:false));
        Console .WriteLine($"Старше 50 лет: {book1.IsOlderThan()}");
        Console .WriteLine($"Старше 200 лет: {book1.IsOlderThan(years: 200)}");
        Console .WriteLine(book1.GetFormattedInfo());
        Console .WriteLine(book1.GetFormattedInfo(format:"full"));
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

    public string GetInfo(bool showPages)
    {
        if (showPages)
        {
            return $"<{title}> - {author} - {year} - {pageCount}";
        }
        else
        {
            return $"<{title}> - {author} - {year}";
        }
    }

    public bool IsOlderThan(int years = 50)
    {
        return (DateTime.Now.Year - year) > years;
    }

    public string GetFormattedInfo(string format = "short")
    {
        string FShort() => $"<{title}> - {author} - {year}";
        string FFull() => $"Название: {title} - Автор: {author} - Год: {year} - " +
                          $"Количество страниц: {pageCount}";
        return format switch
        {
            "short" => FShort(),
            "full" => FFull(),
            _ => GetInfo()
        };
    }
    
}