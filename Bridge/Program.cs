using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("桥接模式：将抽象部分与他的实现部分分离，是它们都可以独立地变化。它是一种对象结构模型，又称为柄体模式或接口模式。");

            Impementor imp = new ConcreteImplementor3();
            Abstraction abs = new RefinedAbstraction2();
            abs.setImp(imp);
            abs.parseFile("1");

            Console.ReadKey();
        }
    }
}
