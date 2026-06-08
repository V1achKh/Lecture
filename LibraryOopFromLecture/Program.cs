namespace Library;

class Program
{
    static void Main(string[] args)
    {  
        // ===== Основная программа =====
        Book book1 = new("Война и мир", "Толстой", 1869, 1225) { Genre = "Роман" };
        Magazine mag1 = new("Наука и жизнь", 2025, 3, "Пресса");

// Методы расширения вызываются как обычные методы объекта
        Console.WriteLine($"«{book1.Title}» новинка? {book1.IsNew()}");
        Console.WriteLine($"«{mag1.Title}» новинка? {mag1.IsNew()}");

        Console.WriteLine("\n=== CSV ===");
        Console.WriteLine(book1.ToCsvLine());
        Console.WriteLine(mag1.ToCsvLine());

        Console.WriteLine("\n=== Каталожные карточки ===");
        book1.PrintCard();
        mag1.PrintCard();
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }
}