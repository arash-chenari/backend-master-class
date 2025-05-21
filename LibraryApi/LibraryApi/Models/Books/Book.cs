using LibraryApi.Models.Categories;

namespace LibraryApi.Models.Books
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public HashSet<BookRate> Rates { get; set; } = new();
        public int PageCount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }


    public class BookRate
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int BookId { get; set; }
    }
}

// Add AgeRange to Category
// Add Rate to Book
// Add PublishDate to Book
// Add Page count to Book

// get book by AgeRange
// GetAll Category -> see Category Rate

//Author -> books Category
//Which Author has the most Rate

//which Category has the most Content
//Wich Author has wrote the most content

//Add fluent api 
//Add fluent migration


//Read about fluent api and ef tips