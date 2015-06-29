using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("组合多个对象形成树形结构以表示具有“整体-部分”关系的层次结构。组合模式对单个对象（即叶子对象）和组合对象（即容器对象）的使用具有一致性，组合模式又可以称为“整体-部分”模式，它是对象结构型模式。");

            ICompontent file1, file2, file3, folder1, folder2;

            file1 = new Leaf1("1");
            file2 = new Leaf2("2");
            file3 = new Leaf1("3");

            folder1 = new Composite1("F1");
            folder2 = new Composite1("base");

            folder2.add(file1);
            folder2.add(file2);
            folder2.add(file3);

            folder1.add(folder2);

            folder1.function();

            Console.ReadKey();
        }
    }
}
