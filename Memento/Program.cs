using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("备忘录模式：在不破坏封装的前提下，捕获一个对象的内部状态，并在对象之外保存这个状态，这样可以在以后对象恢复到原先保存的状态。它是一种对象行为模式，别名Token。");
            MementoCaretaker mc = new MementoCaretaker();
            Chessman chess = new Chessman("炮",1,1);
            display(chess);
            mc.setMemento(chess.save());
            chess.y = 4;
            display(chess);
            mc.setMemento(chess.save());
            chess.x = 3;
            display(chess);
            mc.setMemento(chess.save());
            chess.label = "2b";
            chess.x = 1;
            chess.y = 1;
            display(chess);
            Console.WriteLine("Memento");
            chess.restore(mc.getmemnto());
            display(chess);

            Console.ReadKey();

        }

        public static void display(Chessman chess)
        {
            Console.WriteLine(chess.label+":["+chess.x+","+chess.y+"]");
        }
    }
}
