namespace Library;

class LibraryItem
{
    public string Title { get; init; }
    
    
    const int MinYear = 1450;

    private int _year;
    public int Year
    {
        get => _year;
        set
        {
            if (value >= MinYear && value <= LibraryUtils.StartupTime.Year)
            {
                _year = value;
            }
            else
            {
                Console.Error.WriteLine("Неправильная дата (год)");
            }
        }
    }
    
    
    public static int _totalItem=0;
    public static int TotalItem => _totalItem;
    public int Id { get; }
    //метод
    public string GetInfo()
    {
        return $"<{Title}> - {Year}";
    }
    //конструктор
    public LibraryItem(string title, int year)
    {
        this.Title = title;
        this.Year = year;
        _totalItem++;
        Id = _totalItem;
    }

    public static void PrintStatistics()
    {
        Console.WriteLine($"Общее количество созданных элементов: {_totalItem}");
    }

}