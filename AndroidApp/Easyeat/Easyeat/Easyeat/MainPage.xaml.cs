using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Easyeat
{
    public partial class MainPage : ContentPage

    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_SighIn(object sender, EventArgs e)
        {
            var login = loginField.Text.Trim();
            var password = passField.Text.Trim();
            var email = emailField.Text.Trim();
            var User = App.DBContext.GetUser(login,password,email);
            var UserInfo = App.DBContext.GetUserinfo(User.Id);
            if (User != null && UserInfo != null)
            {
                await Navigation.PushModalAsync(new Profil(UserInfo));
            }
            else
            {
                await DisplayAlert("Alert", "There is no such user", "OK");
            }
 
        }
        private async void Button_Registration(object sender, EventArgs e)
        {
            var login = loginField.Text.Trim();
            var password = passField.Text.Trim();
            var email = emailField.Text.Trim();
            var id = App.DBContext.GetCountUser();
            var u = new Domain.User() { Id = id, Login = loginField.Text.Trim(), Password = passField.Text.Trim(), Email = emailField.Text.Trim() };
            App.DBContext.SaveUser(u);
            await Navigation.PushModalAsync(new View1(u));

        }
    }
}
