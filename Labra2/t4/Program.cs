using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicle;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Testaavehicle();
        }

        static void Testaavehicle()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Nimi = "Wolksvagen";
            vehicle.Nopeus = 180;
            vehicle.Tyres = 4;
            vehicle.PrintData();
            string text = vehicle.Tostring(vehicle.Nimi, vehicle.Nopeus, vehicle.Tyres);
            Console.WriteLine(text);

        }
    }
}