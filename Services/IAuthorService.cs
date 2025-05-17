using BankApp.Api.Dtos.Requests;
using BankApp.Api.Dtos.Responses;
using BankApp.Api.Model;

namespace BankApp.Api.Services
{
    public interface IAuthorService
    {
        Task AddAuthor(AddAuthorRequest request);
        Task<Author> UpdateAuthor(Author request);
        Task<Author> GetAuthorById(int id);
        Task<IEnumerable<Author>> GetAllAuthor();
    }
}
