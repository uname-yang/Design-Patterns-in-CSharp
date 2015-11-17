using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("访问者模式：提供一个作用于某对象结构中的各元素的操作表示，它使我们可以在不改变各元素的类的前提下定义作用于这些元素的新操作。它是一种对象行为模式。");
            EmployeeList ls = new EmployeeList();
            Employee f1 = new FulltimeEmployee("A");
            Employee f2 = new ParttimeEmployee("B");

            ls.addEmployee(f1);
            ls.addEmployee(f2);

            Department dep = new FAD();
            ls.accept(dep);

            Console.ReadKey();
        }
    }
}
