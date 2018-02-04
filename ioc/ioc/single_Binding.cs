using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc
{
    public class monobehaviour:IBinding 
    {
        private string str;
        public string Str
        {
            set { str = value; StrBindingEvent.Invoke(value); }
            get { return str; }
        }
        public event Action<string> StrBindingEvent;
        public void SetStr(string _str)
        {
            str = _str;
        }
        public void show()
        {
            Console.WriteLine(Str);
        }
    }
    public interface IBinding
    {
        string Str { set; get; }
        event Action<string> StrBindingEvent;
        void SetStr(string str);
    }
    public class single_Binding : IBinding
    {
        private string str;
        public string Str
        {
            set { str = value; StrBindingEvent.Invoke(value); }
            get { return str; }
        }
        public event Action<string> StrBindingEvent;
        public void SetStr(string _str)
        {
            str = _str;
        }
    }
}
