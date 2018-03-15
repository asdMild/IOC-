using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inherit
{
    public class A
    {
        public List<int> x=new List<int>();
        public virtual void asd()
        {
            Console.WriteLine("A");
        }
    }
    public class B:A
    {
        public new List<int> x=new List<int>();
        public override void asd()
        {
            base.asd();
            Console.WriteLine("B");
        }
    }
}

