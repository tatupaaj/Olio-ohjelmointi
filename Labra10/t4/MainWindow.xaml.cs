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

namespace t4
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

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "0";
            }
            else
                input.Text = input.Text + "0";
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text + ",";
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "1";
            }
            else
                input.Text = input.Text + "1";
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "2";
            }
            else
                input.Text = input.Text + "2";
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "3";
            }
            else
                input.Text = input.Text + "3";
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "4";
            }
            else
                input.Text = input.Text + "4";
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "5";
            }
            else
                input.Text = input.Text + "5";
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "6";
            }
            else
                input.Text = input.Text + "6";
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "7";
            }
            else
                input.Text = input.Text + "7";
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "8";
            }
            else
                input.Text = input.Text + "8";
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "";
                input.Text = input.Text + "9";
            }
            else
                input.Text = input.Text + "9";
        }

        private void erase_Click(object sender, RoutedEventArgs e)
        {
            string s = input.Text;
            if (s.Length == 1)
            {
                input.Text = "0";
                message.Text = "Info: set values and click ok!";
            }
            else
            {
                string newLine = s.Substring(0, s.Length - 1);
                input.Text = newLine;
            }
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            double tmp;
            if (double.TryParse(input.Text, out tmp))
            {
                tmp = double.Parse(input.Text);
                if ((bool)rtemp.IsChecked)
                {
                    if (tmp <= 120)
                    {
                        temp.Text = Convert.ToString(tmp);
                        input.Text = "0";
                        message.Text = "";
                    }
                    else
                    {
                        message.Text = "Temperature is too high!";
                        input.Text = "0";
                    }
                }
                else if ((bool)rhumi.IsChecked)
                {
                    if (tmp <= 100)
                    {
                        hum.Text = Convert.ToString(tmp);
                        input.Text = "0";
                        message.Text = "";
                    }
                    else
                    {
                        message.Text = "Humidity is too high!";
                        input.Text = "0";
                    }
                }
            }
            else
                message.Text = "It's not a number!";
        }
    }
}
