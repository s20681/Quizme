using Quizme.Core.DTO;
using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Services;

public interface IQuestionSetService
{
    Task AddNewQuestionSetToExistingUserAsync(QuestionSetBasicInformationDto dto);
    Task AddQuestionAsync(Question question);
    Task CreateNewQuestionAsync(Question question);
}