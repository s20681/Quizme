using Microsoft.AspNetCore.Mvc;
using Quizme.Infrastructure.Entities;
using Quizme.Infrastructure.Services;

namespace Quizme.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuestionSetController
{
    private readonly IQuestionSetService _questionSetService;

    public QuestionSetController(IQuestionSetService questionSetService)
    {
        _questionSetService = questionSetService;
    }
}