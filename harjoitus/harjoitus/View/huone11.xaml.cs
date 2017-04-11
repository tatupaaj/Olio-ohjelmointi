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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace harjoitus.View
{
    /// <summary>
    /// Interaction logic for huone1.xaml
    /// </summary>
    public partial class huone11 : Window
    {
        Huone h1 = new Huone();
        Avain avain1 = new Avain { KeyNumber = 1, IsFound = false };
        Avain avain2 = new Avain { KeyNumber = 2, IsFound = false };
        Avain avain3 = new Avain { KeyNumber = 3, IsFound = false };
        Esine esine = new Esine();
        public int numero = 0;
        public huone11()
        {
            InitializeComponent();
            IniMyStuff();
            this.DataContext = new MainViewModel();
        }
        // adding to list keys
        private void IniMyStuff()
        {
            Avain[] avain = new Avain[3];
            for (int i = 0; i < 3; i++)
            {
                avain[i] = new Avain();
            }
            List<Avain> readAvaimet = new List<Avain>();
            Stream openStream = new FileStream("Avaimet.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Avain>));
            readAvaimet = serializer.Deserialize(openStream) as List<Avain>;
            openStream.Close();
            int n = 0;
            int foundKeys = 0;
            foreach (Avain a in readAvaimet)
            {
                avain[n] = a;
                if (a.IsFound == true)
                    foundKeys++;
                n++; 
            }
            avain1 = avain[0];
            avain2 = avain[1];
            avain3 = avain[2];
            h1.HuoneNumero = 1;
            h1.Avaimet.Add(avain1);
            h1.Avaimet.Add(avain2);
            h1.Avaimet.Add(avain3);
            //hiding already found keys
            if (avain1.IsFound == true)
                avain1.Disappearing(key1, avain1);
            if (avain2.IsFound == true)
                avain2.Disappearing(key2, avain2);
            if (avain3.IsFound == true)
                avain3.Disappearing(key3, avain3);
            MenuAvaimetSave(foundKeys);
        }

        #region Key's work
        private void OnButton1Click(object sender, RoutedEventArgs e)
        {
            avain1.Disappearing(key1, avain1);
            numero++;
            MenuAvaimet();
        }
        private void OnButton2Click(object sender, RoutedEventArgs e)
        {
            avain2.Disappearing(key2, avain2);

            numero++;
            MenuAvaimet();
        }
        private void OnButton3Click(object sender, RoutedEventArgs e)
        {
            avain3.Disappearing(key3, avain3);
            numero++;
            MenuAvaimet();
        }
        #endregion

        #region door's work
        private void OnDoor1Click(object sender, RoutedEventArgs e)
        {
            foreach (var a in h1.Avaimet)
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
        #endregion

        #region furniture's work
        private void OnNewspaper(object sender, RoutedEventArgs e)
        {
            esine.MoveRight(newspaper, 100);
        }
        #endregion
        #region Menu key's work
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

        private void MenuAvaimetSave(int n)
        {
            switch (n)
            {
                case 1:
                    menuKey1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    menuKey1.Visibility = Visibility.Visible;
                    menuKey2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    menuKey1.Visibility = Visibility.Visible;
                    menuKey2.Visibility = Visibility.Visible;
                    menuKey3.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        #endregion

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("huone.txt");
            outputFile.WriteLine(h1.HuoneNumero);
            outputFile.Close();
            Stream writeMultipleStream = new FileStream("Avaimet.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeMultipleStream, h1.Avaimet);
            writeMultipleStream.Close();
            MainWindow huone = new harjoitus.View.MainWindow();
            this.Close();
            huone.ShowDialog();
        }
    }
}
