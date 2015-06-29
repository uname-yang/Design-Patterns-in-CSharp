using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class ConcreteComponent1:Component
    {
        public override void display()
        {
            Console.WriteLine("ConcreteComponent1");
        }
    }

    public class ConcreteComponent2 : Component
    {
        public override void display()
        {
            Console.WriteLine("ConcreteComponent2");
        }
    }

    public class ConcreteComponent3 : Component
    {
        public override void display()
        {
            Console.WriteLine("ConcreteComponent3");
        }
    }
}
