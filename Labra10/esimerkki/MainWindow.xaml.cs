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

namespace esimerkki
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

        private void btnDrawPolyName_Click(object sender, RoutedEventArgs e)
        {
            //Määritellään polyline
            SolidColorBrush scb = new SolidColorBrush();
            scb.Color = Colors.OrangeRed;
            //Piirretään se
            Polyline pl = new Polyline();
            //kiinnitys (kiinnitetään tietyn värinen harja polylineen
            pl.Stroke = scb;
            //Paksuus
            pl.StrokeThickness = 3;
            //Lisätään polyline polyline-olio gridin lapseksi
            MyGrid.Children.Add(pl);
            //arvotaan polyline pisteet
            Random rnd = new Random();
            //point collection kokoelma (kokoelma pisteitä (stuct, x ja y koordinaatteja))
            PointCollection myPoints = new PointCollection();
            //arvotaan pisteitä
            int x, y;
            for (int i = 0; i < 100; i++)
            {
                //muuta double to int ja max arvot ovat tämän(this) ikkunan leveys
                x = rnd.Next((int)this.Width);
                y = rnd.Next((int)this.Height);
                myPoints.Add(new Point(x, y));
            }
            pl.Points = myPoints;
        }
    }
}