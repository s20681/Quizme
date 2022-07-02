using Microsoft.EntityFrameworkCore;
using Quizme.Infrastructure.Context;
using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Exceptions;

namespace Quizme.Infrastructure.Repository;

public class AnswerRepository : IAnswerRepository
{
    private readonly MainContext _mainContext;

    public AnswerRepository(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    public async Task<IEnumerable<Answer>> GetAllAsync()
    {
        return await _mainContext.Answer.ToListAsync();
    }

    public async Task<Answer> GetByIdAsync(int id)
    {
        return await _mainContext.Answer.SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddAsync(Answer entity)
    {
        await _mainContext.AddAsync(entity);
        await _mainContext.SaveChangesAsync();
    }

    public Task UpdateAsync(Answer entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteByIdAsync(int id)
    {
        var toDelete = await _mainContext.Answer.SingleOrDefaultAsync(x => x.Id == id);
        if (toDelete != null)
        {
            _mainContext.Answer.Remove(toDelete);
            await _mainContext.SaveChangesAsync();    
        }
        else
        {
            throw new EntityNotFoundException();    
        }
    }
    
    public async Task DeleteAllAsync()
    {
        var answers = _mainContext.Answer.ToList();
        foreach (var ans in answers)
        {
            _mainContext.Remove(ans);
            await _mainContext.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Answer>> GetByQuestionAsync(int questionId)
    {
        var answers = await _mainContext.Answer.ToListAsync();
        return answers.FindAll(x => x.QuestionId == questionId);
    }
}