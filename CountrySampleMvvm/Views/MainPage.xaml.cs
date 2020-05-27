using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountrySampleMvvm.ViewModel;
using Xamarin.Forms;

namespace CountrySampleMvvm
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new CountryViewModel();
            mCityPicker.IsVisible = false;
        }

        void Picker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            mCityPicker.IsVisible = true;


        }

    }
}
