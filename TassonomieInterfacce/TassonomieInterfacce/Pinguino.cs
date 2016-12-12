using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TassonomieInterfacce
{
    class Pinguino:Uccello__Marino,Animale_Piumoso
    {
        public Pinguino():base("Pinguino")
        {

        }
        public void descrizionePiume()
        {
            Console.WriteLine("Le piume sono molto sottili e abbastanza fragili");
        }
    }
}
