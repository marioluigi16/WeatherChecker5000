using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeatherChecker5000.Models.Forecast;

namespace WeatherChecker5000.WinFormsCore
{
    public partial class frmForecastBox : Form
    {
        Forecast obj;

        public frmForecastBox(Forecast obj)
        {
            InitializeComponent();

            TopLevel = false;


            this.obj = obj;
        }

        private void FrmForecastBox_Load(object sender, EventArgs e)
        {
            lblDataTemp.Text = obj.main.temp.ToString();
            lblDay.Text = obj.dt_cs.ToString();
            lblWeatherDescription.Text = obj.weather_desc;

            lblWindSpeed.Text = obj.wind.speed_txt;

            if (obj.rain != null)
                lblRainAmt.Text = obj.rain.amt3h.ToString();

            if (obj.snow != null)
                lblSnowAmt.Text = obj.snow.amt3h.ToString();
        }
    }
}
