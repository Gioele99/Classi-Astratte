using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TassonomieInterfacce
{
    class Ippopotamo:Mammifero_Fluviale,Quadrupede
    {
        public Ippopotamo():base("Ippopotamo")
        {

        }
        public void descrizioneQuadrupede()
        {
            Console.WriteLine("L'ippopotamo, dal greco ἱπποπόταμος è un grosso mammifero erbivoro africano e fa parte della famiglia quadrupede.");
        }
    }
}
