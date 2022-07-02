using Quizme.Core.DTO;
using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Repository;

namespace Quizme.Infrastructure.Services;

public interface IUserService
{
    Task CreateNewUserAccountAsync(UserCreationRequestDto dto);
    Task<IEnumerable<User>> GetAllUsersAsync();
}