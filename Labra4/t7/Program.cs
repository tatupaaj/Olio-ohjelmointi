using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using menu;

namespace t7
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee("Late", true, false, true, true);
            Tea tea = new Tea("Green tea", true, false, false);
            Coctail coctail = new Coctail("Margarita", false, true, false, true);
            Soup soup = new Soup("Jauhelihakeitto", "usual", true, true, false);
            MainDish maindish = new MainDish("Salmonsteak", "grillfood", true, false, true, "Salad");
            Dessert dessert = new Dessert("Icecreamballs", "icecream", false, "chocolate");
            Console.WriteLine(coffee.Info());
            Console.WriteLine(tea.Info());
            Console.WriteLine(coctail.Info());
            Console.WriteLine(soup.Info());
            Console.WriteLine(maindish.Info());
            Console.WriteLine(dessert.Info());
        }
    }
}
