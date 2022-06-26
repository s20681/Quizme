using Quizme.Core.DTO;
using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Repository;

namespace Quizme.Infrastructure.Services;

public class QuestionSetService : IQuestionSetService
{
    public QuestionSetService(IQuestionSetRepository questionSetRepository, IUserRepository userRepository)
    {
        _questionSetRepository = questionSetRepository;
        _userRepository = userRepository;
    }

    private readonly IQuestionSetRepository _questionSetRepository;
    private readonly IUserRepository _userRepository;

    
    //not sure if this one is right - need to check later
    public async Task AddNewQuestionSetToExistingUserAsync(QuestionSetBasicInformationDto dto)
    {
        var user = await _userRepository.GetByIdAsync(dto.OwnerId);

        await _questionSetRepository.AddAsync(new QuestionSet()
        {
            OwnerId = user.Id,
            TimeLimit = dto.TimeLimit,
            Questions = new List<Question>()
        });
    }
}