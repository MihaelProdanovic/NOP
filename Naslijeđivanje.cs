using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naslijeđivanje
{
   class Cat
    {
        bool opasna;

        public bool Opasna { get => opasna; set => opasna = value; }

        void Opasnost()
        {
            Opasna = false;
        }
    }

    class Gepard : Cat
    {
        public override void Opasnost()
        {
            Opasna = true;
        }
    }

}
