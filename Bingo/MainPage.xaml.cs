using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Bingo.Resources;

namespace Bingo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            loadStackPanel();
        }

        public void loadStackPanel()
        {
            int x = Convert.ToInt32(slider.Value) * 10;
            StackPanel control = (StackPanel)FindName("stack0");
            for (int i = 1; i < x; i++)
            {

            }
            
            /*int x = Convert.ToInt32(slider.Value)*10;

            StackPanel control = (StackPanel)FindName("stack0");
            for (int i = 1; i < 11; i++)
            {
                TextBox numero = new TextBox();
                numero.Text = i.ToString();
                control.Children.Add(numero);
            }
            if(x>10)
            {
                for (int i = 1; i < Convert.ToInt32(slider.Value); i++)
                {
                    StackPanel control1 = (StackPanel)FindName("stack" + i.ToString());
                    for (int j = 11; j < x; j++)
                    {
                        TextBox numero = new TextBox();
                        numero.Text = i.ToString();
                    }
                }
            }*/


            
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}