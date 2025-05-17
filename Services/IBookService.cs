using BankApp.Api.Model;

namespace BankApp.Api.Services
{
    public interface IBookService
    {
        Task<Book> CreateBook(Book request);
        Task<Book> UpdateBook(Book request);
        Task<Book> GetBookById(int id);
        Task<Book> GetBooksByAuthorId(int authorId);
        Task<Book> GetBookByFilter(string category, string authorName, string publishedAt);
    }

    public class BookService : IBookService
    {
        public Task<Book> CreateBook(Book request)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookByFilter(string category, string authorName, string publishedAt)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBooksByAuthorId(int authorId)
        {
            throw new NotImplementedException();
        }

        public Task<Book> UpdateBook(Book request)
        {
            throw new NotImplementedException();
        }
    }
}
