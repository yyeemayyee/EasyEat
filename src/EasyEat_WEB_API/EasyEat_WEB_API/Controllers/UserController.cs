using Domain.Entity;
using Domain.Entity.Enum;
using Infrastructure.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;

namespace EasyEat_WEB_API.Controllers;

public class ProfileModel2
{
    public string name { get; set; }
    public string hight { get; set; }
}

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
    
    [HttpGet("{id}")]
    public async Task<ProfileModel2> Get(int id)
    {
        var userInfoList = await _userInfoRepository.GetAllAsync();
        var userInfo = userInfoList.FirstOrDefault(p => p.UserId == id);
        if (userInfo !=null)
        {
            return new ProfileModel2
            {
                name = userInfo.Name,
                hight = userInfo.Height.ToString()
            };
        }

        return null;
    }

    [HttpPost("add")]
    public async Task Add(ProfileModel model)
    {
        
        var userInfoList = await _userInfoRepository.GetAllAsync();
        if (userInfoList.Any(p=>p.UserId == model.userId))
        {
            return;
        }
        
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