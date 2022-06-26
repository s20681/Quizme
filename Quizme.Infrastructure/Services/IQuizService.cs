using Quizme.Core.DTO;

namespace Quizme.Infrastructure.Services;

public interface IQuizService
{
    Task<IEnumerable<QuizBasicInformationResponseDto>> GetAllQuizzesBasicInfosAsync();
    
    Task<QuizBasicInformationResponseDto> GetQuestionSetInformationFromQuiz();
    
    Task<QuizBasicInformationResponseDto> GetTheHighestResultAsync();
    
    Task<QuizBasicInformationResponseDto> GetTheQuickestSolution();
}