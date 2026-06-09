namespace Library;

class Program
{
    static void Main(string[] args)
    {  
        Library library = new Library(LibraryUtils.LibraryName);
        library.Add(new Book("Война и мир", "Толстой", 1869, 1225) { Genre = "Роман" });
        library.Add(new Magazine("Наука и жизнь", 2025, 3, "Пресса"));
        
        library.PrintAll();
        
        Console.WriteLine("Поиск по слову <Война>");
        foreach (var item in library.FindByTitle("война"))
        {
            Console.WriteLine(item.GetInfo());
        }
        
        Console.WriteLine(library.FindBooks().Count);
        Console.WriteLine(library.FindMagazines().Count);
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }
}