using Quizme.Core.DTO;
using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Services;

public interface IQuizService
{
    Task<IEnumerable<QuizBasicInformationResponseDto>> GetAllQuizzesBasicInfosAsync();
    
    Task<QuizBasicInformationResponseDto> GetQuestionSetInformationFromQuiz();
    
    Task<QuizBasicInformationResponseDto> GetTheHighestResultAsync();
    
    Task<QuizBasicInformationResponseDto> GetTheQuickestSolution();
    Task StartAsync(int userId);
    Task StopAsync(int quizzId);
    Task<Quiz> GetByIdAsync(int questionId);
}