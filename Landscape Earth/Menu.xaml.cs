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
    public partial class Menu : PhoneApplicationPage
    {
        public Menu()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;

        }

        private void MainPage_Loaded(object sender, RoutedEventArgs events)
        {
            SystemTray.IsVisible = false;
        }

        private void Ellipse_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
			SolarSystemYehey.Begin();
		}

        private void Ellipse_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            SmallBodies.Begin();
        }

        private void Ellipse_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            TheUniverse.Begin();
        }

        private void SolarSystemYehey_Completed(object sender, EventArgs e)
        { 
            NavigationService.Navigate(new Uri("/Solar_System.xaml", UriKind.Relative)); 
        }

        private void SmallBodies_Completed(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Small_Bodies.xaml", UriKind.Relative));  
        }

        private void TheUniverse_Completed(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/TheUniverse.xaml", UriKind.Relative));  
        }
    }
}