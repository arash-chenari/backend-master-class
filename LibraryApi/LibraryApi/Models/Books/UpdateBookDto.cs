namespace LibraryApi.Models.Books
{
    public class UpdateBookDto
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
    }
}