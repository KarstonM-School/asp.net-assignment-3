namespace asp.net_assignment_3.Models
{
    public class BookRepo
    {
        // List to store all created books
        private static List<Book> _books = new List<Book>()
        {
            new Book{Id = 1, Name = "Macbeth", Author = "William Shakespeare", YearPublished = 1623, Genre = "Historical Fiction"},
            new Book{Id = 2, Name = "1984", Author = "George Orwell", YearPublished = 1949, Genre = "Dystopian"},
            new Book{Id = 3, Name = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960, Genre = "Southern Gothic"}
        };

        public static List<Book> GetBookList() { return _books; }

        public static Book? GetBookById(int bookId)
        {
            var book = _books.FirstOrDefault(b => b.Id == bookId);
            if (book != null)
            {
                return book;
            }
            return null;
        }

        public static void AddBook(Book book)
        {
            var maxId = _books.Count;
            book.Id = maxId + 1;
            _books.Add(book);
        }

        public static void UpdateBook(Book book)
        {
            var bookToUpdate = _books.FirstOrDefault(b => b.Id == book.Id);
            if(bookToUpdate != null)
            {
                bookToUpdate.Name = book.Name;
                bookToUpdate.Author = book.Author;
                bookToUpdate.YearPublished = book.YearPublished;
                bookToUpdate.Genre = book.Genre;
            }
        }

        public static void DeleteBook(int bookId)
        {
            var book = _books.FirstOrDefault(b => b.Id == bookId);
            if(book != null)
            {
                _books.Remove(book);
            }
        }
    }
}
