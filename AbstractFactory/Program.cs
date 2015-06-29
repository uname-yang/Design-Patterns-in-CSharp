using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类。抽象工厂模式有成为Kit模式，它是一种对象创建型模式。");

            SkinFactory factory;
            Button bt;
            TextField tf;

            factory = new SummerFactory();

            bt = factory.createButton();
            tf = factory.createTextField();

            bt.display();
            tf.display();

            Console.ReadKey();
        }
    }
}
