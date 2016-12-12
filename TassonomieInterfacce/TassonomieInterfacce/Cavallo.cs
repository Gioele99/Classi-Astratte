using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TassonomieInterfacce
{
    class Cavallo:Mammifero_Terrestre,Aniamle_Peloso,Quadrupede
    {
        public Cavallo():base("Cavallo",4,"Peloso")
        {

        }
        public void descrizionepelo()
        {
            Console.WriteLine("complesso dei peli che rivestono il corpo del cavallo");
        }

        public void descrizioneQuadrupede()
        {
            Console.WriteLine("Il cavallo è un mammifero di medio-grossa taglia ed è un quadrupede");
        }


    }
}
