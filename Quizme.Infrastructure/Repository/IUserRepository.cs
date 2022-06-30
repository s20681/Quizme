using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Repository;

public interface IUserRepository : IRepository<User>
{
    Task<User> GetByEmailAsync(String email);
}