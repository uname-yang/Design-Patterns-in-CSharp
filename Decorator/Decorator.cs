using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Decorator:Component
    {
        private Component component;

        public Decorator(Component component)
        {
            this.component = component;
        }

        public override void display()
        {
            component.display();
        }
    }
}
