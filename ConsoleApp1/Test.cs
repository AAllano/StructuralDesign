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
            Actions.Vent vent = new Actions.Vent(1, "IIIb",20,20,20,false);
            Console.WriteLine(vent.qp);
        }
    }
}
