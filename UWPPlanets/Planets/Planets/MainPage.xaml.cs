using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Planets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            try
            {
                pvtPlanets.SelectedIndex = (int)localSettings.Values["currentPlanet"];
                tbxUserName.SelectedText = (string)localSettings.Values["username"];
               
            }
            catch
            {
                pvtPlanets.SelectedIndex = 2;
                tbxUserName.SelectedText = "";
            }

            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
        }

        private void pvtPlanets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            localSettings.Values["currentPlanet"] = pvtPlanets.SelectedIndex;
        }

        private void tbxUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            localSettings.Values["username"] = tbxUserName.Text;

        }


        //private void tbxUserName_TextChange(object sender, EventArgs e)
        //{
        //    ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

        //    localSettings.Values["username"] = tbxUserName.Text;
        //}

    }
}
