using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class ConcreteImplementor1 : Impementor
    {
        public void doPaint(string brush)
        {
            Console.WriteLine("ConcreteImplementor1");
        }
    }

    public class ConcreteImplementor2 : Impementor
    {
        public void doPaint(string brush)
        {
            Console.WriteLine("ConcreteImplementor2");
        }
    }

    public class ConcreteImplementor3 : Impementor
    {
        public void doPaint(string brush)
        {
            Console.WriteLine("ConcreteImplementor3");
        }
    }
}
