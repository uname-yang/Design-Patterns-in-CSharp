using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class MementoCaretaker
    {
        private Chessmanmemento memento;

        public Chessmanmemento getmemnto()
        {
            return memento;
        }

        public void setMemento(Chessmanmemento memento)
        {
            this.memento = memento;
        }
    }
}
