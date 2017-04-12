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
using System.Xml.Serialization;

namespace harjoitus.View
{
    /// <summary>
    /// Interaction logic for huone2.xaml
    /// </summary>
    public partial class huone2 : Window
    {
        Huone h2 = new Huone();
        Avain avain1 = new Avain { KeyNumber = 1, IsFound = false };
        Avain avain2 = new Avain { KeyNumber = 2, IsFound = false };
        Avain avain3 = new Avain { KeyNumber = 3, IsFound = false };
        Esine esine = new Esine();
        public int numero = 0;
        public huone2()
        {
            InitializeComponent();
            IniMyStuff();
            this.DataContext = new MainViewModel();
        }

        // adding to list keys
        private void IniMyStuff()
        {
            h2.HuoneNumero = 2;
            h2.Avaimet.Add(avain1);
            h2.Avaimet.Add(avain2);
            h2.Avaimet.Add(avain3);
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
            foreach (var a in h2.Avaimet)
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

            huone3 h = new harjoitus.View.huone3();
            this.Close();
            h.ShowDialog();

        }
        #endregion

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
        
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("huone.txt");
            outputFile.WriteLine(h2.HuoneNumero);
            outputFile.Close();
            Stream writeStream = new FileStream("Avaimet.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Avain>));
            //IFormatter formatter = new BinaryFormatter();
            serializer.Serialize(writeStream, h2.Avaimet);
            writeStream.Close();
            MainWindow huone = new harjoitus.View.MainWindow();
            this.Close();
            huone.ShowDialog();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow huone = new harjoitus.View.MainWindow();
            this.Close();
            huone.ShowDialog();
        }
    }
}