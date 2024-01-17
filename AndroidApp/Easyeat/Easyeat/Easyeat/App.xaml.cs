using Easyeat.Domain;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Easyeat
{
    public partial class App : Application
    {
        private static DBContext dBContext;
        public static DBContext DBContext
        {
            get
            {
                if (dBContext == null)
                    dBContext = new DBContext(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "db.sqlite3"));
                return dBContext;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }

    internal class FirstContentPage : Page
    {
    }
}
