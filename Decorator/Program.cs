using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("装饰模式：动态的给一个对象增加一些额外的职责，就增加对象功能来说，装饰模式比生成子类实现更为灵活。装饰模式是一种对象结构型模式。");

            Component c1, c2,C3;
            c1 = new ConcreteComponent1();
            c2 = new ConcreteDecorator1(c1);
            c2.display();
            C3 = new ConcreteDecorator2(c2);
            C3.display();

            Console.ReadKey();

        }
    }
}
