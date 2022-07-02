using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Repository;

namespace Quizme.Infrastructure.Services;

public class QuestionService : IQuestionService
{
    private readonly IQuestionRepository _questionRepository;

    public QuestionService(IQuestionRepository questionRepository)
    {
        _questionRepository = questionRepository;
    }

    public async Task CreateNewQuestionAsync(Question question)
    {
        await _questionRepository.AddAsync(question);
    }
    
    public async Task<IEnumerable<Question>> GetAllQuestionsAsync()
    {
        return await _questionRepository.GetAllAsync();
    }

    public async Task<Question> GetByIdAsync(int questionId)
    {
        return await _questionRepository.GetByIdAsync(questionId);
    }

    public async Task<IEnumerable<Question>> GetByQuestionSetAsync(int questionSetId)
    {
        return await _questionRepository.GetByQuestionSetAsync(questionSetId);
    }

    public async Task DeleteByIdAsync(int questionId)
    { 
        await _questionRepository.DeleteByIdAsync(questionId);
    }
}