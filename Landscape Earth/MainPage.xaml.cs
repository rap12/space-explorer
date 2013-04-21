using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Landscape_Earth
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {

            InitializeComponent();
            Loaded += MainPage_Loaded;

        }

        private void MainPage_Loaded(object sender, RoutedEventArgs events)
        {
                SystemTray.IsVisible = false;
             }
        private void Rectangle_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
			
			
			// TODO: Add event handler implementation here.
        }

        private void Rectangle_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TriviaPage.xaml", UriKind.Relative));
        }

        private void Rectangle_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AboutUs.xaml", UriKind.Relative)); 
        }
    }
}