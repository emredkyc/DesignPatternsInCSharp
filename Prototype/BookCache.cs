public class BookCache
{
    private Dictionary<int, Book> _cache = new Dictionary<int, Book>();

    public Book GetBook(int isbn)
    {
        if (_cache.ContainsKey(isbn))
        {
            return _cache[isbn].Clone();
        }
        else
        {
            // Simulate fetching the book from a database
            Book book = FetchBookFromDatabase(isbn);
            _cache.Add(isbn, book);
            return book.Clone(); // Return a clone to ensure the original object remains unaltered
        }
    }

    private Book FetchBookFromDatabase(int isbn)
    {
        // Simulate database access
        Console.WriteLine($"Fetching book with ISBN {isbn} from database...");
        return new Book("Example Title", "Author Name", isbn);
    }
}
