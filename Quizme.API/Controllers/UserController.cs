using Microsoft.AspNetCore.Mvc;
using Quizme.Core.DTO;
using Quizme.Infrastructure.Services;

namespace Quizme.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> CreateNewUser([FromBody] UserCreationRequestDto dto)
    {
        await _userService.CreateNewUserAccountAsync(dto);
        return new NoContentResult();
    }
}