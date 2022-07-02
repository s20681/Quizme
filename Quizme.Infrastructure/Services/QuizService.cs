using Quizme.Core.DTO;
using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Exceptions;
using Quizme.Infrastructure.Repository;

namespace Quizme.Infrastructure.Services;

public class QuizService : IQuizService
{
    private readonly IQuizRepository _quizRepository;
    private readonly IUserRepository _userRepository;

    public QuizService(IQuizRepository quizRepository, IUserRepository userRepository)
    {
        _quizRepository = quizRepository;
        _userRepository = userRepository;
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

    public async Task StartAsync(int userId)
    {
        var user = _userRepository.GetByIdAsync(userId).Result;

        if (user != null)
        {
            var quiz = new Quiz();
            quiz.TimeStarted = DateTime.Now;
            quiz.Respondent = user;
            await _quizRepository.AddAsync(quiz);
        }
        else
        {
            throw new EntityNotFoundException();
        }
    }
    
    public async Task StopAsync(int quizzId)
    {
    }

    public Task<Quiz> GetByIdAsync(int questionId)
    {
        throw new NotImplementedException();
    }
}