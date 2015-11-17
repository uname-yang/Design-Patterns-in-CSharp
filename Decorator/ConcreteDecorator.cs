using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class ConcreteDecorator1 : Decorator
    {
        public ConcreteDecorator1(Component component)
            : base(component)
        {
        }

        public override void display()
        {
            this.setDSB();
            base.display();
        }

        public void setDSB()
        {
            Console.WriteLine("ConcreteDecorator1");
        }
    }

    public class ConcreteDecorator2 : Decorator
    {
        public ConcreteDecorator2(Component component)
            : base(component)
        {
        }

        public override void display()
        {
            this.setSB(); 
            base.display();
        }

        public void setSB()
        {
            Console.WriteLine("ConcreteDecorator2");
        }
    }
}
