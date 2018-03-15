using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inherit;
namespace ioc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           //single ioc achive
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
            */
            /*
            //single binding achive 
            BindingValue<Dictionary<string, int>> a = new BindingValue<Dictionary<string, int>>();
            BindingValue<Dictionary<string, int>> b = new BindingValue<Dictionary<string, int>>();
            a.Bind(b.SetValueWithoutInvoke);
            b.Bind(a.SetValueWithoutInvoke);
            b.SetValueWithoutInvoke(new Dictionary<string, int>());
            a.SetValueWithoutInvoke(new Dictionary<string, int>());
            b.Value = new Dictionary<string, int>();
            b.Value.Add("asd", 1);
            b.Value.Add("wer", 1);
            b.Value.Add("zxc", 1);
            Console.WriteLine(a.Value.Count);
            Console.WriteLine(a.Value.Equals(b.Value));
            Console.WriteLine(a == b);
            Console.WriteLine(b.Value.Count);

            Dictionary<string, int> c = new Dictionary<string, int>();
            Dictionary<string, int> d = c;
            c.Add("asd",1);
            asd(c);
            Console.WriteLine(d["asd"]);
            Console.WriteLine(c.Count);
            */
            inherit.A b = new inherit.B();
            b.asd();
            //Console.WriteLine(b.x.Count);
            while (true)
            { }
        }
        static void asd(Dictionary<string, int>  temp) { temp.Add("",2); }
    }
}
