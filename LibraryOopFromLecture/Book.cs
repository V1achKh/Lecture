namespace Library;

class Book : LibraryItem
{

    public string Author { get; init; }
    private int _pageCount;
    const int MaxPageCount = 10000;

    public int PageCount
    {
        get => _pageCount;
        set
        {
            if (value <= MaxPageCount && value >= 0)
            {
                _pageCount = value;
            }
            else
            {
                Console.Error.WriteLine("Неправильное количество страниц");
            }
        }
    }

    public override string GetCardInfo()
    {
        return $"<{Title}> - {Author} - {Year}";
    }

    public required string Genre { get; set; }

    public int AgeInYears => DateTime.Now.Year - Year;

    public string ShortDescription => $"{Title} ({Year})";

    public override string GetInfo()
    {
        return $"<{Title}> - {Author} - {Year} - {Genre}";
    }
    
    
    //конструкторы
    public Book(string title, string author, int year, int pageCount): 
        base(title, year)
    {
        this.Author = author;
        this.PageCount = pageCount;
    }

    public Book(string title, string author):this(title, author, 2024, 0)
    {
    }

    public Book(): this("Без названия", "Неизвестен")
    {
    }

    
    
    //методы

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

    
    ~Book()
    {
        Console.WriteLine($"Финализатор: книга «{Title}» удалена из памяти");
    }
}