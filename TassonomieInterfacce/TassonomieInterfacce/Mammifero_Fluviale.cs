using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TassonomieInterfacce
{
    public abstract class Mammifero_Fluviale:Animale_Terrestre
    {
        public Mammifero_Fluviale (string Nome):base(Nome,4,"Animale Fluviale","Corre/Cammina/Salta/Nuota","Peloso")
        {

        }
    }
}
