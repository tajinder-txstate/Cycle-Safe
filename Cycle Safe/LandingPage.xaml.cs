using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Cycle_Safe
{
    public sealed partial class LandingPage : Page
    {
        public LandingPage()
        {

        }
        private void SearchBestRoute_onClick(System.Object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SearchPage));
        }

        private void ShowReports_onClick(System.Object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void ReportCrime_onClick(System.Object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }

}
