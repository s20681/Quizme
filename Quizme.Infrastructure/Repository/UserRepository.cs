using Microsoft.EntityFrameworkCore;
using Quizme.Infrastructure.Context;
using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Exceptions;
using System.Web;

namespace Quizme.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly MainContext _mainContext;

    public UserRepository(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _mainContext.User.ToListAsync();
    }

    public async Task<User> GetByIdAsync(int id)
    {
        return await _mainContext.User.SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task<User> GetByEmailAsync(string email)
    {
        return await _mainContext.User.SingleOrDefaultAsync(x => x.Email == email);
    }

    public async Task AddAsync(User entity)
    {
        var userAlreadyFound = await _mainContext.User.SingleOrDefaultAsync(
            x => x.Name == entity.Name
                 && x.Email == entity.Email) != null;

        if (userAlreadyFound)
            throw new DuplicateEntityException();
        else
        {
            entity.DateOfCreation = DateTime.Now;
            entity.Password = "1287128762148712874984216491";
            await _mainContext.AddAsync(entity);
            await _mainContext.SaveChangesAsync();    
        }
    }

    public Task UpdateAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}