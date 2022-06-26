using Microsoft.EntityFrameworkCore;
using Quizme.Infrastructure.Context;
using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Exceptions;

namespace Quizme.Infrastructure.Repository;

public class QuizRepository : IQuizRepository
{
    private readonly MainContext _mainContext;
    
    public QuizRepository(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    public async Task<IEnumerable<Quiz>> GetAllAsync()
    {
        var quizzes = await _mainContext.Quiz.ToListAsync();

        foreach (var quiz in quizzes)
        {
            await _mainContext.Entry(quiz).Reference(x => x.Questions).LoadAsync();
            await _mainContext.Entry(quiz).Reference(x => x.Respondent).LoadAsync();
        }

        return quizzes;
    }

    public async Task<Quiz> GetByIdAsync(int id)
    {
        var quiz = await _mainContext.Quiz.SingleOrDefaultAsync(x => x.Id == id);
        if (quiz != null)
        {
            await _mainContext.Entry(quiz).Reference(x => x.Questions).LoadAsync();
            await _mainContext.Entry(quiz).Reference(x => x.Respondent).LoadAsync();

            return quiz;
        }

        throw new EntityNotFoundException();
    }

    public async Task AddAsync(Quiz entity)
    {
        entity.DateOfCreation = DateTime.Now;
        await _mainContext.AddAsync(entity);
        await _mainContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Quiz entity)
    {
        var quizToUpdate = await _mainContext.Quiz.SingleOrDefaultAsync(x => x.Id == entity.Id);

        if (quizToUpdate == null)
        {
            throw new EntityNotFoundException();
        }

        quizToUpdate.Type = entity.Type;
        quizToUpdate.Result = entity.Result;
        quizToUpdate.TimeStarted = entity.TimeStarted;
        quizToUpdate.TimeEnded = entity.TimeEnded;
        quizToUpdate.IsDone = entity.IsDone;
    }

    public async Task DeleteByIdAsync(int id)
    {
        var quizToDelete = await _mainContext.Quiz.SingleOrDefaultAsync(x => x.Id == id);
        if (quizToDelete != null)
        {
            _mainContext.Quiz.Remove(quizToDelete);
            await _mainContext.SaveChangesAsync();
        }

        throw new EntityNotFoundException();
    }
}