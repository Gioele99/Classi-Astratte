using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TassonomieInterfacce
{
    public abstract class Animale_Marino:Animale
    {
        public Animale_Marino(string Nome, int mNumeroZampe , string Manto):base(Nome,mNumeroZampe,"Animale Marino","Mare/Lago","Nuota",Manto)
        {
          
        }
    }
}
