using Quizme.Infrastructure.Context;
using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly MainContext _mainContext;

    public UserRepository(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    public Task<IEnumerable<User>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(User entity)
    {
        throw new NotImplementedException();
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