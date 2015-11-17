using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("状态模式：允许一个对象在其内部状态改变时改变他的行为，对象看起来似乎修改了他的类。其别名为状态对象，状态模式是一种对象行为模式。");
            IContext con = new Context("YUYANG", 1000);
            //Context con = new Context("YUYANG",1000000);
            con.deposit(100);
            con.withdraw(2000);
            con.withdraw(1000);
            con.deposit(10000);
            con.computeInterest();

            Console.ReadKey();

        }
    }
}
