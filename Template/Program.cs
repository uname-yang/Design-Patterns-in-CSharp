using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("模板方法模式：定义一个操作中算法的框架，而将一些步骤延迟到子类中。模板方法模式使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。");

            Account account = new SaveAccunt();
            account.Handle();
            Console.ReadKey();
        }
    }
}
