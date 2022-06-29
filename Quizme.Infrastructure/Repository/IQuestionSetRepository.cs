using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Repository;

public interface IQuestionSetRepository : IRepository<QuestionSet>
{
    Task<QuestionSet> CreateAndGetAsync(QuestionSet questionSet);
}