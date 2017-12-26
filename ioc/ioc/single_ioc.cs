using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc
{
    public interface interfaces { }

    public class A:interfaces
    {
      public   A(B b,C c,D d) { b_ = b;c_ = c;d_ = d; }

        B b_;
        C c_;
        D d_;
        
        public float Get_s()
        {
            return b_.Get_s();
        }

    }
    public class B : interfaces
    {
        public B(C c) { c_ = c; }
        C c_;

        public float Get_s()
        {
            return c_.Get_s();
        }

    }
    public class C : interfaces
    {
        public C(D d)
        { d_ = d; }
        D d_;
        public float Get_s()
        {
            return d_.Get_s();
        }

    }
    public class D : interfaces
    {
        public D() { }
        public float Get_s()
        {
            return s;
        }
        
        float s=3.1415926f;
    }

   static public class IOC_factory
    {
        static public object ioc_reflect<T>(Type typename)where T: interfaces
        {
            var s = typename.GetConstructors();
            var j = s[0].GetParameters();

            object[] k = new object[j.Length];
            int l = 0;
            foreach (ParameterInfo i in j)
            {
                k[l] =ioc_reflect<interfaces>(Type.GetType(i.ParameterType.ToString()));
                Console.WriteLine(k[l]);
                l++;
            }
            

            if(k.Length==0)
            return Activator.CreateInstance(typename);
            else
            return Convert.ChangeType(Activator.CreateInstance(typename, k), typename);
        }
    }
}
