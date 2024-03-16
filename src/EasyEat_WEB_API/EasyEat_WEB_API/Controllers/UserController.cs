using Domain.Entity;
using Domain.Entity.Enum;
using Infrastructure.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace EasyEat_WEB_API.Controllers;

public class ProfileModel
{
    public int userId { get; set; }
    public int gender { get; set; }
    public string name { get; set; }
    public int hight { get; set; }
    public int weight { get; set; }
    public int age { get; set; }
    public int typeDiet { get; set; }
}

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserinfoRepository _userInfoRepository;
    
    public UserController(IUserinfoRepository userInfoRepository)
    {
        _userInfoRepository = userInfoRepository;
    }
    
    [HttpPost("add")]
    public async Task Add(ProfileModel model)
    {
        var useinfo = new Userinfo()
        {
            UserId = model.userId,
            Age = model.age,
            Gender = model.gender == 10 ? TypeOfGender.FeMale : TypeOfGender.Male,
            Height = model.hight,
            Name = model.name,
            Typeofdiet = MapTypeofdiet(model.typeDiet),
            Weight = model.weight
        };
            
        await _userInfoRepository.AddAsync(useinfo);
        await _userInfoRepository.SaveChangesAsync();
    }
        
    private Typeofdiet MapTypeofdiet(int Typeofdiet)
    {
        return (Typeofdiet) switch
        {
            10 => Domain.Entity.Enum.Typeofdiet.Normal,
            20 => Domain.Entity.Enum.Typeofdiet.LowCarb,
            30 => Domain.Entity.Enum.Typeofdiet.HighCard
        };
    }
}