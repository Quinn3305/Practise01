using Microsoft.AspNetCore.Mvc;
using TestRepo.Service.User;

namespace TestRepo.Api.Controller;
[ApiController]
[Route("[controller]")]
public class UserController: ControllerBase
{
    private readonly IService _UserService;

    public UserController(IService userService)
    {
        _UserService = userService;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateUser(Request.CreateUserRequest request)
    {
        var user = await _UserService.CreateUser(request);
        return Ok(user);
    }
    
    [HttpGet("")]
    public async Task<IActionResult> GetUser(string? searchTerm, int pageIndex = 1, int pageSize = 10)
    {
        var user = await _UserService.GetUser(searchTerm, pageIndex, pageSize);
        return Ok(user);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        var user = await _UserService.GetUserById(id);
        return Ok(user);
    }
}