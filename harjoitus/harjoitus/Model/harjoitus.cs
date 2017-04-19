using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace harjoitus.Model
{
    public class Huone
    {
        public int HuoneNumero { get; set; }
        public string Image { get; set; }
        public List<Avain> Avaimet { get; set; }
        public Huone()
        {
            Avaimet = new List<Avain>();
        }
        public void DoorWork(int n, TextBlock text, Button b1, Button b2)
        {
            if (n != 3)
                text.Text = "Not enough keys!";
            else
            {
                b1.Visibility = Visibility.Hidden;
                b2.Visibility = Visibility.Visible;
            }
        }
    }

    public class Esine
    {
        public string Image { get; set; }
        public bool IsMoved { get; set; }
        public void MoveRight(Button myButton, int x)
        {
            if (IsMoved == false)
            {
                Canvas.SetLeft(myButton, Canvas.GetLeft(myButton) + x);
                IsMoved = true;
            }
            else
            {
                Canvas.SetLeft(myButton, Canvas.GetLeft(myButton) - x);
                IsMoved = false;
            }
        }
        public void MoveLeft(Button myButton, int x)
        {
            if (IsMoved == false)
            {
                Canvas.SetLeft(myButton, Canvas.GetLeft(myButton) - x);
                IsMoved = true;
            }
            else
            {
                Canvas.SetLeft(myButton, Canvas.GetLeft(myButton) + x);
                IsMoved = false;
            }
        }
        public void MoveUp(Button myButton, int x)
        {
            if (IsMoved == false)
            {
                Canvas.SetTop(myButton, Canvas.GetTop(myButton) - x);
                IsMoved = true;
            }
            else
            {
                Canvas.SetTop(myButton, Canvas.GetTop(myButton) + x);
                IsMoved = false;
            }
        }
        public void MoveDown(Button myButton, int x)
        {
            if (IsMoved == false)
            {
                Canvas.SetTop(myButton, Canvas.GetTop(myButton) + x);
                IsMoved = true;
            }
            else
            {
                Canvas.SetTop(myButton, Canvas.GetTop(myButton) - x);
                IsMoved = false;
            }
        }

        public void MoveDownLeft(Button myButton, int x, int y)
        {
            if (IsMoved == false)
            {
                Canvas.SetTop(myButton, Canvas.GetTop(myButton) + x);
                Canvas.SetLeft(myButton, Canvas.GetLeft(myButton) - y);
                IsMoved = true;
            }
            else
            {
                Canvas.SetTop(myButton, Canvas.GetTop(myButton) - x);
                Canvas.SetLeft(myButton, Canvas.GetLeft(myButton) + y);
                IsMoved = false;
            }
        }

        public void MoveDownRight(Button myButton, int x, int y)
        {
            if (IsMoved == false)
            {
                Canvas.SetTop(myButton, Canvas.GetTop(myButton) + x);
                Canvas.SetLeft(myButton, Canvas.GetLeft(myButton) + y);
                IsMoved = true;
            }
            else
            {
                Canvas.SetTop(myButton, Canvas.GetTop(myButton) - x);
                Canvas.SetLeft(myButton, Canvas.GetLeft(myButton) - y);
                IsMoved = false;
            }
        }

        public void MoveUpRight(Button myButton, int x, int y)
        {
            if (IsMoved == false)
            {
                Canvas.SetTop(myButton, Canvas.GetTop(myButton) - x);
                Canvas.SetLeft(myButton, Canvas.GetLeft(myButton) + y);
                IsMoved = true;
            }
            else
            {
                Canvas.SetTop(myButton, Canvas.GetTop(myButton) + x);
                Canvas.SetLeft(myButton, Canvas.GetLeft(myButton) - y);
                IsMoved = false;
            }
        }

        public void MoveUpLeft(Button myButton, int x, int y)
        {
            if (IsMoved == false)
            {
                Canvas.SetTop(myButton, Canvas.GetTop(myButton) - x);
                Canvas.SetLeft(myButton, Canvas.GetLeft(myButton) - y);
                IsMoved = true;
            }
            else
            {
                Canvas.SetTop(myButton, Canvas.GetTop(myButton) + x);
                Canvas.SetLeft(myButton, Canvas.GetLeft(myButton) + y);
                IsMoved = false;
            }
        }
    }

    public class Avain : Esine
    {
        public int KeyNumber { get; set; }
        public bool IsFound { get; set; }
        public bool IsHint { get; set; }
        public void Disappearing(Button myButton, Avain a)
        {
            myButton.Visibility = Visibility.Hidden;
            a.IsFound = true;
        }
        public void HintAppear(Button myButton, Avain a)
        {
            myButton.Visibility = Visibility.Visible;
            a.IsHint = true;
        }
            public void HintDisappear(Button myButton, Avain a)
        {
            myButton.Visibility = Visibility.Hidden;
            a.IsHint = false;
        }
    }

    public static class Toiminta
    {
        public static void MenuKeys(int n, Image b1, Image b2, Image b3)
        {
            switch (n)
            {
                case 1:
                    b1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    b2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    b2.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }
        public static void MessageWork(int n, TextBlock m)
        {
            switch (n)
            {
                case 1:
                    m.Text = "Still 2 keys to go!";
                    break;
                case 2:
                    m.Text = "Only 1 key to go!";
                    break;
                case 3:
                    m.Text = "All keys are found! You can get out of the room!";
                    break;
            }
        }
    }
}

