# IOC_analyse

针对接口编程和继承（包括多继承），是类似的，但是是针对不同场合的方式。
如果抽象类足够抽象，则可以使用继承，这样的好处是代码的复用。
接口能够脱离原来的抽象类代码，但实现相同的内容并且在整体中发挥作用。比较适合扩展，没有了继承，也就没有了很多需要担忧的因素。

ioc的实现：
ioc对于反射这一方法的应用，是抽象这个动作的具象化。通过c#,c++(宏，类ue4)的反射，实现ioc针对类的动态实现（通过类名生成类），再用递归思想，就能将一个类
的生成方式，完全而简洁的在ioc中实现。
用简单的例子来说明如下：（ps:这里的实现方法并不是反射，switch只是为了方便理解）
```c#
//#########################
main(){
A a;
a=ioc_reflect("A");
}

T ioc_reflect(string typename)
{
  switch(typename)
  {
  case A:
  retuen A(ioc_reflect("B"),ioc_reflect("C"),ioc_reflect("D"));
  break;
  case B:
  return B(ioc_reflect("C"));
  break;
  case C:
  return C(ioc_reflect("D"));
  break;
  case D:
  return D(default(D));
  break;
  return default(T);
  default:break;
  }
}
//(这里的代码并不能被实际使用)
//#########################
```
同时，在类ABC中，对于其他类的耦合，是通过构造函数的中的外部变量的引用，这也是我理解的依赖注入的关系。（不在自己的类中生成，依赖外部生成的引用。）


可能在以前的编程中已经潜移默化的使用这些方法，但是看网上的一些文档并不是很理解，所以就从原始开始自己想了一套理解方式。如有错误，以后会进行修改
