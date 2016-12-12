using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TassonomieInterfacce
{
    public abstract class Uccello:Animale_Terrestre,Animale_Piumoso
    {
        public Uccello(string Nome) :base(Nome,2,"Animale Terrestre","Vola/Cammina","Piumoso")
        {

        }

        public void descrizionePiume()
        {
            Console.WriteLine("Le piume sono molto sottili e abbastanza fragili");
        }
    }
}
