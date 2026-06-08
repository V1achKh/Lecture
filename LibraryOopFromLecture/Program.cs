namespace Library;

class Program
{
    static void Main(string[] args)
    {  
        LibraryItem[] catalog =
        {
            new Book("Война и мир", "Толстой", 1869, 1225) { Genre = "Роман" },
            new Magazine("Наука и жизнь", 2025, 3, "Пресса"),
            new Book("1984", "Оруэлл", 1949, 328) { Genre = "Антиутопия" },
            new Magazine("National Geographic", 2024, 12, "NatGeo")
        };
// Полиморфизм - один цикл, разное поведение
        Console.WriteLine("=== Каталожные карточки ===");
        foreach (LibraryItem item in catalog)
        {
            Console.WriteLine(item.GetCardInfo());
        }

        Console.WriteLine("\n=== Описания ===");
        foreach (LibraryItem item in catalog)
        {
            Console.WriteLine(item.Description);
        }
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }
}