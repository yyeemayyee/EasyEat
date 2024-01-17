using Easyeat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Easyeat
{
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }
        private async void Button_Registration(object sender, EventArgs e)
        {
            var u = new Domain.User();

            u.Login = loginField.Text.Trim();
            u.Password = passField.Text.Trim();
            u.Email = emailField.Text.Trim();
            App.DBContext.SaveUser(u);
        }
    }

}

