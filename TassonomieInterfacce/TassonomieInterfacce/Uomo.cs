using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TassonomieInterfacce
{
    class Uomo:Mammifero_Terrestre,Bipede,Aniamle_Peloso
    {
        public Uomo():base("Uomo",2,"Pelle")
        {

        }

        public void ComeCammina()
        {
            Console.WriteLine("L'uomo ha due arti superiori e due arti inferiori che gli permettono di compiere tutte le azioni che vuole.");
        }

        public void descrizionepelo()
        {
            Console.WriteLine("Ha la pelle che lo protegge,NON TANTISSIMO OVVIAMENTE");
        }
    }
}
