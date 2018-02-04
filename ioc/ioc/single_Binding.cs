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
        public string Value
        {
            set { str = value; ValueBindingEvent.Invoke(value); }
            get { return str; }
        }
        public event Action<string> ValueBindingEvent;
        public void SetValue(string _str)
        {
            str = _str;
        }
        public void show()
        {
            Console.WriteLine(Value);
        }
    }
    public interface IBinding<T>
    {
        T Value { set; get; }
        event Action<T> ValueBindingEvent;
        void SetValue(T _value);
    }
    public class single_Binding : IBinding<string>
    {
        private string str;
        public string Value
        {
            set { str = value; ValueBindingEvent.Invoke(value); }
            get { return str; }
        }
        public event Action<string> ValueBindingEvent;
        public void SetValue(string _str)
        {
            str = _str;
        }
    }
}
