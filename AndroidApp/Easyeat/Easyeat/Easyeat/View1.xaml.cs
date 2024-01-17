using Easyeat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Easyeat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class View1 : ContentPage
    {
        public User UserUser { get; set; }
        public View1(User user)
        {
            InitializeComponent();
            UserUser = user;
            Height.Items.Add("150");
            Height.Items.Add("160");
            Height.Items.Add("170");
            Height.Items.Add("180");
            Age.Items.Add("18");
            Age.Items.Add("19");
            Age.Items.Add("20");
            Age.Items.Add("30");
            Weight.Items.Add("56");
            Weight.Items.Add("63");
            Weight.Items.Add("70");
            Weight.Items.Add("85");
            Gender.Items.Add("women");
            Gender.Items.Add("men");
            Goal.Items.Add("lose weight");
            Goal.Items.Add("gain weight");
            Goal.Items.Add("maintain existing weight");
            Typeofdiet.Items.Add("low - calorie diet");
            Typeofdiet.Items.Add("low-carb diet");
            Typeofdiet.Items.Add("balanced diet");
        }
        private void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            var u = new Domain.User() { Id = 1, Login = "Qwerty", Password = "12345678", Email = "qwer@.ru" };
            App.DBContext.SaveUser(
               u
               );
        }
        private async void Button_SaveAsync(object sender, EventArgs e)
        {
            var u = new Domain.Userinfo();

            u.Name = nameField.Text.Trim();
            u.Height = Height.Items[Height.SelectedIndex];
            u.Age = Age.Items[Age.SelectedIndex];
            u.Weight = Weight.Items[Weight.SelectedIndex];
            u.Gender = Gender.Items[Gender.SelectedIndex];
            u.Goal = Goal.Items[Goal.SelectedIndex];
            u.Typeofdiet = Typeofdiet.Items[Typeofdiet.SelectedIndex];
            u.UserId = UserUser.Id; 
            App.DBContext.SaveUserinfo(u);
            await Navigation.PushModalAsync(new Profil(u));
        }
       
    }
}