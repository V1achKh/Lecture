using System.ComponentModel;

namespace Library;

partial class Library
{
    private List<LibraryItem> _list;
    public string Name { get; }

    public Library(string name)
    {
        this.Name = name;
        _list = new List<LibraryItem>();
    }

    public void Add(LibraryItem libraryItem)
    {
        _list.Add(libraryItem);
    }

    public void PrintAll()
    {
        for (int i = 0; i < _list.Count; i++)
        {
            Console.WriteLine($"{i+1} - {_list[i].GetInfo()}");
        }
    }
}