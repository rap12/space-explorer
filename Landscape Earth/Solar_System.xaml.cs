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
    public partial class Solar_System : PhoneApplicationPage
    {
        public Solar_System()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
            BigBan.Begin();
        }
        private void MainPage_Loaded(object sender, RoutedEventArgs events)
        {
            SystemTray.IsVisible = false;
        }
        int i = 1;
        protected override void OnBackKeyPress(CancelEventArgs e)
        {
            e.Cancel = false;
            if (i == 1)
            { 
                NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));

            }
            else if (i == 2)
            { 
                NavigationService.Navigate(new Uri("/Redirect.xaml", UriKind.Relative));
            }
        }

        private void PresentTheAttributes(int planet)
        {

            Class1 lol1 = new Class1();
            string[,] SolarSystemVar = new string[8, 21];
            SolarSystemVar = lol1.SolarSystemPlanets();
            string[,] AttributeNameVar = new string[1, 21];
            AttributeNameVar = lol1.AttributeName4Planets();

            switch (planet)
            {
                case 0: ForThemTheKids.Text = "Mercury";
                    break;
                case 1: ForThemTheKids.Text = "Venus";
                    break;
                case 2: ForThemTheKids.Text = "Earth";
                    break;
                case 3: ForThemTheKids.Text = "Mars";
                    break;
                case 4: ForThemTheKids.Text = "Jupiter";
                    break;
                case 5: ForThemTheKids.Text = "Saturn";
                    break;
                case 6: ForThemTheKids.Text = "Uranus";
                    break;
                case 7: ForThemTheKids.Text = "Neptune";
                    break;
                default:
                    break;
            }
            //System.Diagnostics.Debug.WriteLine(AttributeName[0, 20]);
            //System.Diagnostics.Debug.WriteLine(AttributeName[0, 0]);
            AttributeName.Text = "";
            AttributeProperty.Text = "";
             for (int i = 0; i < 21; i++)
			{
                AttributeName.Text = AttributeName.Text + AttributeNameVar[0, i] + "\n";
                AttributeProperty.Text = AttributeProperty.Text + SolarSystemVar[planet, i] + "\n";
			}
             
        }


        private void image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
                Mercury.Begin();
                i = 2;
                PresentTheAttributes(0);
            }
        }

        private void image1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
                Venus.Begin();
                i = 2;
                PresentTheAttributes(1);
            }
        }


        private void image2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
                Earth.Begin();
                i = 2;
                PresentTheAttributes(2);
            }
        }

        private void image3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
                Mars.Begin();
                i = 2;
                PresentTheAttributes(3);
            }
        }

        private void image4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
                Jupiter.Begin();
                i = 2;
                PresentTheAttributes(4);
            }
        }

        private void image5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
                Saturn.Begin();
                i = 2;
                PresentTheAttributes(5);
            }
        }

        private void image6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
                Uranus.Begin();
                i = 2;
                PresentTheAttributes(6);
            }
        }

        private void image7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
                Neptune.Begin();
                i = 2;
                PresentTheAttributes(7);
            }
        }
         
 
    }
}