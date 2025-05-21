using LibraryApi.Models.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LibraryApi.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _repository;

        public CategoriesController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public int Add(AddCategoryDto dto)
        {
            //prevent to save category with duplicate title

            var category = new Category
            {
                Title = dto.Title,
            };

            _repository.Add(category);

            return category.Id;
        }

        [HttpGet]
        public List<GetCategoryDto> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpPut("{id:int}")]
        public void Update(int id, UpdateCategoryDto dto)
        {
            //prevent to save category with duplicate title
            var category = _repository.Find(id);

            if (category is not null)
            {
                category.Title = dto.Title;
            }

            _repository.Update(category);
        }

        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            var category = _repository.Find(id);

            if (category is null)
            {
                throw new CategoryDoesntExistException();
            }
              _repository.Remove(category);
        }
    }


    public class CategoryDoesntExistException : Exception
    {

    }
}
