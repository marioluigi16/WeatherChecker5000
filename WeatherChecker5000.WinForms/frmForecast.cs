using System.Windows.Forms;
using WeatherChecker5000.Models.Forecast;

namespace WeatherChecker5000.WinForms
{
    public partial class frmForecast : Form
    {
        private int cityID;

        public frmForecast(int cityID)
        {
            InitializeComponent();

            this.cityID = cityID;
            GetForecast();
        }

        private async void GetForecast()
        {
            var obj = await Managers.MgrHTTP.HTTPGet<objForecast>("forecast", cityID.ToString());
            PopulateForm(obj);
        }

        private void PopulateForm(objForecast obj)
        {
            label1.Text = obj.list[0].main.temp.ToString();

            foreach(Forecast f in obj.list)
            {
                frmForecastBox ffb = GenerateBox(f);

                flpForecast.Controls.Add(ffb);
                ffb.Show();
            }
        }

        private frmForecastBox GenerateBox(Forecast obj)
        {
            frmForecastBox frm = new frmForecastBox(obj);

            return frm;
        }
    }
}
