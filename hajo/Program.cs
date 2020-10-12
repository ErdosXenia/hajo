using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* 1.feladat: Hány hajó van?
 * 2.feladat: Melyik hajó(k) a legdrágábbak?
 * 3.feladat: Névsorban "hajok.txt"-be kiírni a hajók nevét!
 * 4.feladat: Melyik hajótipusból hány darab van?*/
namespace hajo
{
    class Program
    {
        static List<Hajo> hajok = new List<Hajo>();

        static void Beolvas()
        {
            StreamReader file = new StreamReader("hajo.csv");
            while (!file.EndOfStream)
            {
                hajok.Add(new Hajo(file.ReadLine()));
            }
            file.Close();
        }

        static void feladat1()
        {
            int db = 0;
            for (int i = 0; i < hajok.Count; i++)
            {
                db++;
            }
            Console.WriteLine(db);
        }

        static void feladat2()
        {
            int max = 0;
            foreach (var h in hajok)
            {

                if (h.Dij > max)
                {
                    max = h.Dij;
                    
                }
                
            }
            Console.WriteLine(max);
            
        }

        static void feladat3()
        {
            //List<string> lista = new List<string>();
            StreamWriter sw = new StreamWriter("hajok.txt");
            foreach (var h in hajok)
            {
                //lista.Add(h.Nev);
                sw.WriteLine(h.Nev);
            }
            sw.Close();
        }

        static void feladat4()
        {
            int db = 0;

            foreach (var h in hajok)
            {
                db++;
                db = h.Tipus.Count();
            }

            Console.WriteLine(db);
        }

        static void Main(string[] args)
        {
            Beolvas();
            feladat1();
            feladat2();
            feladat3();
            feladat4();

            Console.ReadKey();
        }
    }
}
