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
using tyo;

namespace t3
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Tyontekija[] t = new Tyontekija[4];
        public MainWindow()
        {
            InitializeComponent();
        }
        private void hae_Click(object sender, RoutedEventArgs e)
        {

            t[0] = new Tyontekija { Etunimi = "Alfred", Sukunimi = "Nobel", Numero = 1, Nimike = "toimitusjohtaja", Palkka = 50000 };
            t[1] = new Tyontekija { Etunimi = "Beatrix", Sukunimi = "Bamboo", Numero = 2, Nimike = "opettaja", Palkka = 3000 };
            t[2] = new Tyontekija { Etunimi = "Cecilia", Sukunimi = "Tapper", Numero = 3, Nimike = "hoitaja", Palkka = 2000 };
            t[3] = new Tyontekija { Etunimi = "Daavid", Sukunimi = "Cooper", Numero = 4, Nimike = "lääkäri", Palkka = 4000 };
            listBox.Items.Add(t[0].ToString());
            listBox.Items.Add(t[1].ToString());
            listBox.Items.Add(t[2].ToString());
            listBox.Items.Add(t[3].ToString());
        }   
        private void list_Selected(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                int tmp = listBox.SelectedIndex;
                etunimi.Text = t[tmp].Etunimi;
                sukunimi.Text = t[tmp].Sukunimi;
                numero.Text = Convert.ToString(t[tmp].Numero);
                titteli.Text = t[tmp].Nimike;
                palkka.Text = Convert.ToString(t[tmp].Palkka);
            }
            
        }
        private void tyhjenna_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
        }

        private void ylikirjita_Click(object sender, RoutedEventArgs e)
        {
            int tmp = listBox.SelectedIndex;
            listBox.Items.RemoveAt(tmp);
            listBox.Items.Insert(tmp, numero.Text + "=" + etunimi.Text + " " + sukunimi.Text + "," + titteli.Text); 
        }
    }
}
