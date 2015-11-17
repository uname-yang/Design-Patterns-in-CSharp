using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class ConcreteMediator:Mediator
    {
        public List list;
        public TextBox textBox;
        public Button button;

        public override void compontChanged(Component c)
        {
            if (c == button)
            {
                Console.WriteLine("Click Button");
                list.update();
                textBox.update();
            }
            else if (c == list)
            {
                Console.WriteLine("Choose person");
                list.select();
                textBox.setText();
            }

        }
    }
}
