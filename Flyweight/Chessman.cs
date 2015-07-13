using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    public abstract class Chessman
    {
        public abstract string getcolor();

        public void display(Coordinates coo)
        {
            Console.WriteLine("color:"+this.getcolor()+"--loc:"+coo.x+"/"+coo.y);
        }
    }
}
