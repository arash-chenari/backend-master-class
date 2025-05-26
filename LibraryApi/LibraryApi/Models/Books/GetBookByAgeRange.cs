using LibraryApi.Models.Categories;

namespace LibraryApi.Models.Books
{
    public class GetBookByAgeRange
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<int> Rates { get; set; } = new();
        public int PageCount { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public AgeRange AgeRange { get; set; }
    }
}
