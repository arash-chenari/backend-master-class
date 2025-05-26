namespace LibraryApi.Models.Categories
{
    public class GetCategoryByMostContentDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TotalBooksPage { get; set; }
    }
}
