using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models.Categories
{
    public class AddCategoryDto
    {
        [Required(ErrorMessage ="Title is Required")]
        [MaxLength(10,ErrorMessage ="Category lenght should be less than 10 ")]
        public string Title { get; set; }
    }
}
