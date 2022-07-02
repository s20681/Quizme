using Microsoft.AspNetCore.Mvc;
using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Services;

namespace Quizme.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnswerController : ControllerBase
{
    private readonly IAnswerService _answerService;

    public AnswerController(IAnswerService answerService)
    {
        _answerService = answerService;
    }
    
    [HttpPost("Create")]
    public async Task<IActionResult> CreateNewAnswer([FromBody] Answer answer)
    {
        await _answerService.CreateNewAnswerAsync(answer);
        return new NoContentResult();
    }
    
    [HttpPost("CreateAdd/{id}")]
    public async Task<IActionResult> CreateNewAnswerAndAddToQuestion(int id, [FromBody] Answer answer)
    {
        await _answerService.CreateNewAnswerAndAddAsync(id, answer);
        return new NoContentResult();
    }
    
    [HttpGet("All")]
    public async Task<IActionResult> All()
    {
        var questions = await _answerService.GetAllAnswerAsync();
        return new OkObjectResult(questions);
    }
    
    [HttpGet("AllByQuestion/{questionId}")]
    public async Task<IActionResult> ByQuestion(int questionId)
    {
        var answers = await _answerService.GetByQuestionAsync(questionId);
        return new OkObjectResult(answers);
    }
    
    [HttpDelete("Remove/{answerId}")]
    public async Task<IActionResult> RemoveAnswer(int answerId)
    {
        await _answerService.DeleteByIdAsync(answerId);
        return new NoContentResult();
    }
    
    [HttpDelete("Removeall")]
    public async Task<IActionResult> RemoveAll()
    {
        await _answerService.DeleteAllAsync();
        return new NoContentResult();
    }
}