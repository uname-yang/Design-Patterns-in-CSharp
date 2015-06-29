using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("原型模式：使用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。原型模式是一种对象创建型模式。");
            ClonePrototype ob1 = new ClonePrototype();
            ob1.attr = "SB";
            Console.WriteLine(ob1.attr);

            var ob2 = ob1.clone();
            Console.WriteLine(ob2.attr);
            ob2.attr = "DSB";
            Console.WriteLine(ob1.attr);
            Console.WriteLine(ob2.attr);

            Console.ReadKey();
        }
    }


    public class ClonePrototype
    {
        public string attr { get; set; }

        public ClonePrototype clone()
        {
            ClonePrototype pt = new ClonePrototype();
            pt.attr = this.attr;
            return pt;
        }
    }
}
