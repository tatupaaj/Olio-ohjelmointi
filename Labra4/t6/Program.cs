using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavara;

namespace t6
{
    class Program
    {
        static void Main(string[] args)
        {
            Kirja kirja = new Kirja("Three comraides", 400, " Erich Maria Remarque", 1936);
            Console.WriteLine(kirja.Info());
            Lehti lehti = new Lehti("Keskisuomalainen", 10, "23.01.2017");
            Console.WriteLine(lehti.Info());
            CDLevy cdlevy = new CDLevy(900, 150, false);
            Console.WriteLine(cdlevy.Info());
            DVDLevy dvdlevy = new DVDLevy(4.05, 10, true);
            Console.WriteLine(dvdlevy.Info());
            BluerayLevy blueraylevy = new BluerayLevy(25, 36, 4);
            Console.WriteLine(blueraylevy.Info());
            Lappari lappari = new Lappari(3, 17, "Asus", 500, "NVidia GeForce 920m", "Intel i7-920");
            Console.WriteLine(lappari.Info());
            Tabletti tabletti = new Tabletti(500, 12, "Apple", 200, false, true);
            Console.WriteLine(tabletti.Info());
            Puhelin puhelin = new Puhelin(100, 2.5, "Sony", 16, "smartphone", true);
            Console.WriteLine(puhelin.Info());
        }
    }
}
