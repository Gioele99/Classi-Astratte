using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerchio c = new Cerchio();
            Console.WriteLine(c.getArea());
            Console.WriteLine(c.getPerimetro());
            Console.ReadLine();
        }
    }
}
