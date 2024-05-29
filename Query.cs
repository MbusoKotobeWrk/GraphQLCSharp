namespace GraphQlCSharp
{
    public class Query
    {
        private readonly List<Book> _books = new()
        {
            new Book(Title: "I Love GraphQL", Author: new Author("Mbuso Kotobe")),
            new Book(Title: "Becoming a Seasoned Senior Developer", Author: new Author("Mbuso Kotobe")),
            new Book(Title: "Rest API to GraphQL in Java", Author: new Author("Mbuso Kotobe")),
        };

        public List<Book> GetBooks() => _books;
        public Book GetBook(String title) => _books.SingleOrDefault(x => x.Title.Equals(title, StringComparison.Ordinal)) ?? new Book("", new Author(""));
    }
}