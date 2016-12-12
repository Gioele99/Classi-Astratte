using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TassonomieInterfacce
{
    public abstract class Mammifero_Terrestre:Animale_Terrestre
    {
        public Mammifero_Terrestre(string Nome, int mNumeroZampe, string mManto) : base(Nome,mNumeroZampe,"Mammifero Terrestre","Cammina/Corre/Mnagia", mManto)
        {

        }
    }
}
