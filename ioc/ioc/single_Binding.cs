using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc
{
    public class monobehaviour:IBinding<string>
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
    public interface IBinding<T>
    {
        T Str { set; get; }
        event Action<T> StrBindingEvent;
        void SetStr(T str);
    }
    public class single_Binding : IBinding<string>
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
