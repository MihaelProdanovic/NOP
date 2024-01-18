using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje
{
    class Program
    {
        static void Main()
        {
            
            int a = 100;
            int b = 3;

           
            int quotient = a / b;
            int remainder = a % b;

            
            Console.WriteLine($"\"a dijeljeno s b je {quotient} i ostatak {remainder}\"");

            
            Console.ReadLine();
        }
    }
}

