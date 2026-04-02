using Microsoft.AspNetCore.Mvc;
using TestRepo.Service.User;

namespace TestRepo.Api.Controller;
[ApiController]
[Route("[controller]")]
public class UserController: ControllerBase
{
    private readonly IService UserService;

    public UserController(IService userService)
    {
        UserService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(Request.CreateUserRequest request)
    {
        var user = await UserService.CreateUser(request);
        return Ok(user);
    }
}