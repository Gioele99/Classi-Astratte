using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_1
{
    public abstract class Figura
    {
        protected string mNome;
        protected int mNumeroLati;

        public Figura (string Nome, int NumeroLati)
        {
            mNome = Nome;
            mNumeroLati = NumeroLati;
        }

        public string getNome()
        {
            return mNome;
        }

        public int getNumeroLati()
        {
            return mNumeroLati;
        }

        public abstract double getPerimetro();
        public abstract double getArea();
        public abstract void Disegna();




    }
}
