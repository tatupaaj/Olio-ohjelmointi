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
    /// Interaction logic for huone5.xaml
    /// </summary>
    public partial class huone5 : Window
    {
        Huone huone = new Huone();
        Avain avain1 = new Avain { KeyNumber = 1, IsFound = false };
        Avain avain2 = new Avain { KeyNumber = 2, IsFound = false };
        Avain avain3 = new Avain { KeyNumber = 3, IsFound = false };
        Esine tyyny1 = new Esine();
        Esine tyyny2 = new Esine();
        Esine tuoli = new Esine();
        Esine lappari = new Esine();
        public int numero = 0;

        public huone5()
        {
            InitializeComponent();
            IniMyStuff();
            this.DataContext = new MainViewModel();
        }
        // adding to list keys
        private void IniMyStuff()
        {
            huone.HuoneNumero = 5;
            huone.Avaimet.Add(avain1);
            huone.Avaimet.Add(avain2);
            huone.Avaimet.Add(avain3);
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

        // Message's work
        private void MessageWork()
        {
            switch (numero)
            {
                case 1:
                    message.Text = "Still 2 keys to go!";
                    break;
                case 2:
                    message.Text = "Only 1 key to go!";
                    break;
                case 3:
                    message.Text = "All keys are found! You can get out of the room!";
                    break;
            }
        }

        #region Key's work
        private void OnButton1Click(object sender, RoutedEventArgs e)
        {
            avain1.Disappearing(key1, avain1);
            numero++;
            MenuAvaimet();
            MessageWork();
        }
        private void OnButton2Click(object sender, RoutedEventArgs e)
        {
            avain2.Disappearing(key2, avain2);

            numero++;
            MenuAvaimet();
            MessageWork();
        }
        private void OnButton3Click(object sender, RoutedEventArgs e)
        {
            avain3.Disappearing(key3, avain3);
            numero++;
            MenuAvaimet();
            MessageWork();
        }
        #endregion

        #region door's work
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

            huone1 h = new harjoitus.View.huone1();
            this.Close();
            h.ShowDialog();

        }
        #endregion

        #region furniture's work
        private void OnPillow1Click(object sender, RoutedEventArgs e)
        {
            tyyny1.MoveDownLeft(pillow1, 50, 50);
        }
        private void OnPillow2Click(object sender, RoutedEventArgs e)
        {
            tyyny2.MoveDownLeft(pillow2, 50, 50);
        }
        private void OnChairClick(object sender, RoutedEventArgs e)
        {
            tuoli.MoveUp(chair, 50);
        }
        private void OnLaptopClick(object sender, RoutedEventArgs e)
        {
            lappari.MoveRight(laptop, 80);
        }
        private void OnPainting1Click(object sender, RoutedEventArgs e)
        {
            painting1.Visibility = Visibility.Hidden;
            painting2.Visibility = Visibility.Visible;
        }
        private void OnPainting2Click(object sender, RoutedEventArgs e)
        {
            painting2.Visibility = Visibility.Hidden;
            painting1.Visibility = Visibility.Visible;
        }
        #endregion

        #region menu button's work

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow huone = new harjoitus.View.MainWindow();
            this.Close();
            huone.ShowDialog();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter outputFile = new System.IO.StreamWriter("huone.txt");
                outputFile.WriteLine(huone.HuoneNumero);
                outputFile.Close();
                Stream writeStream = new FileStream("Avaimet.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Avain>));
                serializer.Serialize(writeStream, huone.Avaimet);
                writeStream.Close();
                MainWindow h = new harjoitus.View.MainWindow();
                this.Close();
                h.ShowDialog();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Can't open file for writing (UnauthorizedAccessException)");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Opened stream is null (ArgumentNullException)");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Opened stream is not writable (ArgumentException)");
            }
            catch (IOException)
            {
                Console.WriteLine("An IO error happend (IOException)");
            }
            catch (Exception)
            {
                Console.WriteLine("Some other exception happend (Exception)");
            }
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            if (avain1.IsFound == false)
            {
                if (avain1.IsHint == false)
                    avain1.HintAppear(hint1, avain1);
                else
                {
                    avain1.HintAppear(hint1, avain1);
                    message.Text = "You can't see next hint until you take this one!";
                }
            }
            else if (avain2.IsFound == false)
            {
                if (avain2.IsHint == false)
                    avain2.HintAppear(hint2, avain2);
                else
                {
                    avain2.HintAppear(hint2, avain2);
                    message.Text = "You can't see next hint until you take this one!";
                }
            }
            else if (avain3.IsFound == false)
            {
                if (avain3.IsHint == false)
                    avain3.HintAppear(hint3, avain3);
                else
                {
                    avain3.HintAppear(hint3, avain3);
                    message.Text = "You can't see next hint until you take this one!";
                }
            }
        }
        #endregion

        #region hint's work
        private void OnHint1Click(object sender, RoutedEventArgs e)
        {
            avain1.HintDisappear(hint1, avain1);
            if (tyyny1.IsMoved == false)
                tyyny1.MoveDownLeft(pillow1, 50, 50);
        }
        private void OnHint2Click(object sender, RoutedEventArgs e)
        {
            avain2.HintDisappear(hint2, avain2);
                painting1.Visibility = Visibility.Hidden;
                painting2.Visibility = Visibility.Visible;
        }
        private void OnHint3Click(object sender, RoutedEventArgs e)
        {
            avain3.HintDisappear(hint3, avain3);
            if (lappari.IsMoved == false)
                lappari.MoveRight(laptop, 80);
        }
        #endregion
    }
}
