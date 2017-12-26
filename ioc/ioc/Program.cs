using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc
{
    class Program
    {
        static void Main(string[] args)
        {
           A a=(A) IOC_factory.ioc_reflect<A>(typeof(A));
            Console.WriteLine( a.Get_s());

            while (true)
            { }
        }
    }
}
