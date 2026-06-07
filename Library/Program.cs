namespace Library;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book( "Война и мир", "Л. Толстой", 1869, 1225)
            {
                Genre = "Роман"
            };
        Book book2 = new Book( "Новая книга", "А. Автор")
        {
            Genre ="Фантастика"
        };
        Console.WriteLine(book1.GetInfo());
        Console.WriteLine($"Возраст: {book1.AgeInYears} лет");
        Console.WriteLine($"Краткое: {book1.ShortDescription}");
        Console.WriteLine();
        Console.WriteLine(book2.GetFormattedInfo("full"));
        book2.Year = 3000;
    }
}

class Book
{

    public string Title { get; init; }
    public string Author { get; init; }

    private int _year;
    public int Year
    {
        get => _year;
        set
        {
            if (value > 1450 && value < DateTime.Now.Year)
            {
                _year = value;
            }
        }
    }
    public int PageCount { get; set; }

    public required string Genre { get; set; }

    public int AgeInYears => DateTime.Now.Year - Year;

    public string ShortDescription => $"{Title} ({Year})";
    
    //конструкторы
    public Book(string title, string author, int year, int pageCount)
    {
        this.Title = title;
        this.Author = author;
        this.Year = year;
        this.PageCount = pageCount;
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
    
}