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
using System.Windows.Navigation;
using System.Windows.Shapes;
using harjoitus;
using System.Collections.ObjectModel;
using harjoitusClass;

namespace harjoitus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Esine table = new Esine { Numero = 1, Image ="pictures/1.png" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnImageButtonClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
