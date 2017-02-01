using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile = null;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                outputFile = new System.IO.StreamWriter(mydocpath + @"\test.txt");
                while (true)
                {
                    Console.WriteLine("Give a text line (enter ends) :");
                    string tmp = Console.ReadLine();
                    if (tmp == "x")
                        break;
                    else
                        outputFile.WriteLine(tmp);
                }
                outputFile.Close();
                string[] lines = System.IO.File.ReadAllLines(mydocpath + @"\test.txt");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
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
            catch (Exception)
            {
                Console.WriteLine("Some other exception happend (Exception)");
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
