using Easyeat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Easyeat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu2 : ContentPage
    {
        public Userinfo UserInfo { get; set; }
        public Menu2(Userinfo userinfo)

        {
            UserInfo = userinfo;
            InitializeComponent();
        }
        private async void Button_Breakfast (object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Menu(UserInfo.Typeofdiet, "Breakfast", UserInfo));

        }
        private async void Button_Lunch(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Menu(UserInfo.Typeofdiet, "Lunch", UserInfo));

        }
        private async void Button_Dinner(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Menu(UserInfo.Typeofdiet, "Dinner", UserInfo));

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
}