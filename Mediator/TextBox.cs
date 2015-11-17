using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class TextBox:Component
    {
        public override void update()
        {
            Console.WriteLine("TextBox Clear");
        }

        public void setText()
        {
            Console.WriteLine("TextBox set Text");
        }
    }
}
