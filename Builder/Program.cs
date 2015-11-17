using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("建造者模式：将一个复杂对象的构建与它的表示分离，使同样的构建过程可以创建不同的表示。建造者模式是一种对象创建型模式。");

            ActionController ac = new ActionController();
            var nb1=ac.Build(new NB1Builder());
            Console.WriteLine(nb1.type);
            Console.WriteLine(nb1.face);
            Console.WriteLine(nb1.sex);
            Console.WriteLine(nb1.weapon);

            var nb2 = ac.Build(new NB2Builder());
            Console.WriteLine(nb2.type);
            Console.WriteLine(nb2.face);
            Console.WriteLine(nb2.sex);
            Console.WriteLine(nb2.weapon);

            Console.ReadKey();
        }

    }


}
