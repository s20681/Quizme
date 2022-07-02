using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Repository;

public interface IAnswerRepository : IRepository<Answer>
{
    Task<IEnumerable<Answer>> GetByQuestionAsync(int questionId);
    Task DeleteAllAsync();
}