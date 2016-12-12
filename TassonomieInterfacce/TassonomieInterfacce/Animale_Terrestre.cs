using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TassonomieInterfacce
{
    public abstract class Animale_Terrestre:Animale
    {
        public Animale_Terrestre(string Nome, int mNumeroZampe, string mTipoAnimale, string mSiMuove, string mManto):base(Nome,mNumeroZampe,mTipoAnimale,"Terra",mSiMuove,mManto)
        {
            
        }
    }
}
