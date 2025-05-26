using LibraryApi.Models.Categories;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Models.Books
{
    public interface IBookRepository
    {
        void Add(Book book);
        Book? FindById(int id);
        List<GetBookDto> GetAll();
        List<GetBookByAgeRange> GetByAgeRange(AgeRange ageRange);
        List<GetBookByRate> GetByRate();
        void Update(Book book);
    }

    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Book> _books;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
            _books = _context.Books;
        }

        public void Add(Book book)
        {
            _books.Add(book);
            _context.SaveChanges();
        }

        public Book? FindById(int id)
        {
            return _books.FirstOrDefault(_ => _.Id == id);
        }

        public List<GetBookDto> GetAll()
        {
            return _books.Select(b => new GetBookDto
            {
                Id=b.Id,
                Title = b.Title,
                Author = b.Author,
                Description = b.Description,
                PageCount = b.PageCount,
                PublishDate = b.PublishDate,
                Rates = b.Rates.Select(r => r.Id).ToList()
            }).ToList();
        }

        public List<GetBookByAgeRange> GetByAgeRange(AgeRange ageRange)
        {
            return _books.Where(b => b.Category.AgeRange == ageRange)
                .Select(b => new GetBookByAgeRange
                {
                    AgeRange = b.Category.AgeRange,
                    Author = b.Author,
                    Description = b.Description,
                    PageCount = b.PageCount,
                    PublishDate = b.PublishDate,
                    Rates = b.Rates.Select(_ => _.Value).ToList(),
                    Title = b.Title,
                    Id = b.Id
                }).ToList();
        }

        public List<GetBookByRate> GetByRate()
        {
            return _books.Select(b => new GetBookByRate
            {
                Id = b.Id,
                Title = b.Title,
                Rate = b.Rates.Any() ? b.Rates.Average(_ => _.Value) : 0
            }).OrderByDescending(_=>_.Rate)
            .ToList();
        }

        public void Update(Book book)
        {
            _context.SaveChanges();
        }
    }
}
