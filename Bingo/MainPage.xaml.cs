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
            primeiro = true;
            loadStackPanel();
        }
        bool primeiro;
        int count = 0;
        StackPanel control;
        int[] numeros;
        public void loadStackPanel()
        {
            int x = Convert.ToInt16(slider.Value) * 10;
            control = new StackPanel();
            for (int i = 0; i < 100; i++)
            {
                control = (StackPanel)FindName("stack" + (i % 10).ToString());
                TextBlock numero = new TextBlock();
                numero.Name = i.ToString();
                numero.Opacity = 0;
                numero.Text = i.ToString();
                control.Children.Add(numero);
            }   
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(slider!=null)
                NBolas.Text = (Convert.ToInt16(slider.Value) * 10).ToString();
        }

        private void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            if(primeiro)
            {
                numeros = new int[int.Parse(NBolas.Text)];
                for (int i = 0; i < int.Parse(NBolas.Text); i++)
                {
                    numeros[i] = Convert.ToInt16(i);
                }
                primeiro = false;
                slider.IsEnabled = false;
            }
            count++;
            if (count != int.Parse(NBolas.Text) + 1)
            {
                int z = Random();
                Remover(z);
            }
            else { MessageBox.Show("Cabou, boy"); btnSortear.IsEnabled = false; }

        }

        private int Random()
        {
            Random r = new Random();
            int index = r.Next(0, numeros.Length);
            if (numeros[index] == 100) while (numeros[index] == 100) index = Random();
            return index; 
        }

        private void Remover(int y)
        {
            numeros[y] = 100;
            control = (StackPanel)FindName("stack" + (y % 10).ToString());
            foreach (FrameworkElement filhotes in control.Children) { 
                if (filhotes.Name == y.ToString()) filhotes.Opacity = 100;
            }

        }

        private void button_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            primeiro = true;
            count = 0;
            slider.IsEnabled = true;
            btnSortear.IsEnabled = true;
            stack0.Children.Clear();
            stack1.Children.Clear();
            stack2.Children.Clear();
            stack3.Children.Clear();
            stack4.Children.Clear();
            stack5.Children.Clear();
            stack6.Children.Clear();
            stack7.Children.Clear();
            stack8.Children.Clear();
            stack9.Children.Clear();
            //control = new StackPanel();
            for (int i = 0; i < 100; i++)
            {
                control = (StackPanel)FindName("stack" + (i % 10).ToString());
                TextBlock numero = new TextBlock();
                numero.Name = i.ToString();
                numero.Opacity = 0;
                numero.Text = i.ToString();
                control.Children.Add(numero);
            }
            //loadStackPanel();
        }
    }
}