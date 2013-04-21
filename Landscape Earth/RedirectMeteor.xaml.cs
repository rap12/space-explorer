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
    public partial class RedirectMeteor : PhoneApplicationPage
    {
        public RedirectMeteor()
        {
            InitializeComponent();          
            Loaded += MainPage_Loaded;

        }

        private void MainPage_Loaded(object sender, RoutedEventArgs events)
        {
                SystemTray.IsVisible = false;
                NavigationService.Navigate(new Uri("/Small_Bodies.xaml", UriKind.Relative));
   
        }
        private void RedirectSolar()
        {
            NavigationService.Navigate(new Uri("/Small_Bodies.xaml", UriKind.Relative));
        }

        } 
}