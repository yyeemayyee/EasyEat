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
    public partial class Progress : ContentPage
    {
        public Userinfo UserInfo { get; set; }
        public Progress(Userinfo userinfo)
        {
            InitializeComponent();
            UserInfo = userinfo;
            goalField.Text = userinfo.Goal;
        }
        private async void Button_SaveAsync(object sender, EventArgs e)
        {
            var u = new Domain.Progress();

            u.Value = Weight.Text.Trim();
            u.Date = Date.Text.Trim();
            u.IdUserinfo = UserInfo.Id;
            App.DBContext.SaveProgress(u);
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