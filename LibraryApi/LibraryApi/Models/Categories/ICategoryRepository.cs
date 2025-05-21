
namespace LibraryApi.Models.Categories
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        Category? Find(int id);
        List<GetCategoryDto> GetAll();
        void Update(Category? category);
        void Remove(Category category);
    }

    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public Category? Find(int id)
        {
            return _context.Categories.Find(id);
        }

        public List<GetCategoryDto> GetAll()
        {
            return _context.Categories.Select(c =>
                new GetCategoryDto
                {
                    Id = c.Id,
                    Title = c.Title,
                    AgeRange = c.AgeRange
                }
            ).ToList();
        }

        public void Remove(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public void Update(Category? category)
        {
            _context.SaveChanges();
        }
    }
}
