
namespace LibraryApi.Models.Categories
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        Category? Find(int id);
        List<GetCategoryDto> GetAll();
        void Update(Category? category);
        void Remove(Category category);
        List<GetCategoryByRateDto> GetByRate();
        List<GetCategoryByMostContentDto> GetByMostContent();
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

        public List<GetCategoryByMostContentDto> GetByMostContent()
        {
            return _context.Categories.Select(c => new GetCategoryByMostContentDto
            {
                Id = c.Id,
                Title = c.Title,
                TotalBooksPage = c.Books.Sum(_ => _.PageCount)
            }).OrderByDescending(_ => _.TotalBooksPage).ToList();
        }

        public List<GetCategoryByRateDto> GetByRate()
        {
            var categoriesByRates = _context.Categories.Select(c => new
            {
                c.Id,
                c.Title,
                BookRates = c.Books.SelectMany(_ => _.Rates)
            });

            return categoriesByRates.Select(_ => new GetCategoryByRateDto
            {
                Id = _.Id,
                Title = _.Title,
                Rate = _.BookRates.Any() ? _.BookRates.Average(_ => _.Value) : 0
            }).OrderByDescending(_ => _.Rate).ToList();
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
