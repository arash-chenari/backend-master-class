namespace LibraryApi.Models.Categories
{
    public class GetCategoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AgeRange AgeRange { get; set; }
    }
}
