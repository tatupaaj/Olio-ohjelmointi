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

namespace t1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int truck;
        private int car;
        public MainWindow()
        {
            InitializeComponent();
            truck = 0;
            textBlock1.Text = truck.ToString();
            car = 0;
            textBlock2.Text = car.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            truck++;
            textBlock1.Text = truck.ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            car++;
            textBlock2.Text = car.ToString();
        }
    }
}
