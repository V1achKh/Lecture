namespace Library;

static class LibraryItemExtensions
{
    public static bool IsNew(this LibraryItem item, int years = 5)
    {
        if ((DateTime.Now.Year - item.Year) <= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static string ToCsvLine(this LibraryItem item)
    {
        string type = item is Book ? "Книга" : item is Magazine ? "Журнал" : "Элемент";
        string extra = item switch
        {
            Book b => $"{b.Author};{b.PageCount};{b.Genre}",
            Magazine m => $"{m.Publisher};{m.IssueNumber}",
            _ => ";;"
        };
        return $"{type};{item.Title};{item.Year};{extra}";
    }

    public static void PrintCard(this LibraryItem item)
    {
        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"| {item.GetCardInfo(), -46} |");
        string status = item.IsNew() ? "Новинка" : $"Старинка: {DateTime.Now.Year - item.Year}";
        Console.WriteLine($"| {status, -47} |");
        Console.WriteLine(new string('-', 50));
    }
}