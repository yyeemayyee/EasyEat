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
    public partial class Profil : ContentPage
    {
        public Userinfo UserInfo { get; set; }
        public Profil(Userinfo userinfo)
        {
            UserInfo = userinfo;
            InitializeComponent();
            nameField.Text = "Name: "+userinfo.Name;
            heightField.Text = "Height: "+userinfo.Height;
            weightField.Text = "Weight: "+ userinfo.Weight;
            ageField.Text = "Age: "+userinfo.Age;
            genderField.Text = "Gender: "+ userinfo.Gender;
            goalField.Title = "Goal: "+userinfo.Goal;
            typeofdietField.Title = "Typeofdiet: "+userinfo.Typeofdiet;
            goalField.Items.Add("lose weight");
            goalField.Items.Add("gain weight");
            goalField.Items.Add("maintain existing weight");
            typeofdietField.Items.Add("low - calorie diet");
            typeofdietField.Items.Add("low-carb diet");
            typeofdietField.Items.Add("balanced diet");
        }
        private async void Button_Edit(object sender, EventArgs e)
        {
            UserInfo.Goal = goalField.Items[goalField.SelectedIndex];

        }
        private async void Button_Edit1(object sender, EventArgs e)
        {
            UserInfo.Typeofdiet = typeofdietField.Items[typeofdietField.SelectedIndex];
        }
        void OnItemClicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;

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
