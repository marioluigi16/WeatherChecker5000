﻿using WeatherChecker5000.Models.CityList;
using System.Collections.Generic;
using System.Linq;

namespace WeatherChecker5000.ViewModels
{
    class MainPageViewModel : ViewModelBase
    {
        private const string DEFAULT_COUNTRY = "US";

        public List<string> LstCountries { get; } = clsCityList.GetCountries();

        string selectedCountry = DEFAULT_COUNTRY;
        public string SelectedCountry
        {
            get { return selectedCountry; }
            set
            {
                if (selectedCountry != value)
                {
                    selectedCountry = value;
                    _lstCities = clsCityList.lstCity.Where(x => x.country == selectedCountry).ToList();
                    OnPropertyChanged();
                }
            }
        }


        private List<clsCity> _lstCities;
        public List<clsCity> LstCities
        {
            get
            {
                if(_lstCities == null)
                    _lstCities = clsCityList.lstCity.Where(x => x.country == DEFAULT_COUNTRY).ToList();

                return _lstCities;
            }
        } 

        string selectedCity;
        public string SelectedCity
        {
            get { return selectedCity; }
            set
            {
                if (selectedCity != value)
                {
                    selectedCity = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
