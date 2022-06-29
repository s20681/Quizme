using Quizme.Core.DTO;
using Quizme.Infrastructure.Repository;

namespace Quizme.Infrastructure.Services;

public class QuizService : IQuizService
{
    private readonly IQuizRepository _quizRepository;

    public QuizService(IQuizRepository quizRepository)
    {
        _quizRepository = quizRepository;
    }

    public async Task<IEnumerable<QuizBasicInformationResponseDto>> GetAllQuizzesBasicInfosAsync()
    {
        var quizzes = await _quizRepository.GetAllAsync();

        return quizzes.Select(x => new QuizBasicInformationResponseDto(
            x.Respondent.Name,
            x.Result,
            x.TimeStarted,
            x.TimeEnded,
            x.IsDone
            ));
    }

    public Task<QuizBasicInformationResponseDto> GetQuestionSetInformationFromQuiz()
    {
        throw new NotImplementedException();
    }

    public async Task<QuizBasicInformationResponseDto> GetTheHighestResultAsync()
    {
        var quizzes = await _quizRepository.GetAllAsync();
        var highestResultQuiz = quizzes.MaxBy(x => x.Result);

        if (highestResultQuiz == null) return new QuizBasicInformationResponseDto(0);

        return new QuizBasicInformationResponseDto(
            highestResultQuiz.Respondent.Name,
            highestResultQuiz.Result,
            highestResultQuiz.TimeStarted,
            highestResultQuiz.TimeEnded,
            highestResultQuiz.IsDone
        );
    }

    public Task<QuizBasicInformationResponseDto> GetTheQuickestSolution()
    {
        throw new NotImplementedException();
    }
}