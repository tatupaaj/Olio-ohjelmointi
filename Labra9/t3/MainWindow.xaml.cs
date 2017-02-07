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

namespace t3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            number = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text))/10;
            textBlock9.Text = number.ToString() + " cm^2";
            number = ((double.Parse(textBox1.Text)- 2 * double.Parse(textBox3.Text)) * (double.Parse(textBox2.Text) - 2 * double.Parse(textBox3.Text))) / 10;
            textBlock10.Text = number.ToString() + " cm^2";
            number = (double.Parse(textBox1.Text) * 2 + double.Parse(textBox2.Text) * 2) / 10;
            textBlock11.Text = number.ToString() + " cm";
        }
    }
}
