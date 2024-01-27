using Domain.Entity;
using Domain.Entity.Enum;

namespace Infrastructure.SeedData;

public static class FakeDataFactory
{
    public static IEnumerable<Dish> Dishes = new List<Dish>()
    {
        new Dish()
        {
            //Id = 1,
            Name = "cottage cheese with fruits and berries",
            Structure = "cottage cheese, fruits and berries",
            Numberofcalories = 50,
            Typeofdish = Typeofdish.Breakfast,
            Typeofdiet = Typeofdiet.LowCarb,
            ImagePath = "",
        },
        new Dish()
        {
            //Id = 2,
            Name = "oatmeal porridge with nuts and honey",
            Structure = "oatmeal porridge, nuts and honey",
            Numberofcalories =  200,
            Typeofdish = Typeofdish.Breakfast,
            Typeofdiet = Typeofdiet.LowCarb,
            ImagePath = "",
        },
        new Dish()
        {
            //Id = 3,
            Name = "omelet with herbs and cheese",
            Structure = "eggs, milk, parsley and cheese",
            Numberofcalories = 150,
            Typeofdish = Typeofdish.Breakfast,
            Typeofdiet = Typeofdiet.Normal,
            ImagePath = "",
        },
        new Dish()
        {
            //Id = 3,
            Name = "vegetable soup with broccoli and carrots",
            Structure = "broccoli, potatoes, carrots, onions, water, spices",
            Numberofcalories = 80,
            Typeofdish = Typeofdish.Lunch,
            Typeofdiet = Typeofdiet.LowCarb,
            ImagePath = "",
        },
        new Dish()
        {
            //Id = 4,
            Name = "chicken cream soup",
            Structure = "chicken fillet, potatoes, onions, carrots, garlic, Water, cream, ground black pepper, salt",
            Numberofcalories = 310,
            Typeofdish = Typeofdish.Lunch,
            Typeofdiet = Typeofdiet.LowCarb,
            ImagePath = "",
        },
        new Dish()
        {
            //Id = 5,
            Name = "salad with baked salmon and cherryta",
            Structure = "salmon, spinach, cherry tomatoes, radish,olive oil, spices and seasonings (for fish), lemon juice, sea salt, pepper",
            Numberofcalories = 230,
            Typeofdish = Typeofdish.Lunch,
            Typeofdiet = Typeofdiet.Normal,
            ImagePath = "",
        },
        new Dish()
        {
            //Id = 6,
            Name = "vegetable salad with eggs and shrimp",
            Structure = "salad mix, tomatoes, shrimp, chicken eggs (boiled), mustard, vegetable oil, lemon juice, salt",
            Numberofcalories = 180,
            Typeofdish = Typeofdish.Dinner,
            Typeofdiet = Typeofdiet.Normal,
            ImagePath = "",
        },
        new Dish()
        {
            //Id = 7,
            Name = "pilaf with shrimp and vegetables",
            Structure = "rice, shrimp, green peas, carrots, bell pepper, butter, garlic, cumin, salt, water",
            Numberofcalories = 290,
            Typeofdish = Typeofdish.Dinner,
            Typeofdiet = Typeofdiet.LowCarb,
            ImagePath = "",
        },
        new Dish()
        {
            //Id = 8,
            Name = "sea bass fillet with vegetables",
            Structure = "corn, broccoli, sea bass (fillet), lemon juice, salt, spices and seasonings, vegetable oil, teriyaki sauce",
            Numberofcalories = 250,
            Typeofdish = Typeofdish.Dinner,
            Typeofdiet = Typeofdiet.LowCarb,
            ImagePath = "",
        },
    };

    public static IEnumerable<Menu> Menus = new List<Menu>()
    {
        new Menu()
        {
            EndDate = DateTime.Now.AddDays(7),
            Startdate = DateTime.Now,
            Typeofdiet = Typeofdiet.LowCarb,
            Name = "Меню ПП1",
            MenuDishes = new List<MenuDish>()
            {
                new MenuDish
                {
                    DishId = 1,
                },
                new MenuDish
                {
                    DishId = 2,
                }
            }
        },
        new Menu()
        {
            EndDate = DateTime.Now.AddDays(7),
            Startdate = DateTime.Now,
            Typeofdiet = Typeofdiet.Normal,
            Name = "Здоровье",
            MenuDishes = new List<MenuDish>()
            {
                new MenuDish
                {
                    DishId = 4,
                },
                new MenuDish
                {
                    DishId = 5,
                }
            }
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
            Userinfo = new Userinfo()
            {
                Age = 20,
                Gender = TypeOfGender.Male,
                Height = 180,
                Name = "TestUserName",
                Typeofdiet = Typeofdiet.HighCard,
                UserId = 1,
                Weight = 60
            }
        },
        new User()
        {
            //Id = 2,
            Email = "2test@mail.ru",
            Login = "2Login",
            Password = "2Pass",
            Userinfo = new Userinfo()
            {
                Age = 30,
                Gender = TypeOfGender.FeMale,
                Height = 150,
                Name = "2TestUserName",
                Typeofdiet = Typeofdiet.LowCarb,
                UserId = 2,
                Weight = 60
            }
        }
    };
}