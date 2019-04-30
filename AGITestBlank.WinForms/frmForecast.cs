using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AGITestBlank.Models.Forecast;

namespace AGITestBlank.WinForms
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
            var obj = await Managers.mgrHTTP.HTTPGet<objForecast>("forecast", cityID.ToString());
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
