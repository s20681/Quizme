using Quizme.Infrastructure.Context;
using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Repository;

public class AnswerRepository : IAnswerRepository
{
    private readonly MainContext _mainContext;

    public AnswerRepository(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    public Task<IEnumerable<Answer>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Answer> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Answer entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Answer entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}