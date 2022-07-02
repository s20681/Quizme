using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Services;

public interface IQuestionService
{
    Task CreateNewQuestionAsync(Question question);
    Task DeleteByIdAsync(int questonId);
    Task<IEnumerable<Question>> GetByQuestionSetAsync(int questionSetId);
    Task<IEnumerable<Question>> GetAllQuestionsAsync();
}