using Infrastructure.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace EasyEat_WEB_API.Controllers;

public class AuthModel
{
    public string login { get; set; }
    public string password { get; set; }
    public string email { get; set; }
}

[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    public LoginController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet("{id}")]
    public async Task<bool> Login(string login , string password)
    {
        var user = await _userRepository.GetUserByAuthData(login, password);
        return user!=null;
    }
}