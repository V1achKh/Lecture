namespace Library;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Книг до создания: {Book.TotalCount}");   
        CreateBook();

        Book.PrintStatistics();
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }

    static void CreateBook()
    {
        Book book1 = new Book( "Война и мир", "Л. Толстой", 1869, 1225)
        {
            Genre = "Роман"
        };
        Book book2 = new Book( "Новая книга", "А. Автор")
        {
            Genre ="Фантастика"
        };
        Book book3 = new Book("Новая книга", "А. Автор")
        {
            Genre = "ehj"
        };
        Book book4 = new Book("Старая книга", "Б. Автор", 1990, 200)
        {
            Genre = "Проза"
        };
    }
}

class Book
{

    //свойства и поля
    public string Title { get; init; }
    public string Author { get; init; }

    private int _year;
    public int Year
    {
        get => _year;
        set
        {
            if (value >= 1450 && value <= DateTime.Now.Year)
            {
                _year = value;
            }
        }
    }
    public int PageCount { get; set; }

    public required string Genre { get; set; }

    public int AgeInYears => DateTime.Now.Year - Year;

    public string ShortDescription => $"{Title} ({Year})";
    
    private static int _totalCount = 0;
    public static int TotalCount => _totalCount;
    public int Id { get; }
    
    //конструкторы
    public Book(string title, string author, int year, int pageCount)
    {
        this.Title = title;
        this.Author = author;
        this.Year = year;
        this.PageCount = pageCount;
        _totalCount++;
        Id = _totalCount;
    }

    public Book(string title, string author):this(title, author, 2024, 0)
    {
    }

    public Book(): this("Без названия", "Неизвестен")
    {
    }

    
    
    //методы
    public string GetInfo()
    {
        return $"<{Title}> - {Author} - {Year} - {PageCount}";
    }

    public string GetInfo(bool showPages)
    {
        if (showPages)
        {
            return $"<{Title}> - {Author} - {Year} - {PageCount}";
        }
        else
        {
            return $"<{Title}> - {Author} - {Year}";
        }
    }

    public bool IsOlderThan(int years = 50)
    {
        return (DateTime.Now.Year - Year) > years;
    }

    public string GetFormattedInfo(string format = "short")
    {
        string FShort() => $"<{Title}> - {Author} - {Year}";
        string FFull() => $"Название: {Title} - Автор: {Author} - Год: {Year} - " +
                          $"Количество страниц: {PageCount}";
        return format switch
        {
            "short" => FShort(),
            "full" => FFull(),
            _ => GetInfo()
        };
    }

    public static void PrintStatistics()
    {
        Console.WriteLine($"Общее количество созданных книг: {_totalCount}");
    }

    ~Book()
    {
        Console.WriteLine($"Финализатор: книга «{Title}» удалена из памяти");
    }
}