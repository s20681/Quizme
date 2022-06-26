using Quizme.Core.DTO;

namespace Quizme.Infrastructure.Services;

public interface IQuestionSetService
{
    Task AddNewQuestionSetToExistingUserAsync(QuestionSetBasicInformationDto dto);
}