using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class List:Component
    {

        public override void update()
        {
            Console.WriteLine("List Add One!");
        }

        public void select()
        {
            Console.WriteLine("List Select One");
        }
    }
}
