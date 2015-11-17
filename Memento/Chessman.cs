using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Chessman
    {
        public  string label { get; set; }
        public  int x { get; set; }
        public  int y { get; set; }

        public Chessman(string label,int x,int y)
        {
            this.label = label;
            this.x = x;
            this.y = y;
        }

        public Chessmanmemento save()
        {
            return new Chessmanmemento(label,x,y);
        }

        public void restore(Chessmanmemento memento)
        {
            label = memento.label;
            x = memento.x;
            y = memento.y;
        }
    }
}
