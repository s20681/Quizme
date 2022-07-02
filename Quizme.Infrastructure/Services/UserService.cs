using System.ComponentModel;
using System.Web;
using Quizme.Core.DTO;
using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Exceptions;
using Quizme.Infrastructure.Repository;

namespace Quizme.Infrastructure.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task CreateNewUserAccountAsync(UserCreationRequestDto dto)
    {
        var user = new User(
            dto.Name,
            dto.Email);

        var findUserByEmail = await _userRepository.GetByEmailAsync(dto.Email);
        if (findUserByEmail == null)
        {
            await _userRepository.AddAsync(user);    
        }else
        {
            throw new DuplicateEntityException();
        }
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _userRepository.GetAllAsync();
    }
    
}