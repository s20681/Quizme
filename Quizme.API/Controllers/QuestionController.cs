using Microsoft.AspNetCore.Mvc;
using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Services;

namespace Quizme.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuestionController : ControllerBase
{
    private readonly IQuestionService _questionService;

    public QuestionController(IQuestionService questionService)
    {
        _questionService = questionService;
    }
    
    [HttpGet("Get/{questionId}")]
    public async Task<IActionResult> getById(int questionId)
    {
        var question = await _questionService.GetByIdAsync(questionId);
        return new OkObjectResult(question);
    }
    
    [HttpPost("Create")]
    public async Task<IActionResult> CreateNewQuestion([FromBody] Question question)
    {
        await _questionService.CreateNewQuestionAsync(question);
        return new NoContentResult();
    }
    
    [HttpDelete("Remove/{questionId}")]
    public async Task<IActionResult> RemoveQuestion(int questionId)
    {
        await _questionService.DeleteByIdAsync(questionId);
        return new NoContentResult();
    }

    
    [HttpGet("All")]
    public async Task<IActionResult> All()
    {
        var questions = await _questionService.GetAllQuestionsAsync();
        return new OkObjectResult(questions);
    }
    
    [HttpGet("AllByQuestionSet")]
    public async Task<IActionResult> ByQuestionSet(int questionSetId)
    {
        var questions = await _questionService.GetByQuestionSetAsync(questionSetId);
        return new OkObjectResult(questions);
    }
}