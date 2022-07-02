using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Repository;

namespace Quizme.Infrastructure.Services;

public class AnswerService : IAnswerService
{
    private readonly IAnswerRepository _answerRepository;

    public AnswerService(IAnswerRepository answerRepository)
    {
        _answerRepository = answerRepository;
    }

    public async Task CreateNewAnswerAsync(Answer answer)
    {
        await _answerRepository.AddAsync(answer);
    }

    public async Task CreateNewAnswerAndAddAsync(int id, Answer answer)
    {
        answer.QuestionId = id;
        await _answerRepository.AddAsync(answer);
    }

    public async Task DeleteByIdAsync(int answerId)
    {
        await _answerRepository.DeleteByIdAsync(answerId);
    }
    
    public async Task DeleteAllAsync()
    {
        await _answerRepository.DeleteAllAsync();
    }

    public Task AddToQuestion(int questionId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Answer>> GetAllAnswerAsync()
    {
        return _answerRepository.GetAllAsync();
    }

    public async Task<IEnumerable<Answer>> GetByQuestionAsync(int questionId)
    {
        return await _answerRepository.GetByQuestionAsync(questionId);
    }
}