using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc
{
    public class A
    {
      public   A(B b,C c,D d) { b_ = b;c_ = c;d_ = d; }

        B b_;
        C c_;
        D d_;
        
        public float Get_s()
        {
            return b_.Get_s()== d_.Get_s()? d_.Get_s():0;
        }

    }
    public class B 
    {
        public B(C c) { c_ = c; }
        C c_;

        public float Get_s()
        {
            return c_.Get_s();
        }

    }
    public class C
    {
        public C(D d)
        { d_ = d; }
        D d_;
        public float Get_s()
        {
            return d_.Get_s();
        }

    }
    public class D 
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
        /*
        static public object ioc_reflect(Type typename)
        {
            var construct_ = typename.GetConstructors();
            var parameters_ = construct_[0].GetParameters();

            object[] param = new object[parameters_.Length];
            int num = 0;
            foreach (ParameterInfo i in parameters_)
            {
                param[num] =ioc_reflect(Type.GetType(i.ParameterType.ToString()));
                Console.WriteLine(param[num]);
                num++;
            }
            
            
            if(param.Length==0)
            return Activator.CreateInstance(typename);
            else
            return Activator.CreateInstance(typename, param);
        }*/
        static public object ioc_reflect(Type typename,Type[] construct_param=null)
        {
            ParameterInfo[] parameters_;

            if (construct_param == null)
                parameters_ = (typename.GetConstructors())[0].GetParameters();
            else
            if (typename.GetConstructor(construct_param) != null)
                parameters_ = typename.GetConstructor(construct_param).GetParameters();
            else
            {
                Console.WriteLine("there is none construct with those params");
                parameters_ = (typename.GetConstructors())[0].GetParameters();
            }


            object[] param = new object[parameters_.Length];
            int num = 0;
            foreach (ParameterInfo i in parameters_)
            {
                param[num] = ioc_reflect(Type.GetType(i.ParameterType.ToString()));
                Console.WriteLine(param[num]);
                num++;
            }


            if (param.Length == 0)
                return Activator.CreateInstance(typename);
            else
                return Activator.CreateInstance(typename, param);
        }
    }
}
