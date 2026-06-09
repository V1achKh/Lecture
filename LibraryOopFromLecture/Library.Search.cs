namespace Library;

partial class Library
{
    public List<LibraryItem> FindByTitle(string keyword)
    {
        List<LibraryItem> result = new();
        foreach (var item in _list)
        {
            if (item.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(item);
            }
        }
        return result;
    }

    public List<Book> FindBooks()
    {
        List<Book> result = new();
        foreach (var item in _list)
        {
            if (item is Book book)
            {
                result.Add(book);
            }
        }
        return result;
    }

    public List<Magazine> FindMagazines()
    {
        List<Magazine> result = new();
        foreach (var item in _list)
        {
            if (item is Magazine m)
            {
                result.Add(m);
            }
        }

        return result;
    }
}