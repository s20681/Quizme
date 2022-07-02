using Microsoft.AspNetCore.Mvc;
using Quizme.Infrastructure.Services;

namespace Quizme.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuizController
{
    private readonly IQuizService _quizService;

    public QuizController(IQuizService quizService)
    {
        _quizService = quizService;
    }

    [HttpPost("start")]
    public async Task<IActionResult> startQuiz(int userId)
    {
        await _quizService.StartAsync(userId);
        return new NoContentResult();
    }
    
    [HttpPost("stop/{quizzId}")]
    public async Task<IActionResult> stopQuiz(int quizzId)
    {
        await _quizService.StopAsync(quizzId);
        return new NoContentResult();
    }
    
    [HttpPost("Get/{questionId}")]
    public async Task<IActionResult> getById(int questionId)
    {
        var quiz = await _quizService.GetByIdAsync(questionId);
        return new OkObjectResult(quiz);
    }
}