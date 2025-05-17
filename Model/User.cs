using System.ComponentModel.DataAnnotations;

namespace BankApp.Api.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public int NumberOfPages { get; set; }
        public Genre Genre { get; set; }
        public DateTime PublisedAt { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public char Currency { get; set; }
        public virtual Author Author { get; set; }  
    }

    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
       // public DateTime CreatedAt { get; set; } 
        public virtual ICollection<Book>? Books { get; set; }
    }


    public enum Genre
    {
        Fantasy = 1,
        Romance, 
        Commedy,
        Horror
    }
}
