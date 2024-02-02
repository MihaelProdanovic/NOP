using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedivanjevjezba3
{
    internal class Program
    {
        

        class Biljka
        {

        }

        class Stablo : Biljka
        {
            bool otpadajuListovi;

            public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }

            public Stablo(bool otpadajuListovi)
            {
                OtpadajuListovi = otpadajuListovi;
            }
        }

        class Cvijet : Biljka { }
        class Bijelogoricno : Stablo
        {
            public Bijelogoricno(bool otpadajuListovi) : base(otpadajuListovi)
            {
            }
        }

        class Crnogoricno : Stablo
        {
            public Crnogoricno(bool otpadajuListovi) : base(otpadajuListovi)
            {
            }
        }
        static void Main(string[] args)
        {
            Bijelogoricno Hrast = new Bijelogoricno(true);

            Crnogoricno Bor = new Crnogoricno(false);
            Console.WriteLine("Hrast otpadaju listovi: " + Hrast.OtpadajuListovi.ToString());
            Console.WriteLine("Bor otpadaju listovi: " + Bor.OtpadajuListovi.ToString());

            Console.ReadKey();
        }
    }
}
