using AGITestBlank.Models.Forecast;
using AGITestBlank.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AGITestBlank.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForecastPage : ContentPage
    {
        int cityID;
        objForecast obj;

        public ForecastPage(int cityID)
        {
            InitializeComponent();

            this.cityID = cityID;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            obj = await Managers.mgrHTTP.HTTPGet<objForecast>("forecast", cityID);
            BindingContext = new ForecastPageViewModel(cityID, obj);
        }
    }
}