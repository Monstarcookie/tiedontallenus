using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tiedontallenus
{
    class Program
    {
        static void Main(string[] args)
        {

            string tiedosto = @"C:\temp\Lämpötila.txt";

            //luetaan tiedosto
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiempi asetettu lämpötila: " + aiempiArvo);
            }

            else
            {
                Console.WriteLine("Hello!");
            }

            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);

            //tiedostoon kirjoittaminen
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu!");


            Console.ReadLine();
        }
    }
}
