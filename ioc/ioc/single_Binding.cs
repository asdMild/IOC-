using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc
{
    public class BindingValue<T>
    {
        public BindingValue() { ValueBindingEvent += SetValueWithoutInvoke; }
        T value;
        public T Value
        {
            set { ValueBindingEvent.Invoke(value); }
            get { return value; }
        }
        event Action<T> ValueBindingEvent;
        public void Bind(Action<T> func) { ValueBindingEvent += func; }
        public void SetValueWithoutInvoke(T _value)
        {
            value = _value;
        }
    }
    public interface IBinding<T>
    {
        T Value { set; get; }
        event Action<T> ValueBindingEvent;
        void SetValueWithoutInvoke(T _value);
    }
    public class single_Binding
    {
        int a = 2;
    }
}
