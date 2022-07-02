using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Services;

public interface IAnswerService
{
    Task CreateNewAnswerAsync(Answer answer);
    Task CreateNewAnswerAndAddAsync(int id, Answer answer);
    Task DeleteByIdAsync(int answerId);
    
    Task DeleteAllAsync();
    Task AddToQuestion(int questionId);
    Task<IEnumerable<Answer>> GetAllAnswerAsync();
    Task<IEnumerable<Answer>> GetByQuestionAsync(int questionId);
}