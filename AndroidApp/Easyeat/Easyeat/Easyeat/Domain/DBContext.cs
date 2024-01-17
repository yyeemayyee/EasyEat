using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Easyeat.Domain
{
    public class DBContext
    {
        public readonly SQLiteConnection connection;
        public DBContext(string path)
        {
            var p = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                "ormdemo.db3");
            connection = new SQLiteConnection(p);
            connection.CreateTable<User>();
            connection.CreateTable<Userinfo>();
            connection.CreateTable<Progress>();
            connection.DropTable<Dish>();
            connection.CreateTable<Dish>();
            var list = connection.Query<Dish>("select * from Dish");
            if (list.Count()==0)
            {
                InsertDataDish();
            }
        }
        public void SaveUser(User user) 
        { 
            connection.Insert(user);

        }
        public int GetCountUser()
        {
            var list = connection.Query<User>("select * from User");
            return list.Count();
        }
        public User GetUser(string login,string password, string email) 
        {
            var list = connection.Query<User>("select * from User where Login=? and Password=? and Email=?", login, password, email);
            return list.LastOrDefault();
        }
        public void SaveUserinfo(Userinfo userinfo)
        {
            connection.Insert(userinfo);

        }
        public Userinfo GetUserinfo(int Id)
        {
            var list = connection.Query<Userinfo>("select * from Userinfo where UserId=?", Id);
            return list.FirstOrDefault();
        }

        internal object GetUserInfo(string name, string height, string age, string weight, string gengder, string goal, string typeofdiet)
        {
            throw new NotImplementedException();
        }
        public void SaveProgress(Progress progress)
        {
            connection.Insert(progress);

        }
       
        public void InsertDataDish()
        {
            var d1 = new Dish {Id=1, Name= "cottage cheese with fruits and berries", Typeofdiet= "low - calorie diet", Typeofdish = "Breakfast", Structure= "cottage cheese, fruits and berries", Numberofcalories="50"};
            var d2 = new Dish { Id = 2, Name = "oatmeal porridge with nuts and honey", Typeofdiet = "low-carb diet", Typeofdish = "Breakfast", Structure = "oatmeal porridge, nuts and honey", Numberofcalories = "200" };
            var d3 = new Dish { Id = 3, Name = "omelet with herbs and cheese", Typeofdiet = "balanced diet", Typeofdish = "Breakfast", Structure = "eggs, milk, parsley and cheese", Numberofcalories = "150" };
            var d4 = new Dish { Id = 4, Name = "vegetable soup with broccoli and carrots", Typeofdiet = "low - calorie diet", Typeofdish = "Lunch", Structure = "broccoli, potatoes, carrots, onions, water, spices", Numberofcalories = "80" };
            var d5 = new Dish { Id = 5, Name = "chicken cream soup", Typeofdiet = "low-carb diet", Typeofdish = "Lunch", Structure = "chicken fillet, potatoes, onions, carrots, garlic, Water, cream, ground black pepper, salt", Numberofcalories = "310" };
            var d6 = new Dish { Id = 6, Name = "salad with baked salmon and cherryta", Typeofdiet = "balanced diet", Typeofdish = "Lunch", Structure = "salmon, spinach, cherry tomatoes, radish,olive oil, spices and seasonings (for fish), lemon juice, sea salt, pepper", Numberofcalories = "230" };
            var d7 = new Dish { Id = 7, Name = "vegetable salad with eggs and shrimp", Typeofdiet = "balanced diet", Typeofdish = "Dinner", Structure = "salad mix, tomatoes, shrimp, chicken eggs (boiled), mustard, vegetable oil, lemon juice, salt", Numberofcalories = "180" };
            var d8 = new Dish { Id = 8, Name = "pilaf with shrimp and vegetables", Typeofdiet = "low - calorie diet", Typeofdish = "Dinner", Structure = "rice, shrimp, green peas, carrots, bell pepper, butter, garlic, cumin, salt, water", Numberofcalories = "290" };
            var d9 = new Dish { Id = 9, Name = "sea bass fillet with vegetables", Typeofdiet = "low-carb diet", Typeofdish = "Dinner", Structure = "corn, broccoli, sea bass (fillet), lemon juice, salt, spices and seasonings, vegetable oil, teriyaki sauce", Numberofcalories = "250" };
            connection.Insert(d1);
            connection.Insert(d2);
            connection.Insert(d3);
            connection.Insert(d4);
            connection.Insert(d5);
            connection.Insert(d6);
            connection.Insert(d7);
            connection.Insert(d8);
            connection.Insert(d9);

        }
        public List<Dish> GetDishByTipe(string typeofdiet, string typeofdish)
        {
            List<Dish> dish = new List<Dish>();
            var list = connection.Query<Dish>("select * from  Dish  where Typeofdiet=? and Typeofdish=? ", typeofdiet, typeofdish);
            return list;
        }
    }
}
