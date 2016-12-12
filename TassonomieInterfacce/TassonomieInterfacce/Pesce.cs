using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TassonomieInterfacce
{
    public abstract class Pesce:Animale_Marino,Animale_Squamoso
    {
        public Pesce(string Nome):base(Nome,0,"Squame")
        {
            
        }

        public void DescrizioneSquame()
        {
            Console.WriteLine("le sue squame sono gialle");
        }
    }
}
