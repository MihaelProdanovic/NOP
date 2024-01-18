using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaC
{
    class KlasaC
    {
        public int Zbroj(int[] niz)
        {
            int zbroj = 0;
            foreach (int broj in niz)
            {
                zbroj += broj;
            }
            return zbroj;
        }

        public double Prosjek(int[] niz)
        {
            int zbroj = Zbroj(niz);
            return (double)zbroj / niz.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            KlasaC objekt = new KlasaC();

            int[] unos = new int[5];

         
            Console.WriteLine("Unesite 5 cijelih brojeva:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Broj {i + 1}: ");
                unos[i] = Convert.ToInt32(Console.ReadLine());
            }

           
            int zbroj = objekt.Zbroj(unos);
            double prosjek = objekt.Prosjek(unos);

            
            Console.WriteLine($"Zbroj: {zbroj}");
            Console.WriteLine($"Prosjek: {prosjek}");

          
            Console.ReadLine();
        }
    }
}
