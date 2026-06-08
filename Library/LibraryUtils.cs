namespace Library;

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