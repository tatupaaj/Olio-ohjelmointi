using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile = null;
            try
            {
                List<int> kokonaisluvut = new List<int>();
                List<double> realilivut = new List<double>();
                while (true)
                {
                    Console.WriteLine("Kirjoita luku (Ei luku lopettaa ohjelman):");
                    string tmp = Console.ReadLine();
                    int number;
                    double rnumber;
                    if (Int32.TryParse(tmp, out number) == true)
                    {
                        kokonaisluvut.Add(Int32.Parse(tmp));
                    }
                    else if (double.TryParse(tmp, out rnumber) == true)
                    {
                        realilivut.Add(float.Parse(tmp));
                    }
                    else
                        break;
                }
                outputFile = new System.IO.StreamWriter(@"d:\Temp\kokonaisluvut.txt");
                foreach (int n in kokonaisluvut)
                {
                    outputFile.WriteLine(n);
                }
                outputFile.Close();
                outputFile = new System.IO.StreamWriter(@"d:\Temp\realilivut.txt");
                foreach (float n in realilivut)
                {
                    outputFile.WriteLine(n);
                }
                outputFile.Close();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Can't open file for writing (UnauthorizedAccessException)");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Opened stream is null (ArgumentNullException)");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Opened stream is not writable (ArgumentException)");
            }
            catch (IOException)
            {
                Console.WriteLine("An IO error happend (IOException)");
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad Format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow");
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
        }
    }
}