using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using harjoitus.ViewModel;
using harjoitus.Model;

namespace harjoitus.View
{
    /// <summary>
    /// Interaction logic for huone1.xaml
    /// </summary>
    public partial class huone1 : Window
    {
        Huone huone = new Huone();
        Avain avain1 = new Avain(1, false);
        Avain avain2 = new Avain(2, false);
        Avain avain3 = new Avain(3, false);
        public int numero = 0;
        public huone1()
        {
            InitializeComponent();
            IniMyStuff();
            this.DataContext = new MainViewModel();    
        }
        // adding to list keys
        private void IniMyStuff()
        {
            huone.Avaimet.Add(avain1);
            huone.Avaimet.Add(avain2);
            huone.Avaimet.Add(avain3);
        }
        // Key's work
        private void OnButton1Click(object sender, RoutedEventArgs e)
        {
            avain1.Disappearing(key1);
            avain1.IsFound = true;
            numero++;
            MenuAvaimet();
        }
        private void OnButton2Click(object sender, RoutedEventArgs e)
        {
            avain2.Disappearing(key2);
            avain2.IsFound = true;
            numero++;
            MenuAvaimet();
        }
        private void OnButton3Click(object sender, RoutedEventArgs e)
        {
            avain3.Disappearing(key3);
            avain3.IsFound = true;
            numero++;
            MenuAvaimet();
        }

        // door's work
        private void OnDoor1Click(object sender, RoutedEventArgs e)
        {
            foreach (var a in huone.Avaimet)
            {
                if (a.IsFound == false)
                {
                    message.Text = "Not enough keys!";
                    break;
                }
                else
                {
                    door1.Visibility = Visibility.Hidden;
                    door2.Visibility = Visibility.Visible;
                }
            }
        }

        private void OnDoor2Click(object sender, RoutedEventArgs e)
        {
            
            huone2 h = new harjoitus.View.huone2();
            this.Close();
            h.ShowDialog();

        }

        // Menu key's work
        private void MenuAvaimet()
        {
            switch (numero)
            {
                case 1:
                    menuKey1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    menuKey2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    menuKey3.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }
    }
}
