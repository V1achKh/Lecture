namespace Library;

class Program
{
    static void Main(string[] args)
    {  
        Book[] books =
        {
            new("Война и мир", "Л. Толстой", 1869, 1225)
                { Genre = "Роман" },
            new("Новая книга", "А. Автор")
                { Genre = "Фантастика" },
            new("Новая книга", "А. Автор")
                { Genre = "ehj" },
            new("Старая книга", "Б. Автор", 1990, 200)
                { Genre = "Проза" }
        };
    
        LibraryUtils.PrintSeparator();
        Console.WriteLine($"{LibraryUtils.LibraryName} ─ Время работы с: {LibraryUtils.StartupTime}");        
        LibraryUtils.PrintSeparator();
        Console.WriteLine(LibraryUtils.FormatBookList(books));
        LibraryUtils.PrintSeparator();
        
        Book oldest = LibraryUtils.FindOldest(books);
        Console.WriteLine($"Самая старая книга: {oldest.ShortDescription}");
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }

    /*static void CreateBook()
    {
        Book[] books =
        {
            new("Война и мир", "Л. Толстой", 1869, 1225)
                { Genre = "Роман" },
            new("Новая книга", "А. Автор")
                { Genre = "Фантастика" },
            new("Новая книга", "А. Автор")
                { Genre = "ehj" },
            new("Старая книга", "Б. Автор", 1990, 200)
                { Genre = "Проза" }
        };
    }
    */
}

class Book
{

    //свойства и поля
    public string Title { get; init; }
    public string Author { get; init; }

    private int _year;
    private int _pageCount;
    public int Year
    {
        get => _year;
        set
        {
            if (value >= MinYear && value <= LibraryUtils.StartupTime.Year)
            {
                _year = value;
            }
        }
    }

    public int PageCount
    {
        get => _pageCount;
        set
        {
            if (value <= Book.MaxPageCount && value >= 0)
            {
                _pageCount = value;
            }
        }
    }

    public required string Genre { get; set; }

    public int AgeInYears => DateTime.Now.Year - Year;

    public string ShortDescription => $"{Title} ({Year})";
    
    private static int _totalCount = 0;
    public static int TotalCount => _totalCount;
    public int Id { get; }
    const int MaxPageCount = 10000;
    const int MinYear = 1450;
    
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

static class LibraryUtils
{
    public const string LibraryName = "Городская библиотека";

    public static readonly DateTime StartupTime = DateTime.Now;
    
    public static void PrintSeparator(char symbol = '─', int length = 40)
    {
        Console.WriteLine(new string(symbol, length));
    }

    public static string FormatBookList(Book[] books)
    {
        var sb = new System.Text.StringBuilder();
        for (int i = 0; i < books.Length; i++)
        {
            sb.AppendLine($"{i+1} - {books[i].GetInfo()}");
        }

        return sb.ToString();
    }

    public static Book FindOldest(Book[] books)
    {
        Book oldest = books[0];
        foreach (var variable in books)
        {
            if (variable.Year < oldest.Year)
            {
                oldest = variable;
            }
        }
        
        return  oldest;
    }
}