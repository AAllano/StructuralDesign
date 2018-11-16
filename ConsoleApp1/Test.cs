using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Vent vent = new Vent(1, "IIIb", 20, 20, 20, 0, false, false);
            Console.WriteLine(vent.W_facade+" Pa");
        }
    }
}
