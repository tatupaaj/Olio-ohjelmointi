using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ohjelma;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Ohjelma oh1 = new Ohjelma { Nimi = "Sinkkullallinen", Kanava = "Liv", Alkuaika = "13:30", Loppuaika = "14:40", Infoteksti = "Elokuva/Drama. Kausi 6, Jakso 7/26" };
            Ohjelma oh2 = new Ohjelma { Nimi = "Jäätimäiset rakennusurakat", Kanava = "Fox", Alkuaika = "13:00", Loppuaika = "14:00", Infoteksti = "Kiinan älykäs pilvenpiirtäjä" };
            Ohjelma oh3 = new Ohjelma { Nimi = "Kummituskievari", Kanava = "Yli", Alkuaika = "13:15", Loppuaika = "14:25", Infoteksti = "Elokuva/Drama. Suomi 1954" };
            // open stream for writing objects
            Stream writeStream = new FileStream("Ohjelma.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            // use binary formatted
            IFormatter formatter = new BinaryFormatter();
            // write person object to file
            formatter.Serialize(writeStream, oh1);
            formatter.Serialize(writeStream, oh2);
            formatter.Serialize(writeStream, oh3);
            // close file
            writeStream.Close();
            // create stream for reading binary files
            Stream readStream = new FileStream("Ohjelma.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            // read and deserialize person object from stream/file
            Ohjelma readPerson = (Ohjelma)formatter.Deserialize(readStream);
            // write proof
            Console.WriteLine(oh1.ToString());
            Console.WriteLine(oh2.ToString());
            Console.WriteLine(oh3.ToString());
        }
    }
}