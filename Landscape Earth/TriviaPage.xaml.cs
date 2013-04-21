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
    public partial class TriviaPage : PhoneApplicationPage
    {
        public TriviaPage()
        {
            InitializeComponent();
        }
         
        int i = 1;
        protected override void OnBackKeyPress(CancelEventArgs e)
        {
            e.Cancel = false;
            if (i == 1)
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

            }
            else if (i == 2)
            {
                NavigationService.Navigate(new Uri("/RedirectTrivia.xaml", UriKind.Relative));
            }
        }

        private void PresentTheAttributes(int planet)
        {

            Class1 lol1 = new Class1();
            string[,] SolarSystemVar = new string[8, 4];
            SolarSystemVar = lol1.TriviaThing();
            string[,] AttributeNameVar = new string[1, 4];
            AttributeNameVar = lol1.AttributeName4Trivia();


            Landform.Text = SolarSystemVar[planet, 0];
            switch (planet)
            {
                case 0:  
                   PropertyB.Text = ""; 
                   for (int i = 1; i < 4; i++)
                    { 
                        PropertyB.Text = PropertyB.Text + SolarSystemVar[planet, i] + "\n";
                        if (i == 2)
                        {
                            PropertyB.Text = PropertyB.Text + "\n";
                        }
                     } 
                    break;
                case 1:  
                    PropertyA.Text = "";
                    for (int i = 1; i < 4; i++)
                    { 
                        PropertyA.Text = PropertyA.Text + SolarSystemVar[planet, i] + "\n";
                        if (i == 2)
                        {
                            PropertyB.Text = PropertyB.Text + "\n";
                        }
                    } 
                    break;
                case 2:  
                    PropertyB.Text = "";
                    for (int i = 1; i < 4; i++)
                    { 
                        PropertyB.Text = PropertyB.Text + SolarSystemVar[planet, i] + "\n";
                        if (i == 2)
                        {
                            PropertyB.Text = PropertyB.Text + "\n";
                        }
                    } 
                    break;
                case 3:  
                    PropertyB.Text = "";
                    for (int i = 1; i < 4; i++)
                    { 
                        PropertyB.Text = PropertyB.Text + SolarSystemVar[planet, i] + "\n";
                        if (i == 2)
                        {
                            PropertyB.Text = PropertyB.Text + "\n";
                        }
                    } 
                    break;
                case 4:  
                    PropertyA.Text = "";
                    for (int i = 1; i < 4; i++)
                    { 
                        PropertyA.Text = PropertyA.Text + SolarSystemVar[planet, i] + "\n";
                        if (i == 2)
                        {
                            PropertyB.Text = PropertyB.Text + "\n";
                        }
                    } 
                    break;
                case 5:  
                    PropertyA.Text = "";
                    for (int i = 1; i < 4; i++)
                    { 
                        PropertyA.Text = PropertyA.Text + SolarSystemVar[planet, i] + "\n";
                    } 
                    break;
                case 6: 
                    PropertyA.Text = "";
                    for (int i = 1; i < 4; i++)
                    { 
                        PropertyA.Text = PropertyA.Text + SolarSystemVar[planet, i] + "\n";
                    } 
                    break;
                case 7: 
                    PropertyB.Text = "";
                    for (int i = 1; i < 4; i++)
                    { 
                        PropertyB.Text = PropertyB.Text + SolarSystemVar[planet, i] + "\n";
                    } 
                    break;
                default:
                    break;
            }
            //System.Diagnostics.Debug.WriteLine(AttributeName[0, 20]);
            //System.Diagnostics.Debug.WriteLine(AttributeName[0, 0]);
           

        }



        private void Volcano_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
          if (i == 1)
          {
             i = 2;
             Volcano1.Begin();

             PresentTheAttributes(1);
             PresentTheAttributes(0);
           } 
        }

        private void Highest_Peak_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
                i = 2;
                HigestPeak1.Begin();
                PresentTheAttributes(2);
                PresentTheAttributes(3);
            } 
		}

        private void Deepest_Ocean_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
                i = 2;
                DepeestOcean.Begin();
                PresentTheAttributes(4);
                PresentTheAttributes(5);
            } 
		}

        private void Canyon_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (i == 1)
            {
             
            i = 2;
            Canyon1.Begin();

            PresentTheAttributes(6);
            PresentTheAttributes(7);
            }
        }

        private void Volcano1_Completed(object sender, EventArgs e)
        {

        }

        private void HigestPeak1_Completed(object sender, EventArgs e)
        {

        }

        private void DepeestOcean_Completed(object sender, EventArgs e)
        {

        }

        private void Canyon1_Completed(object sender, EventArgs e)
        {

        }
    }
}