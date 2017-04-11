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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace harjoitus.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Huone h = new Huone();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            UusiPeli game = new harjoitus.View.UusiPeli();
            this.Close();
            game.ShowDialog();

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLoadGame_Click(object sender, RoutedEventArgs e)
        {

            string text = System.IO.File.ReadAllText("huone.txt");
            int tmp = Convert.ToInt32(text);
            if (tmp == 1)
            {
                huone11 huone = new harjoitus.View.huone11();
                this.Close();
                huone.ShowDialog();
            }
            if (tmp == 2)
            {
                huone2 huone = new harjoitus.View.huone2();
                this.Close();
                huone.ShowDialog();
            }
        }
    }
}
