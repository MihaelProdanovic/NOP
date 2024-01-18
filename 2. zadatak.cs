using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            // Zatraži unos niza znakova od korisnika
            Console.WriteLine("Unesite niz znakova:");
            string unos = Console.ReadLine();

            
            string rezultat = ZamijeniRazmake(unos);

           
            Console.WriteLine("Rezultat zamjene razmaka:");
            Console.WriteLine(rezultat);

           
            Console.ReadLine();
        }

        static string ZamijeniRazmake(string originalniNiz)
        {
            
            return originalniNiz.Replace(' ', '_');
        }
    }
}
