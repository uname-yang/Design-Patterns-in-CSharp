using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("中介者模式：用一个中介对象来封装一系列的对象交互，中介者使各对象不需要显示地相互引用，从而使其耦合松散，从而可以独立地改变他们之间的交互。中介者模式又称为调停者模式，它是一种对象行为型模式。");

            ConcreteMediator mediator = new ConcreteMediator();
            Button bt = new Button();
            List lt = new List();
            TextBox tb = new TextBox();

            bt.setMediator(mediator);
            lt.setMediator(mediator);
            tb.setMediator(mediator);

            mediator.button = bt;
            mediator.list = lt;
            mediator.textBox = tb;

            bt.changed();
            lt.changed();

            Console.ReadKey();
        }
    }
}
