namespace Library;

class Program
{
    static void Main(string[] args)
    {  
        LibraryItem[] items =
        {
            new Book("Война и мир", "Толстой", 1869, 1225) { Genre = "Роман" },
            new Magazine("Наука и жизнь", 2025, 3, "Пресса"),
            new Book("1984", "Оруэлл", 1949, 328) { Genre = "Антиутопия" },
            new Magazine("National Geographic", 2024, 12, "NatGeo")
        };

        Console.WriteLine($"Всего элементов: {LibraryItem.TotalItem}");

        foreach (LibraryItem item in items)
        {
            Console.Write($"  {item.GetInfo()} - ");
            
            
            
            // Проверка типа с помощью is (C# 7)
            Book? book = item as Book;
            if (book != null)
            {
                Console.WriteLine($"Книга, автор: {book.Author}, жанр: {book.Genre}");
            }

            // Проверка с помощью is (для журналов)
            if (item is Magazine mag)
            {
                Console.WriteLine($"Журнал, выпуск #{mag.IssueNumber}, изд-во: {mag.Publisher}");
            }
        }
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }
}