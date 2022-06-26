using Quizme.Infrastructure.Context;
using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Repository;

public class QuestionRepository : IQuestionRepository
{
    private readonly MainContext _mainContext;

    public QuestionRepository(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    public Task<IEnumerable<Question>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Question> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Question entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Question entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}