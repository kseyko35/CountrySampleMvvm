using System;
using System.Collections.Generic;
using System.Linq;
using CountrySampleMvvm.Mock;
using CountrySampleMvvm.Model;

namespace CountrySampleMvvm.ViewModel
{
    public class CountryViewModel : BaseViewModel
    {

        private Country selectedCountry;
        private City selectedCity;

        public IList<Country> Countries { get => CountryData.Countries; }


        public Country SelectedCountry
        {
            get => selectedCountry;
            set
            {
                selectedCountry = value;

                OnPropertyChanged();
                //CityNames = selectedCountry.cCity.Select(p => p.Name).ToList();


            }
        }

        public City SelectedCity
        {
            get => selectedCity;
            set
            {
                selectedCity = value;
                OnPropertyChanged();
            }
        }


    }
}
