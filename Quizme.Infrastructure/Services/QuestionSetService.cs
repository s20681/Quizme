using Quizme.Core.DTO;
using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Exceptions;
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

        if (user != null)
        {
            var questionSet = await _questionSetRepository.CreateAndGetAsync(
                new QuestionSet(
                    dto.OwnerId,
                    dto.TimeLimit
                ));
        }
        else
        {
            throw new EntityNotFoundException();
        }
    }

    public Task AddQuestionAsync(Question question)
    {
        throw new NotImplementedException();
    }

    public Task CreateNewQuestionAsync(Question question)
    {
        throw new NotImplementedException();
    }
}