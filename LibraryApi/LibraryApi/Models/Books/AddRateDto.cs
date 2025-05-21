using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models.Books
{
    public class AddRateDto
    {
        [RateValidator(ErrorMessage ="Please Specify between one and five")]
        public int Rate { get; set; }
    }


    public class RateValidator : ValidationAttribute
    {
        public RateValidator()
        {
            
        }
        public RateValidator(string ErrorMeesage)
        {
            base.ErrorMessage = ErrorMeesage;     
        }
       
        public override bool IsValid(object? value)
        {
            return (int)value >= 1 && (int)value <= 5;        
        } 
    }
}
