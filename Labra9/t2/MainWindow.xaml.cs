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

namespace t2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double n;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            n = double.Parse(textBox.Text) * 0.231;
            textBlock2.Text = n.ToString("0.00");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            n = double.Parse(textBox.Text) * 4.326;
            textBlock2.Text = n.ToString("0.00");
        }
    }
}
