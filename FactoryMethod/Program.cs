using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("工厂方法模式：定义一个用于创建的接口，让子类决定让那一个类实例化。工厂方法模式让一个子类的实例化延迟到其子类。工厂方法模式又简称为工厂模式，又可称作虚拟构造器模式或多态工厂模式。工厂模式是一种类创造型模式。");

            LoggerFactory factory;
            Logger logger;

            factory = new FileFactory();
            logger = factory.createLogger();
            logger.writelog();

            Console.ReadKey();
        }
    }
}
