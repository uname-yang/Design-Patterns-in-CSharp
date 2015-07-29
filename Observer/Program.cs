using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("观察者模式：定义对象之间的一种一对多依赖关系，使得每当一个对象状态发生变化时，其相关对象皆得到通知并被自动更新。观察者模式的别名包括发布-订阅模式，模型视图模式等。观察者模式是一种对象行为模式。");

            ConcreteControlCenter center = new ConcreteControlCenter("SB");
            Observer p1=new Player();
            Observer p2=new Player();
            Observer p3=new Player();
            p1.name = "A";
            p2.name = "B";
            p3.name = "C";

            center.join(p1);
            center.join(p2);
            center.join(p3);

            p2.beAttacked(center);

            Console.ReadKey();
        }
    }
}
