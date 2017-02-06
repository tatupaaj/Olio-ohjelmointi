using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaHenkilo();
        }

        static void TestaaHenkilo()
        {
            int ke = 0;
            int kb = 0;
            Tyontekija[] tyontekija = new Tyontekija[5];
            Pomo[] pomo = new Pomo[5];
            while (true)
            {
                Console.WriteLine("Choose do you want to add (press 1) or to change (press 2) person; see list of employees (press 3) or list of bosses (press 4)");
                string valinta = Console.ReadLine();
                if (valinta == "x")
                    break;
                else
                {
                    int ivalinta = Convert.ToInt32(valinta);
                    if (ivalinta == 1)
                    {
                        Console.WriteLine("Choose who do you want to add employee (press 5) or boss (press 6). Maximum 5 employys and 5 bosses");
                        valinta = Console.ReadLine();
                        if (valinta == "x")
                            break;
                        else
                        {
                            ivalinta = Convert.ToInt32(valinta);
                            if (ivalinta == 5)
                            {
                                Console.WriteLine("Write name");
                                string nimi = Console.ReadLine();
                                Console.WriteLine("Write profession");
                                string ammatti = Console.ReadLine();
                                Console.WriteLine("Write salary");
                                int palkka = Int32.Parse(Console.ReadLine());
                                tyontekija[ke] = new Tyontekija(nimi, ammatti, palkka);
                                ke++;
                            }
                            if (ivalinta == 6)
                            {
                                Console.WriteLine("Write name");
                                string nimi = Console.ReadLine();
                                Console.WriteLine("Write profession");
                                string ammatti = Console.ReadLine();
                                Console.WriteLine("Write salary");
                                int palkka = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Write auto");
                                string auto = Console.ReadLine();
                                Console.WriteLine("Write bonus");
                                int bonus = Int32.Parse(Console.ReadLine());
                                pomo[kb] = new Pomo(nimi, ammatti, palkka, auto, bonus);
                                kb++;
                            }
                        }
                    }
                    else if (ivalinta == 2)
                    {
                        Console.WriteLine("Choose who do you want to change employee (press 7) or boss (press 8)");
                        valinta = Console.ReadLine();
                        if (valinta == "x")
                            break;
                        else
                        {
                            ivalinta = Convert.ToInt32(valinta);
                            if (ivalinta == 7)
                            {
                                Console.WriteLine("Write number of employee whos information you want to change");
                                int numero = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Write name");
                                string nimi = Console.ReadLine();
                                Console.WriteLine("Write profession");
                                string ammatti = Console.ReadLine();
                                Console.WriteLine("Write salery");
                                int palkka = Int32.Parse(Console.ReadLine());
                                tyontekija[numero - 1] = new Tyontekija(nimi, ammatti, palkka);

                            }
                            else if (ivalinta == 8)
                            {
                                Console.WriteLine("Write number of boss whos information you want to change");
                                int numero = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Write name");
                                string nimi = Console.ReadLine();
                                Console.WriteLine("Write profession");
                                string ammatti = Console.ReadLine();
                                Console.WriteLine("Write salery");
                                int palkka = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Write car");
                                string auto = Console.ReadLine();
                                Console.WriteLine("Write bonus");
                                int bonus = Int32.Parse(Console.ReadLine());
                                pomo[numero - 1] = new Pomo(nimi, ammatti, palkka, auto, bonus);
                            }
                        }
                    }
                    else if (ivalinta == 3)
                    {
                        for (int i = 0; i < ke; i++)
                        {
                            Console.WriteLine("Työntekijä " + (i + 1) + ": " + tyontekija[i].Info());
                        }
                    }
                    else if (ivalinta == 4)
                    {
                        for (int i = 0; i < kb; i++)
                        {
                            Console.WriteLine("Pomo " + (i + 1) + ": " + pomo[i].Info());
                        }
                    }
                }
            }
        }
    }
}
