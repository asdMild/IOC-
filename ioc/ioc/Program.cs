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
           A a= IOC_factory.ioc_reflect(typeof(A))as A;
            Console.WriteLine( a.Get_s());

            Type[] typeparam = { typeof(C) };
            B b = IOC_factory.ioc_reflect(typeof(B),typeparam)as B;
            Console.WriteLine(b.Get_s());

            Type[] typeparam_= {};
            D d = IOC_factory.ioc_reflect(typeof(D), typeparam_) as D;
            Console.WriteLine(d.Get_s());

            Type[] typeparam__ = { typeof(C) , typeof(C) , typeof(C) };
            C c = IOC_factory.ioc_reflect(typeof(C), typeparam__) as C;
            Console.WriteLine(c.Get_s());
            while (true)
            { }
        }
    }
}
