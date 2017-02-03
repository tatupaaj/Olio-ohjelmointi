using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kulkuneuvot;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Polkupyora polkupyora = new Polkupyora();
            string nimi = "Jopo";
            string model = "Street";
            int vuosi = 2016;
            string vari = "Blue";
            bool vaihdepyora = true;
            string mallinimi = "";
            Console.WriteLine(AddBike(nimi, model, vuosi, vari, vaihdepyora, mallinimi));
            nimi = "Tunturi";
            model = "StreetPower";
            vuosi = 2010;
            vari = "Red";
            vaihdepyora = false;
            mallinimi = "Shimano";
            Console.WriteLine(AddBike(nimi, model, vuosi, vari, vaihdepyora, mallinimi));
            nimi = "Suvi";
            model = "S900";
            vuosi = 2012;
            vari = "Yellow";
            string tyyppi = "Rowboat";
            int istuinpaikka = 4;
            Console.WriteLine(AddBoat(nimi, model, vuosi, vari, tyyppi, istuinpaikka));
            nimi = "Yamaha";
            model = "S900";
            vuosi = 2012;
            vari = "Yellow";
            tyyppi = "Motorboat";
            istuinpaikka = 6;
            Console.WriteLine(AddBoat(nimi, model, vuosi, vari, tyyppi, istuinpaikka));
        }

        static string AddBike(string nimi, string model, int vuosi, string color, bool vaihdepyora, string mallinimi)
        {
            Polkupyora polkupyora = new Polkupyora(nimi, model, vuosi, color, vaihdepyora, mallinimi);
            return polkupyora.Info();
        }
        static string AddBoat(string nimi, string model, int vuosi, string color, string tyyppi, int istuinpaikka)
        {
            Vene vene = new Vene(nimi, model, vuosi, color, tyyppi, istuinpaikka);
            return vene.Info();
        }
    }
}
