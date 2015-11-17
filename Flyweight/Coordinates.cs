using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    public class Coordinates
    {
        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x { get; private set; }
        public int y { get; private set; }
    }
}
