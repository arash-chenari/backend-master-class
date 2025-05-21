using LibraryApi.Models.Books;

namespace LibraryApi.Models.Categories
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AgeRange AgeRange { get; set; }

        public HashSet<Book> Books { get; set; } = new();
    }

    public enum AgeRange : short
    {
        Child =1 ,
        Adolescent = 2,
        Adult = 3
    }
}