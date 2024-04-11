using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaSport
{
    class sport
    {
        private string Naziv;
        private bool IgraLiSeLoptom;
        private byte BrojIgraca;

        public sport(string naziv)
        {
            this.Naziv = naziv;
            this.IgraLiSeLoptom = false;
            this.BrojIgraca = 0;
        }

        public sport(string naziv, bool igraliseloptom) 
        { 
            this.Naziv = naziv;
            this.IgraLiSeLoptom= igraliseloptom;
            this.BrojIgraca= 0;

        }

        public sport(string naziv, bool igraliseloptom, byte brojigraca) 
        {
            this.Naziv = naziv;
            this.IgraLiSeLoptom = igraliseloptom;
            this.BrojIgraca = brojigraca;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sport Nogomet = new sport("Nogomet");
            sport Vaterpolo = new sport("Vaterpolo", true);
            sport Curling = new sport("Curling", false, 4);

            Console.WriteLine("Nogomet: " + Nogomet.Naziv + ", Igra li se loptom? " + Nogomet.IgraLiSeLoptom + ", Broj igrača: " + Nogomet.BrojIgraca);
            Console.WriteLine("Vaterpolo: " + Vaterpolo.Naziv + ", Igra li se loptom? " + Vaterpolo.IgraLiSeLoptom + ", Broj igrača: " + Vaterpolo.BrojIgraca);
            Console.WriteLine("Curling: " + Curling.Naziv + ", Igra li se loptom? " + Curling.IgraLiSeLoptom + ", Broj igrača: " + Curling.BrojIgraca);

            Console.ReadKey();
        
        }
    }
}
