using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_1
{
    class Cerchio : Figura, Rotolone
    {
        public Cerchio():base("Cerchio",1)
        {

        }
        public override void Disegna()
        {
           ///Scrrr scrrrr
        }

        public override double getArea()
        {
            return 12;
        }

        public override double getPerimetro()
        {
            return 4;
        }

        
    }
}
