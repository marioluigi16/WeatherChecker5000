using System;
using WeatherChecker5000.Views.MainPage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherChecker5000
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Device.Idiom == TargetIdiom.Phone)
                MainPage = new MainPage();
            else
                MainPage = new MainPageTablet();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
