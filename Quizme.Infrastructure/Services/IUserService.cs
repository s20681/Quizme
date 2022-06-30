using Quizme.Core.DTO;

namespace Quizme.Infrastructure.Services;

public interface IUserService
{
    Task CreateNewUserAccountAsync(UserCreationRequestDto dto);
}