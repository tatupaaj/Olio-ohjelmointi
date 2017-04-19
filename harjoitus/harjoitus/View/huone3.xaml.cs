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
    public partial class huone3 : Window
    {
        Huone huone = new Huone();
        Avain avain1 = new Avain { KeyNumber = 1, IsFound = false };
        Avain avain2 = new Avain { KeyNumber = 2, IsFound = false };
        Avain avain3 = new Avain { KeyNumber = 3, IsFound = false };
        Esine tuoli1 = new Esine();
        Esine tuoli2 = new Esine();
        Esine tuoli3 = new Esine();
        Esine banana = new Esine();
        Esine lautanen1 = new Esine();
        Esine lautanen2 = new Esine();
        Esine lautanen3 = new Esine();
        Esine kuppi = new Esine();
        public int numero = 0;

        public huone3()
        {
            InitializeComponent();
            IniMyStuff();
            this.DataContext = new MainViewModel();
        }
        // adding to list keys
        private void IniMyStuff()
        {
            huone.HuoneNumero = 3;
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

            huone4 h = new harjoitus.View.huone4();
            this.Close();
            h.ShowDialog();

        }
        #endregion

        #region furniture's work
        private void OnChair1Click(object sender, RoutedEventArgs e)
        {
            tuoli1.MoveDownLeft(chair1, 30, 30);
        }
        private void OnChair2Click(object sender, RoutedEventArgs e)
        {
            tuoli2.MoveLeft(chair2, 50);
        }
        private void OnChair3Click(object sender, RoutedEventArgs e)
        {
            tuoli3.MoveLeft(chair3, 100);
            avain1.MoveLeft(key1, 100);
        }
        private void OnBananClick(object sender, RoutedEventArgs e)
        {
            banana.MoveDown(banan, 50);
        }
        private void OnGlassClick(object sender, RoutedEventArgs e)
        {
            kuppi.MoveDownLeft(glass, 20, 20);
        }
        private void OnPlate1Click(object sender, RoutedEventArgs e)
        {
            lautanen1.MoveDownRight(plate1, 20, 10);
        }
        private void OnPlate2Click(object sender, RoutedEventArgs e)
        {
            lautanen2.MoveUpLeft(plate2, 20, 10);
        }
        private void OnPlate3Click(object sender, RoutedEventArgs e)
        {
            lautanen3.MoveUp(plate3, 10);
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
            if (tuoli3.IsMoved == false)
            {
                tuoli3.MoveLeft(chair3, 100);
                avain1.MoveLeft(key1, 100);
            }
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
            if (lautanen1.IsMoved == false)
                lautanen1.MoveDownRight(plate1, 20, 10);
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
            if (banana.IsMoved == false)
                banana.MoveDown(banan, 50);
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