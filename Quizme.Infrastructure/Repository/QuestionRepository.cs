using Microsoft.EntityFrameworkCore;
using Quizme.Infrastructure.Context;
using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Exceptions;

namespace Quizme.Infrastructure.Repository;

public class QuestionRepository : IQuestionRepository
{
    private readonly MainContext _mainContext;

    public QuestionRepository(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    public async Task<IEnumerable<Question>> GetAllAsync()
    {
        return await _mainContext.Question.ToListAsync();
    }

    public async Task<Question> GetByIdAsync(int id)
    {
        return await _mainContext.Question.SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddAsync(Question entity)
    {
        await _mainContext.AddAsync(entity);
        await _mainContext.SaveChangesAsync();
    }

    public Task UpdateAsync(Question entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteByIdAsync(int id)
    {
        var toDelete = await _mainContext.Question.SingleOrDefaultAsync(x => x.Id == id);
        if (toDelete != null)
        {
            _mainContext.Question.Remove(toDelete);
            await _mainContext.SaveChangesAsync();    
        }
        else
        {
            throw new EntityNotFoundException();    
        }
    }

    public async Task<IEnumerable<Question>> GetByQuestionSetAsync(int questionSetId)
    {
        var questions = await _mainContext.Question.ToListAsync();
        return questions.FindAll(x => x.QuestionSetId == questionSetId);
    }
}