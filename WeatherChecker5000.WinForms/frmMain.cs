using WeatherChecker5000.Managers;
using WeatherChecker5000.Models.CityList;
using WeatherChecker5000.Models.CurrentWeather;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WeatherChecker5000.WinForms
{
    public partial class frmMain : Form
    {
        #region Constructor / Form Events

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            List<string> lstCountries = clsCityList.GetCountries();

            cboCountry.DataSource = lstCountries;
            cboCountry.SelectedItem = "US"; //default to America

            switch (mgrMeasurementUnits.g_MeasurementUnit)
            {
                case "F":
                    rdoUnitImp.Checked = true;
                    break;
                case "C":
                    rdoUnitMet.Checked = true;
                    break;
                case "K":
                    rdoUnitKel.Checked = true;
                    break;
            }
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl(ActiveControl, true, true, true, true);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Escape:
                    BtnExit_Click(sender, e);
                    break;
                case Keys.F12:
                    BtnSubmit_Click(sender, e);
                    break;
            }
        }

        #endregion

        #region Button Click Events

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateSubmitData())
                return;

            clsCity objCity = cboCity.SelectedItem as clsCity;

            OpenWeatherObj obj = await mgrHTTP.HTTPGet<OpenWeatherObj>("weather", objCity.id.ToString());

            DisplayWeather(obj);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void DisplayWeather(OpenWeatherObj obj)
        {
            lblCurrentTemp.Text = Math.Round(obj.main.temp) + "° " + mgrMeasurementUnits.g_MeasurementUnit;
            lblCurrentWeatherDescription.Text = obj.weather[0].description;
        }

        private void CboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<clsCity> lst = clsCityList.lstCity.Where(x => x.country == cboCountry.SelectedItem.ToString()).ToList();

            cboCity.DataSource = lst;
            cboCity.ValueMember = "name";
            cboCity.SelectedIndex = -1;
        }

        private bool ValidateSubmitData()
        {
            string errMsg = "";

            if (cboCity.SelectedItem == null)
            {
                if (cboCity.Text.Trim() != "")
                {
                    errMsg = "The entered city cannot be found! Please check your selection and try again.";
                }
                else
                {
                    errMsg = "Please enter a location first.";
                }

                MessageBox.Show(errMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        private void BtnDailyForecast_Click(object sender, EventArgs e)
        {
            if (!ValidateSubmitData())
                return;

            clsCity obj = cboCity.SelectedItem as clsCity;

            using (frmForecast frm = new frmForecast(obj.id))
            {
                frm.ShowDialog();
            }
        }

        private void RdoUnit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                mgrMeasurementUnits.g_MeasurementUnit = ((RadioButton)sender).Tag.ToString();
            }
            catch
            {
                mgrMeasurementUnits.g_MeasurementUnit = "F";
            }
        }
    }
}
