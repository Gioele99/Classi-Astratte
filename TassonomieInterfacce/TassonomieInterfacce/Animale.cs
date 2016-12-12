using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TassonomieInterfacce
{
    public abstract class Animale
    {
        protected string NomeAnimale;
        protected string TipoAnimale;
        protected string Habitat;
        protected int NumeroZampe;
        protected string SiMuove;
        protected string Manto;

        public Animale(string Nome, int mNumeroZampe, string mTipoAnimale, string mHabitat, string mSiMuove , string mManto)
        {
            NomeAnimale = Nome;
            TipoAnimale = mTipoAnimale;
            Habitat = mHabitat;
            NumeroZampe = mNumeroZampe;
            SiMuove = mSiMuove;
            Manto = mManto;
        }
        public string getNomeAnimale()
        {
            return NomeAnimale;
        }

        public string getTipoAnimale()
        {
            return TipoAnimale;
        }

        public string getHabitat()
        {
            return Habitat;
        }

        public int getNumeroZampe()
        {
            return NumeroZampe;
        }

        public string getSimuove()
        {
            return SiMuove;
        }
        public string getManto()
        {
            return Manto;
        }
        public void Riepilogo()
        {
            Console.WriteLine("Il nome dell'animale è : " + NomeAnimale);
            Console.WriteLine("Il tipo di animale è : " + TipoAnimale);
            Console.WriteLine("Il suo habitat è : " + Habitat);
            Console.WriteLine("Ha " + NumeroZampe + " zampe");
            Console.WriteLine("Si muove : " + SiMuove);
            Console.WriteLine("Il suo manto è :" + Manto);
        }
    }
}

