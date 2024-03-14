using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanjezaispit
{
    public class GeometrijskoTijelo
    {
        public double Volumen;
        public double Oplosje;
        public static int BrojacTijela;

        public GeometrijskoTijelo()
        {
            BrojacTijela++;
        }
    }

    public class Kugla : GeometrijskoTijelo
    {
        // Dodatne varijable ili metode specifične za kuglu
    }

    public class Kvadar : GeometrijskoTijelo
    {
        // Dodatne varijable ili metode specifične za kvadar
    }

    public class Kocka : Kvadar
    {
        // Dodatne varijable ili metode specifične za kocku
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kugla x = new Kugla();
            Kvadar y = new Kvadar();
            Kocka z = new Kocka();

            Console.WriteLine("Broj geometrijskih tijela: " + GeometrijskoTijelo.BrojacTijela);

            Console.ReadKey();
        }
    }
}
