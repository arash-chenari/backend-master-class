using LibraryApi.Models.Books;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryApi.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _repository;

        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public int Add(AddBookDto dto)
        {
            var book = new Book
            {
                Author = dto.Author,
                Title = dto.Title,
                CategoryId = dto.CategoryId,
                Description = dto.Description,
                PageCount = dto.PageCount,
                PublishDate = dto.PublishDate
            };

            _repository.Add(book);

            return book.Id;
        }

        [HttpPatch("{id:int}")]
        public void AddRate(int id, AddRateDto dto)
        {
            var book = _repository.FindById(id);
            var bookRate = new BookRate
            {
                BookId = id,
                Value = dto.Rate
            };

            book.Rates.Add(bookRate);
            _repository.Update(book);
        }

        [HttpGet]
        public List<GetBookDto> GetAll()
        {
            return _repository.GetAll();
        }


        [HttpPut("{id:int}")]
        public void Update(int id, UpdateBookDto dto)
        {
            var book = _repository.FindById(id);

            book.Id = id;
            book.Author = dto.Author;
            book.CategoryId = dto.CategoryId;
            book.Description = dto.Description;
            book.Title = dto.Title;
            book.PublishDate = dto.PublishDate;
            book.PageCount = dto.PageCount;
            
            _repository.Update(book);
        }
    }
}
