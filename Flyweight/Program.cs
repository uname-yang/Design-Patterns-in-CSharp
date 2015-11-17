using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("享元模式：运用共享技术有效的支持大量细粒度对象的复用。系统只使用少量的对象，而这些对象都很相似，状态变化很小，可以实现对象的多次复用。由于享元模式要求能够共享的对象必须是细粒度对象，因此它又成为轻量级模式，它是一种对象结构模型。");

            Chessman b1, b2, w1, w2;
            ChessmanFactory factory = ChessmanFactory.getInstance();
            b1 = factory.getChessman("b");
            b2 = factory.getChessman("b");
            Console.WriteLine("--"+(b1==b2));
            w1 = factory.getChessman("w");
            w2 = factory.getChessman("w");
            Console.WriteLine("--" + (w1 == w2));

            b1.display(new Coordinates(1, 1));
            b2.display(new Coordinates(1, 2));
            w1.display(new Coordinates(2, 1));
            w2.display(new Coordinates(2, 2));
            Console.ReadLine();
        }
    }
}
