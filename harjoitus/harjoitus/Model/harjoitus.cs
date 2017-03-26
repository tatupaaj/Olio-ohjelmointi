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
        public List<Avain> Avaimet { get; set; }
        public Huone()
        {
            Avaimet = new List<Avain>();
        }
        //public int HuoneNumero { get; set; }
        public int AvaidenMaara { get; set; }
    }

    public class Esine
    {
        public string Name { get; set; }
        public string Image { get; set; }
        /*public Esine(string name, string image)
        {
            Name = name;
            Image = image;
        }*/
        
    }

    public class Avain
    {
        public int KeyNumber { get; set; }
        public bool IsFound { get; set; }
        public Avain(int keynumber, bool isfound)
        {
            KeyNumber = keynumber;
            IsFound = isfound;
        }
        public void Disappearing(Button myButton)
        {
            myButton.Visibility = Visibility.Hidden;
        }
    }
}

