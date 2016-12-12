using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TassonomieInterfacce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SALMONE");
            Salmone s = new Salmone();
            s.Riepilogo();
            s.DescrizioneSquame();
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("TONNO");
            Tonno t = new Tonno();
            t.Riepilogo();
            t.DescrizioneSquame();
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("BALENA");
            Balena b = new Balena();
            b.Riepilogo();
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("PINGUINO");
            Pinguino p = new Pinguino();
            p.Riepilogo();
            p.descrizionePiume();
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("CORVO");
            Corvo C = new Corvo();
            C.Riepilogo();
            C.descrizionePiume();
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("IPPOPOTAMO");
            Ippopotamo i = new Ippopotamo();
            i.Riepilogo();
            i.descrizioneQuadrupede();
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("CAVALLO");
            Cavallo c = new Cavallo();
            c.Riepilogo();
            c.descrizioneQuadrupede();
            c.descrizionepelo();
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("UOMO");
            Uomo u = new Uomo();
            u.Riepilogo();
            u.ComeCammina();
            u.descrizionepelo();
            Console.WriteLine("-----------------------------------------------");

            Console.ReadLine();

        }
    }
}
