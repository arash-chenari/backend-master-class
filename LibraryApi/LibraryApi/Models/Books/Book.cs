using LibraryApi.Models.Categories;

namespace LibraryApi.Models.Books
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public HashSet<BookRate> Rates { get; set; } = new();
        public int PageCount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }


    public class BookRate
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int BookId { get; set; }
    }
}




