public class Book : IPrototype<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int ISBN { get; set; }

    // Constructor for the book
    public Book(string title, string author, int isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    // Implementing the Clone method
    public Book Clone()
    {
        return new Book(Title, Author, ISBN);
    }
}
