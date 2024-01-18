using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Unesite duljinu stranice a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Unesite duljinu stranice b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Unesite duljinu stranice c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            
            if (a > 0 && b > 0 && c > 0)
            {
                
                if (IsPravokutanTrokut(a, b, c))
                {
                    Console.WriteLine("Unesene vrijednosti čine pravokutan trokut.");
                }
                else
                {
                    Console.WriteLine("Unesene vrijednosti ne čine pravokutan trokut.");
                }
            }
            else
            {
                Console.WriteLine("Unesene vrijednosti nisu smislene za duljine stranica trokuta.");
            }

           
            Console.ReadLine();
        }

        
        static bool IsPravokutanTrokut(double a, double b, double c)
        {
            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;

            return (a2 + b2 == c2) || (a2 + c2 == b2) || (b2 + c2 == a2);
        }
    }
}
