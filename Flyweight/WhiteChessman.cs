using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    public class WhiteChessman:Chessman
    {
        public override string getcolor()
        {
            return "white";
        }
    }
}
