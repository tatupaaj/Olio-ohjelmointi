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
using harjoitus;

namespace harjoitus.View
{
    /// <summary>
    /// Interaction logic for PelinLopetus.xaml
    /// </summary>
    public partial class PelinLopetus : Window
    {
        public PelinLopetus()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow game = new harjoitus.View.MainWindow();
            this.Close();
            game.ShowDialog();
        }
    }
}
