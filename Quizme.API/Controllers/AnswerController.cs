using Microsoft.AspNetCore.Mvc;

namespace Quizme.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnswerController : ControllerBase
{
    private readonly IAnswerService _answerService;
}