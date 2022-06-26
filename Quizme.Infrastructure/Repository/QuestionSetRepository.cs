using Quizme.Infrastructure.Context;
using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Repository;

public class QuestionSetRepository : IQuestionSetRepository
{
    private readonly MainContext _mainContext;

    public QuestionSetRepository(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    public Task<IEnumerable<QuestionSet>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<QuestionSet> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(QuestionSet entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(QuestionSet entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}