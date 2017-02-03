using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using radio;

namespace t5
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestaaRadio();
            string valinta;
            Radio radio = new Radio();
            Console.WriteLine("Radio is off");
            while (true)
            {
                Console.WriteLine("Turn on/off radio (Write true or false) or exit (write x)");
                valinta = Console.ReadLine();
                if (valinta == "x")
                    break;
                else
                {
                    radio.Onkopaalla = Convert.ToBoolean(valinta);
                    if (radio.Onkopaalla == false)
                    {
                        Console.WriteLine("You didn't turn on radio");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Radio is: " + radio.Onkopaalla);
                        Console.WriteLine("Choose channel 2000.0 - 26000.0");
                        while (true)
                        {
                            valinta = Console.ReadLine();
                            radio.Kanava = float.Parse(valinta);
                            if (radio.KanavaVaarin(radio.Kanava) == false)
                                Console.WriteLine("Wrong input! Try again!");
                            else
                            {
                                Console.WriteLine("Channel is: " + radio.Kanava);
                                break;
                            }
                        }
                        Console.WriteLine("Choose volume 0-9: ");
                        while (true)
                        {
                            valinta = Console.ReadLine();
                            radio.Voima = Convert.ToInt32(valinta);
                            if (radio.VoimaVaarin(radio.Voima) == false)
                                Console.WriteLine("Wrong input! Try again!");
                            else
                            {
                                Console.WriteLine("Volume is: " + radio.Voima);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
