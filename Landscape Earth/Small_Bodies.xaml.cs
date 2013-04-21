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
    public partial class Small_Bodies : PhoneApplicationPage
    {
        public Small_Bodies()
        {
            InitializeComponent();
        }

        private void PresentTheAttributes(int planet)
        {

            Class1 lol1 = new Class1();
            string[,] MeteorVar = new string[8, 21];
            MeteorVar = lol1.Meteor();
            string[,] AttributeNameVar = new string[1, 21];
            AttributeNameVar = lol1.AttributeName4Meteor();

            switch (planet)
            {
                case 0: ForThemTheKids.Text = "Hyakutake";
                    break;
                case 1: ForThemTheKids.Text = "Swift-Tuttle";
                    break;
                case 2: ForThemTheKids.Text = "Halleys Comet";
                    break;
                case 3: ForThemTheKids.Text = "Shoemaker-Levy 9";
                    break; 
                default:
                    break;
            }
            //System.Diagnostics.Debug.WriteLine(AttributeName[0, 20]);
            //System.Diagnostics.Debug.WriteLine(AttributeName[0, 0]);
            AttributeName.Text = "";
            AttributeProperty.Text = "";
            for (int i = 0; i < 3; i++)
            {
                AttributeName.Text = AttributeName.Text + AttributeNameVar[0, i] + "\n";
                AttributeProperty.Text = AttributeProperty.Text + MeteorVar[planet, i] + "\n";
            }

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
                NavigationService.Navigate(new Uri("/RedirectMeteor.xaml", UriKind.Relative));
            }
        }

        private void image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i==1)
            {
                i = 2;
                Kutake.Begin();
                PresentTheAttributes(0);
                
            }
        }

        private void image1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i==1)
            {
                i = 2;
            Halleys.Begin();
            PresentTheAttributes(2);
            }

        }

        private void image3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
                i = 2;
            Swiftuttle.Begin();
            PresentTheAttributes(1);
            }
        }

        private void image2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
               i = 2;
            Shoemaker.Begin();
            PresentTheAttributes(3);
            }
        }





    }
}