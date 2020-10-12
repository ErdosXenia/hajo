using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajo
{
    class Hajo
    {
        public int Regiszter { get; private set; }
        public string Nev { get; private set; }
        public string Tipus { get; private set; }
        public int Utas { get; private set; }
        public int Dij { get; private set; }

        public Hajo(string sor)
        {
            // "7;Durbincs;WIN-22;5;24000"
            string[] a = sor.Split(';');
            Regiszter = Convert.ToInt32(a[0]);
            Nev = a[1];
            Tipus = a[2];
            Utas = Convert.ToInt32(a[3]);
            Dij = Convert.ToInt32(a[4]);

        }
    }
}
