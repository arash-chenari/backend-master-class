namespace LibraryApi.Models.Books
{
    public class AddBookDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public int CategoryId { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
