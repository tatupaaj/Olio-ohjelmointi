using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using harjoitus.Model;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace harjoitus.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            //UusiPeli game = new harjoitus.View.UusiPeli();
            huone1 h = new harjoitus.View.huone1();
            this.Close();
            //game.ShowDialog();
            h.ShowDialog();

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLoadGame_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string text = System.IO.File.ReadAllText("huone.txt");
                int tmp = Convert.ToInt32(text);
                switch (tmp)
                {
                    case 1:
                        huone11 huone1 = new harjoitus.View.huone11();
                        this.Close();
                        huone1.ShowDialog();
                        break;
                    case 2:
                        huone22 huone2 = new harjoitus.View.huone22();
                        this.Close();
                        huone2.ShowDialog();
                        break;
                    case 3:
                        huone33 huone3 = new harjoitus.View.huone33();
                        this.Close();
                        huone3.ShowDialog();
                        break;
                    case 4:
                        huone44 huone4 = new harjoitus.View.huone44();
                        this.Close();
                        huone4.ShowDialog();
                        break;
                    case 5:
                        huone55 huone5 = new harjoitus.View.huone55();
                        this.Close();
                        huone5.ShowDialog();
                        break;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
