using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
           
            int a, b;
            double c, d;

         
            a = 10;
            b = 7;
            c = 12.5;
            d = 16.7;

            
            double prosjek = (a + b + c + d) / 4.0;

           
            Console.WriteLine("Prosjek vrijednosti je: {0}", prosjek);

            
            Console.ReadLine();
        }
    }
}
