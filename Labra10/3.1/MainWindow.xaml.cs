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
    public class Lotto
    {
        public int Index { get; set; }
        public int Maara { get; set; }
        private List<string> draws;
        public Lotto()
        {
            draws = new List<string>();
        }
        public void Numerot()
        {
            Random rnd = new Random();
            string tmp;
            switch (Index)
            {
                case 0:
                    for (int i = 0; i < Maara; i++)
                    {
                        tmp = "";
                        for (int j = 0; j < 7; j++)
                        {
                            tmp = tmp + " " + rnd.Next(1, 40);
                        }
                        draws.Add(tmp);
                    }
                    break;
                case 1:
                    for (int i = 0; i < Maara; i++)
                    {
                        tmp = "";
                        for (int j = 0; j < 6; j++)
                        {
                            tmp = tmp + " " + rnd.Next(1, 49);
                        }
                        draws.Add(tmp);
                    }
                    break;
                case 2:
                    for (int i = 0; i < Maara; i++)
                    {
                        tmp = "";
                        for (int j = 0; j < 7; j++)
                        {
                            tmp = tmp + " " + rnd.Next(1, 51);
                        }
                        draws.Add(tmp);
                    }
                    break;
            }
        }
        public string Print()
        {
            string tmp = "";
            foreach (string s in draws)
            {
                tmp = tmp + s + "\n";
            }
            return tmp;
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void draw_Click(object sender, RoutedEventArgs e)
        {

            Lotto lotto = new Lotto();
            lotto.Index = Int32.Parse(comboBox.SelectedIndex.ToString());
            lotto.Maara = Int32.Parse(textBox.Text);
            lotto.Numerot();
            sv.Content = lotto.Print();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            sv.Content = "";
        }
    }
}
