using Microsoft.AspNetCore.Mvc;

namespace EasyEat_WEB_API.Controllers;

[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase
{
    
    public LoginController()
    {
    }

    [HttpGet("{login}")]
    public string Login(string login)//, string password, string email)
    {
        return "тест пройден";
    }
}