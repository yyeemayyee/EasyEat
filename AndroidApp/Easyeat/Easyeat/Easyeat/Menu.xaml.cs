using Easyeat.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace Easyeat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        
        public List<DishItem> Dishes { get; set; }
        public Userinfo UserInfo { get; private set; }

        public Menu(string Typeofdiet, string eating, Userinfo userinfo)
            
        {
            UserInfo = userinfo;
            InitializeComponent();
            var d = App.DBContext.GetDishByTipe(Typeofdiet, eating);
            Dishes = d.Select(p=>new DishItem
            {
                ImagePath = "https://i.mycdn.me/i?r=AzEPZsRbOZEKgBhR0XGMT1RkADhTBJRp4Kl2qGrKpSBKf6aKTM5SRkZCeTgDn6uOyic", Name=p.Name, Structure=p.Structure
            })
                .ToList();
           Dishes = new List<DishItem>
        {
           new DishItem  {Name= "cottage cheese with fruits and berries", Structure= "cottage cheese, fruits and berries", ImagePath="https://i.mycdn.me/i?r=AzEPZsRbOZEKgBhR0XGMT1RkADhTBJRp4Kl2qGrKpSBKf6aKTM5SRkZCeTgDn6uOyic"},
           new DishItem  {Name= "omelet with herbs and cheese", Structure= "eggs, milk, parsley and cheese", ImagePath="https://thumbs.dreamstime.com/b/omelette-tomatoes-ham-cheese-green-herbs-plate-frittata-italian-omelet-183980366.jpg"},
           new DishItem  {Name= "vegetable soup with broccoli and carrots", Structure= "broccoli, potatoes, carrots, onions, water, spices", ImagePath="https://www.photorecept.ru/wp-content/uploads/2022/01/kurinyj-sup-s-seldereem-i-ovoshhami-2.jpg"},
           new DishItem  {Name= "chicken cream soup", Structure= "chicken fillet, potatoes, onions, carrots, garlic, Water, cream, ground black pepper, salt", ImagePath="https://pigmine.ru/wp-content/uploads/3/8/9/389d4e17dce793697f56227bd9f01a5b.jpeg"},
           new DishItem  {Name= "salad with baked salmon and cherry tomatoes", Structure= "salmon, spinach, cherry tomatoes, radish,olive oil, spices and seasonings (for fish), lemon juice, sea salt, pepper", ImagePath="https://i.lefood.menu/wp-content/uploads/w_images/2021/10/recept-10392-1240x821.jpg"},
           new DishItem  {Name= "vegetable salad with eggs and shrimp", Structure= "salad mix, tomatoes, shrimp, chicken eggs (boiled), mustard, vegetable oil, lemon juice, salt", ImagePath="https://de-fragrance.ru/wp-content/uploads/9/3/d/93d1de5d15baad2e04b10333eabc7122.jpeg"},
           new DishItem  {Name= "pilaf with shrimp and vegetables", Structure= "rice, shrimp, green peas, carrots, bell pepper, butter, garlic, cumin, salt, water", ImagePath="https://img4.goodfon.ru/original/1920x1279/7/98/ris-rizotto-krevetki-zelen.jpg"},
           new DishItem  {Name= "sea bass fillet with vegetables", Structure= "corn, broccoli, sea bass (fillet), lemon juice, salt, spices and seasonings, vegetable oil, teriyaki sauce", ImagePath="https://donatewales.org/wp-content/uploads/e/e/8/ee89c22c5ee3eea9d3acea3aeac679b5.jpeg"},
          
        };
            this.BindingContext = this;
        }
        private async void Button_Progress(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Progress(UserInfo));

        }
        private async void Button_Profil(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Profil(UserInfo));

        }
        private async void Button_Menu(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Menu2(UserInfo));

        }
    }
    public class DishItem
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Structure { get; set; }
     
    }

}