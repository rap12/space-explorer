using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.ComponentModel;

namespace Landscape_Earth
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {

            InitializeComponent();
            Loaded += MainPage_Loaded;

        }

        protected override void OnBackKeyPress(CancelEventArgs e)
        {
            PhoneApplicationFrame RootFrame = Application.Current.RootVisual as PhoneApplicationFrame;

            if (RootFrame != null)
            {
                if (RootFrame.BackStack.Count() > 0)
                {
                    RootFrame.RemoveBackEntry();
                    RootFrame.RemoveBackEntry();
                }
            }

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