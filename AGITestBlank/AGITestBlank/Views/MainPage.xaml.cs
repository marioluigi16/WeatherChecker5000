using AGITestBlank.Managers;
using AGITestBlank.Models.CityList;
using AGITestBlank.Models.CurrentWeather;
using AGITestBlank.ViewModels;
using AGITestBlank.Views;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace AGITestBlank
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            clsCity objCity = pkrCity.SelectedItem as clsCity;

            OpenWeatherObj obj = await mgrHTTP.HTTPGet<OpenWeatherObj>("weather", objCity.id.ToString());
            DisplayWeather(obj);
        }

        private void DisplayWeather(OpenWeatherObj obj)
        {
            lblCurrentTemp.Text = Math.Round(obj.main.temp) + "° " + mgrMeasurementUnits.g_MeasurementUnit;
            lblCurrentWeatherDescription.Text = obj.weather[0].description;
        }

        private void CountryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            pkrCity.SetBinding(Picker.ItemsSourceProperty, "lstCities");
            pkrCity.ItemDisplayBinding = new Binding("name");
        }

        private void btnForecast_Clicked(object sender, EventArgs e)
        {
            try
            {
                clsCity objCity = pkrCity.SelectedItem as clsCity;

                Navigation.PushModalAsync(new ForecastPage(objCity.id));
            }
            catch(NullReferenceException)
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
