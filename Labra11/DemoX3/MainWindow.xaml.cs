using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using JAMK.ICT;

namespace DemoX3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        JAMK.ICT.HockeyLeague liiga;
        ObservableCollection<JAMK.ICT.HockeyTeam> joukkueet;
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            IniMyStuff();
        }
        private void IniMyStuff()
        {
            //tänne kootusti omien kontrollien alustukset
            List<string> muuvit = new List<string>();
            muuvit.Add("Halloween");
            muuvit.Add("Jaws");
            muuvit.Add("Star Wars");
            muuvit.Add("Pahat pojat");
            cmdMovies.ItemsSource = muuvit;
            //haetaan SMLiiga joukkueet
            liiga = new JAMK.ICT.HockeyLeague();
            joukkueet = liiga.GetTeams();
            cmdTeams.ItemsSource = joukkueet;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //määritellan stackpanelin datacontext
            //demo1: datacontekstini on olio
            //HockeyTeam tiimi = new JAMK.ICT.HockeyTeam("Keupa", "Keuruu");
            //spRight.DataContext = tiimi;
            //demo2: kytketään olio-kokoelman 1. olioon
            spRight.DataContext = joukkueet[counter];
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (counter == joukkueet.Count-1)
            {
                counter = 0;
                spRight.DataContext = joukkueet[counter];
            }
            else
            {
                counter++;
                spRight.DataContext = joukkueet[counter];
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 0)
            {
                counter = joukkueet.Count-1;
                spRight.DataContext = joukkueet[counter];
            }
            else
            {
                counter--;
                spRight.DataContext = joukkueet[counter];
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            HockeyTeam t = new HockeyTeam();
            t.Name = name.Text;
            t.City = city.Text;
            joukkueet.Add(t);
        }
    }
}
