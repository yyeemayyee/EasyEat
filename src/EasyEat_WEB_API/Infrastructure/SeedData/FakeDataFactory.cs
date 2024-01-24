using Domain.Entity;
using Domain.Entity.Enum;

namespace Infrastructure.SeedData;

public static class FakeDataFactory
{
    public static IEnumerable<Dish> Dishes = new List<Dish>()
    {
        new Dish()
        {
            //Name =,
            //Structure
        },
        new Dish()
        {
        },
        new Dish()
        {
        },
    };
    public static IEnumerable<User> Users = new List<User>()
    {
        new User()
        {
            //Id = 1,
            Email = "test@mail.ru",
            Login = "Login",
            Password = "Pass",
            /*Userinfo = new Userinfo()
            {
                Age = 20,
                Gender = TypeOfGender.Male,
                Height = 180,
                Id = 1,
                Name = "TestUserName",
                Typeofdiet = Typeofdiet.HighCard,
                UserId = 1,
                Weight = 60
            }*/
        },
        new User()
        {
            //Id = 2,
            Email = "2test@mail.ru",
            Login = "2Login",
            Password = "2Pass",
            /*Userinfo = new Userinfo()
            {
                Age = 30,
                Gender = TypeOfGender.FeMale,
                Height = 150,
                Id = 2,
                Name = "2TestUserName",
                Typeofdiet = Typeofdiet.LowCarb,
                UserId = 2,
                Weight = 60
            }*/
        }
    };
}