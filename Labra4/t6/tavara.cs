using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tavara
{
    class KirjoituTavara
    {
        public string Nimi { get; set; }
        public int Sivut { get; set; }
    }
    class Kirja : KirjoituTavara
    {

        public string Kirjoittaja { get; set; }
        public int Vuosi { get; set; }
        public Kirja()
        {

        }
        public Kirja(string nimi, int sivut, string kirjoittaja, int vuosi)
        {
            Nimi = nimi;
            Sivut = sivut;
            Kirjoittaja = kirjoittaja;
            Vuosi = vuosi;
        }
        public string Info()
        {
            return "Name: " + Nimi + " Amount of pages: " + Sivut + " Author: " + Kirjoittaja + " Year: " + Vuosi;
        }
    }

    class Lehti : KirjoituTavara
    {
        public string Paivamaara { get; set; }
        public Lehti()
        {

        }
        public Lehti(string nimi, int sivut, string paivamaara)
        {
            Nimi = nimi;
            Sivut = sivut;
            Paivamaara = paivamaara;
        }
        public string Info()
        {
            return "Name: " + Nimi + " Amount of pages: " + Sivut + " Date: " + Paivamaara;
        }
    }

    class Levy
    {
        public double Tilaa { get; set; }
        public double Nopeus { get; set; }
    }

    class CDLevy : Levy
    {
        public bool MontaTalennus { get; set; }
        public CDLevy()
        {

        }
        public CDLevy(double tilaa, double nopeus, bool montaTalennus)
        {
            Tilaa = tilaa;
            Nopeus = nopeus;
            MontaTalennus = montaTalennus;
        }
        public string Info()
        {
            return "CD levy: space: " + Tilaa + " Mb. Speed of writing: " + Nopeus + " kbit/s. Posibility to rewrite: " + MontaTalennus;
        }
    }
    class DVDLevy : Levy
    {
        public bool MontaTalennus { get; set; }
        public DVDLevy()
        {

        }
        public DVDLevy(double tilaa, double nopeus, bool montaTalennus)
        {
            Tilaa = tilaa;
            Nopeus = nopeus;
            MontaTalennus = montaTalennus;
        }
        public string Info()
        {
            return "DVD levy: space: " + Tilaa + " Gb. Speed of writing: " + Nopeus + " Mbit/s. Posibility to rewrite: " + MontaTalennus;
        }
    }
    class BluerayLevy : Levy
    {
        public int Kerrokset { get; set; }
        public BluerayLevy()
        {

        }
        public BluerayLevy(double tilaa, double nopeus, int kerrokset)
        {
            Tilaa = tilaa;
            Nopeus = nopeus;
            Kerrokset = kerrokset;
        }
        public string Info()
        {
            return "Blueray levy: space: " + Tilaa + " Gb. Speed of writing: " + Nopeus + " Mbit/s. Posibility to rewrite: " + Kerrokset;
        }
    }

    class Laite
    {
        public double Paino { get; set; }
        public double NaytonKoko { get; set; }
        public string Merkki { get; set; }
        public double Muisti { get; set; }
    }
    class Lappari : Laite
    {
        public string Videoohjain { get; set; }
        public string Prosessori { get; set; }
        public Lappari()
        {

        }
        public Lappari(double paino, double naytonKoko, string merkki, double muisti, string videoohjain, string prosessori)
        {
            Paino = paino;
            NaytonKoko = naytonKoko;
            Merkki = merkki;
            Muisti = muisti;
            Videoohjain = videoohjain;
            Prosessori = prosessori;
        }
        public string Info()
        {
            return "Lappari: weight: " + Paino + " Size of screen: " + NaytonKoko + "''. Brand: " + Merkki + " Memory: " + Muisti + " Tb. Graphic card: " + Videoohjain + " Prosessor: " + Prosessori;
        }
    }
    class Puhelin : Laite
    {
        public string Tyyppi { get; set; }
        public bool OnkoKamera { get; set; }
        public Puhelin()
        {

        }
        public Puhelin(double paino, double naytonKoko, string merkki, double muisti, string tyyppi, bool onkokamera)
        {
            Paino = paino;
            NaytonKoko = naytonKoko;
            Merkki = merkki;
            Muisti = muisti;
            Tyyppi = tyyppi;
            OnkoKamera = onkokamera;
        }
        public string Info()
        {
            return "Puhelin: weight: " + Paino + " Size of screen: " + NaytonKoko + "''. Brand: " + Merkki + " Memory: " + Muisti + " Gb. Type: " + Tyyppi + " Camera: " + OnkoKamera;
        }
    }
    class Tabletti : Laite
    {
        public bool OnkoSimkortti { get; set; }
        public bool OnkoWiFi { get; set; }
        public Tabletti()
        {

        }
        public Tabletti(double paino, double naytonKoko, string merkki, double muisti, bool onkosimkortti, bool onkowifi)
        {
            Paino = paino;
            NaytonKoko = naytonKoko;
            Merkki = merkki;
            Muisti = muisti;
            OnkoSimkortti = onkosimkortti;
            OnkoWiFi = onkowifi;
        }
        public string Info()
        {
            return "Tabletti: weight: " + Paino + " Size of screen: " + NaytonKoko + "''. Brand: " + Merkki + " Memory: " + Muisti + " Simcard: " + OnkoSimkortti + " Wi-Fi: " + OnkoWiFi;
        }
    }
}