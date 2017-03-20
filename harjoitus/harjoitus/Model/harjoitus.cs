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
        public string Name { get; set; }
        public string Image { get; set; }
        public Huone(string name, string image)
        {
            Name = name;
            Image = image;
        }
        //public int HuoneNumero { get; set; }
        public List<Esine> Esineet { get; set; }
        public int AvaidenMaara { get; set; }
    }

    public class Esine
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public bool IsVisible { get; set; }
        public Esine(string name, string image, bool isvisible)
        {
            Name = name;
            Image = image;
            IsVisible = IsVisible;
        }
        public void Move(Button mybutton)
        {
            //Button button = (Button)mybutton;
            mybutton.Visibility  = Visibility.Hidden;
        }
    }

    public class Avain
    {
        public int AvainNumero { get; set; }
        public bool OnkoLöyty { get; set; }
    }
}

