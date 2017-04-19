﻿using System;
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
        }
    }
}

