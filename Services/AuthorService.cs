using BankApp.Api.Data;
using BankApp.Api.Dtos.Requests;
using BankApp.Api.Dtos.Responses;
using BankApp.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Api.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly ApplicationDbContext _dbContext;

        public AuthorService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task AddAuthor(AddAuthorRequest request)
        {
            var author = new Author()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                DateOfBirth = request.DateOfBirth,
                Nationality = request.Nationality,
                //CreatedAt = DateTime.Now,
            };
            await _dbContext.Set<Author>().AddAsync(author);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Author> UpdateAuthor(Author request)
        {
            throw new NotImplementedException();
        }


        public async Task<Author?> GetAuthorById(int id)
        {
            return await _dbContext.Set<Author>().FirstOrDefaultAsync(Author => Author.Id == id);
        }
        public async Task<IEnumerable<Author>> GetAllAuthor()
        {
            return _dbContext.Set<Author>().ToList();
        }
    }
}
