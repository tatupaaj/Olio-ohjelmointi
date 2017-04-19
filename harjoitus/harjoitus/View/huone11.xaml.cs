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
        Huone huone = new Huone();
        Avain avain1 = new Avain { KeyNumber = 1, IsFound = false };
        Avain avain2 = new Avain { KeyNumber = 2, IsFound = false };
        Avain avain3 = new Avain { KeyNumber = 3, IsFound = false };
        Esine lehti = new Esine();
        Esine tuoli = new Esine();
        Esine kirjat1 = new Esine();
        Esine kirjat2 = new Esine();
        Esine kirja1 = new Esine();
        Esine kirja2 = new Esine();
        Esine kirja3 = new Esine();
        Esine kirja4 = new Esine();
        Esine kirja5 = new Esine();
        Esine kirja6 = new Esine();
        Esine kirja7 = new Esine();
        Esine kirja8 = new Esine();
        Esine kirja9 = new Esine();
        Esine kirja10 = new Esine();
        public int numero = 0;

        public huone11()
        {
            InitializeComponent();
            IniMyStuff();
            this.DataContext = new MainViewModel();
        }

        // Loading keys to list
        private void IniMyStuff()
        {
            try
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
                foreach (Avain a in readAvaimet)
                {
                    avain[n] = a;
                    if (a.IsFound == true)
                        numero++;
                    n++;
                }
                avain1 = avain[0];
                avain2 = avain[1];
                avain3 = avain[2];
                huone.HuoneNumero = 1;
                huone.Avaimet.Add(avain1);
                huone.Avaimet.Add(avain2);
                huone.Avaimet.Add(avain3);
                //hiding already found keys
                if (avain1.IsFound == true)
                    avain1.Disappearing(key1, avain1);
                if (avain2.IsFound == true)
                    avain2.Disappearing(key2, avain2);
                if (avain3.IsFound == true)
                    avain3.Disappearing(key3, avain3);
                MenuAvaimetSave();
                ViestinToiminta();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }

        // Loading menu keys
        private void MenuAvaimetSave()
        {
            switch (numero)
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
        private void ViestinToiminta()
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
            ViestinToiminta();
        }
        private void OnButton2Click(object sender, RoutedEventArgs e)
        {
            avain2.Disappearing(key2, avain2);

            numero++;
            MenuAvaimet();
            ViestinToiminta();
        }
        private void OnButton3Click(object sender, RoutedEventArgs e)
        {
            avain3.Disappearing(key3, avain3);
            numero++;
            MenuAvaimet();
            ViestinToiminta();
        }
        #endregion

        #region door's work
        private void OnDoor1Click(object sender, RoutedEventArgs e)
        {
            huone.DoorWork(numero, message, door1, door2);
        }

        private void OnDoor2Click(object sender, RoutedEventArgs e)
        {

            huone2 h = new harjoitus.View.huone2();
            this.Close();
            h.ShowDialog();

        }
        #endregion

        #region furniture's work
        private void OnNewspaperClick(object sender, RoutedEventArgs e)
        {
            lehti.MoveRight(newspaper, 70);
        }
        private void OnChairClick(object sender, RoutedEventArgs e)
        {
            tuoli.MoveLeft(chair, 100);
        }
        private void OnBooks1Click(object sender, RoutedEventArgs e)
        {
            kirjat1.MoveDown(books1, 70);
        }
        private void OnBooks2Click(object sender, RoutedEventArgs e)
        {
            kirjat2.MoveRight(books2, 50);
        }
        private void OnBook1Click(object sender, RoutedEventArgs e)
        {
            kirja1.MoveDown(book1, 50);
        }
        private void OnBook2Click(object sender, RoutedEventArgs e)
        {
            kirja2.MoveDown(book2, 50);
        }
        private void OnBook3Click(object sender, RoutedEventArgs e)
        {
            kirja3.MoveDown(book3, 50);
        }
        private void OnBook4Click(object sender, RoutedEventArgs e)
        {
            kirja4.MoveDown(book4, 50);
        }
        private void OnBook5Click(object sender, RoutedEventArgs e)
        {
            kirja5.MoveDown(book5, 50);
        }
        private void OnBook6Click(object sender, RoutedEventArgs e)
        {
            kirja6.MoveDown(book6, 50);
        }
        private void OnBook7Click(object sender, RoutedEventArgs e)
        {
            kirja7.MoveDown(book7, 50);
        }
        private void OnBook8Click(object sender, RoutedEventArgs e)
        {
            kirja8.MoveUp(book8, 50);
        }
        private void OnBook9Click(object sender, RoutedEventArgs e)
        {
            kirja9.MoveUp(book9, 50);
        }
        private void OnBook10Click(object sender, RoutedEventArgs e)
        {
            kirja10.MoveUp(book10, 50);
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
            if (lehti.IsMoved == false)
                lehti.MoveRight(newspaper, 70);
            else
            {
                avain1.Disappearing(key1, avain1);
                numero++;
                MenuAvaimet();
                ViestinToiminta();
            }
        }
        private void OnHint2Click(object sender, RoutedEventArgs e)
        {
            avain2.HintDisappear(hint2, avain2);
            if (kirjat1.IsMoved == false)
                kirjat1.MoveDown(books1, 70);
            else
            {
                avain2.Disappearing(key2, avain2);
                numero++;
                MenuAvaimet();
                ViestinToiminta();
            }
        }
        private void OnHint3Click(object sender, RoutedEventArgs e)
        {
            avain3.HintDisappear(hint3, avain3);
            if (kirja2.IsMoved == false)
            {
                kirja2.MoveDown(book2, 50);
                if (kirja3.IsMoved == false)
                    kirja3.MoveDown(book3, 50);
                if (kirja4.IsMoved == false)
                    kirja4.MoveDown(book4, 50);
            }
            else
            {
                avain3.Disappearing(key3, avain3);
                numero++;
                MenuAvaimet();
                ViestinToiminta();
            }
        }
        #endregion
    }
}
