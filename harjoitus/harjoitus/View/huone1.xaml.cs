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

namespace harjoitus.View
{
    /// <summary>
    /// Interaction logic for huone1.xaml
    /// </summary>
    public partial class huone1 : Window
    {
        Esine esine1 = new Esine("table", "pack://application:,,,/Resources/table.png", false);
        //harjoitus.ViewModel.MainViewModel svmo = new harjoitus.ViewModel.MainViewModel();
        public huone1()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void OnImageButtonClick(object sender, RoutedEventArgs e)
        {
            esine1.Move(aButton);
        }
    }
}
