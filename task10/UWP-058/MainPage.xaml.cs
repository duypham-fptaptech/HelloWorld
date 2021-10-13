using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWP_058.models;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Devices.Geolocation;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_058
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //var position = await LocationManager.GetPosition();

            //Root myWeather = await OpenWeatherMapProxy.GetWeather(
            //    position.Coordinate.Latitude,
            //    position.Coordinate.Longitude);

            //string icon = String.Format("ms-appx:///Assets/weather/10d.png", myWeather.weather[0].icon);
            //ResultImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));
            //ResultTextblock.Text = myWeather.name + " - " + ((int)myWeather.main.temp).ToString() + " - " + myWeather.weather[0].description;
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var position = await LocationManager.GetPosition();

                var lat = position.Coordinate.Latitude;
                var lon = position.Coordinate.Longitude;

                Root myWeather =
                    await OpenWeatherMapProxy.GetWeather(lat, lon);

                string icon = String.Format("ms-appx:///Assets/weather/10d.png", myWeather.weather[0].icon);
                ResultImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                TempTextBlock.Text = ((int)myWeather.main.temp).ToString();
                DescriptionTextBlock.Text = myWeather.weather[0].description;
                TempTextBlock.Text = ((int)myWeather.main.temp).ToString();
                DescriptionTextBlock.Text = myWeather.weather[0].description;
            }
            catch
            {
               
                LocationTextBlock.Text = "Unable to get weather at this time";

            }


        }
    }
}
