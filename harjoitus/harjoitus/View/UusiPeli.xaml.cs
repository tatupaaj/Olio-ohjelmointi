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

namespace harjoitus.View
{
    /// <summary>
    /// Interaction logic for UusiPeli.xaml
    /// </summary>
    public partial class UusiPeli : Window
    {
        public UusiPeli()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            huone1 h = new harjoitus.View.huone1();
            this.Close();
            h.ShowDialog();
        }

        private void btnLoadGame_Click(object sender, RoutedEventArgs e)
        {
            MainWindow no = new harjoitus.View.MainWindow();
            this.Close();
            no.ShowDialog();
        }
    }
}
