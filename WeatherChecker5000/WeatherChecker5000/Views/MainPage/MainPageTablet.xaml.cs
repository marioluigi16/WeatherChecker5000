using System;
using WeatherChecker5000.Managers;
using WeatherChecker5000.Models.CityList;
using WeatherChecker5000.Models.CurrentWeather;
using WeatherChecker5000.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherChecker5000.Views.MainPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageTablet : ContentPage
    {
        public MainPageTablet()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            clsCity objCity = pkrCity.SelectedItem as clsCity;

            OpenWeatherObj obj = await MgrHTTP.HTTPGet<OpenWeatherObj>("weather", objCity.id.ToString());
            DisplayWeather(obj);
        }

        private void DisplayWeather(OpenWeatherObj obj)
        {
            lblCurrentTemp.Text = Math.Round(obj.main.temp) + "° " + mgrMeasurementUnits.g_MeasurementUnit;
            lblCurrentWeatherDescription.Text = obj.weather[0].description;
        }

        private void CountryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            pkrCity.SetBinding(Picker.ItemsSourceProperty, "LstCities");
            pkrCity.ItemDisplayBinding = new Binding("name");
        }

        private void btnForecast_Clicked(object sender, EventArgs e)
        {
            try
            {
                clsCity objCity = pkrCity.SelectedItem as clsCity;

                Navigation.PushModalAsync(new ForecastPage(objCity.id));
            }
            catch (NullReferenceException)
            {
                DisplayAlert("Error", "Please select a city first!", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.GetType().Name, "OK");
            }
        }
    }
}