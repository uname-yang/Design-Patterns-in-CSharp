using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Chessmanmemento
    {
        public string label { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public Chessmanmemento(string label, int x, int y)
        {
            this.label = label;
            this.x = x;
            this.y = y;
        }

    }
}
