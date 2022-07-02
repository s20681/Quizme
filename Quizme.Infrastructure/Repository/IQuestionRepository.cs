using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Repository;

public interface IQuestionRepository : IRepository<Question>
{
    Task<IEnumerable<Question>> GetByQuestionSetAsync(int questionSetId);
}