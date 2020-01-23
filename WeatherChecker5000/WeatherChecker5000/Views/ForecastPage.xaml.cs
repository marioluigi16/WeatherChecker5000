using System;
using WeatherChecker5000.Models.Forecast;
using WeatherChecker5000.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherChecker5000.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForecastPage : ContentPage
    {
        readonly int cityID;
        objForecast obj;

        public ForecastPage(int cityID)
        {
            InitializeComponent();

            this.cityID = cityID;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            obj = await Managers.MgrHTTP.HTTPGet<objForecast>("forecast", cityID);
            BindingContext = new ForecastPageViewModel(cityID, obj);
        }
    }
}