using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命令模式：将一个请求封装为一个对象，从而让我们可用不同的请求对客户进行参数化；对请求排队或者记录请求日志，以及支持可撤销 的操作。命令模式是一种对象行为模式，别名为动作模式或事务模式。");

            FbWindowsSetting fbs = new FbWindowsSetting("fbs");

            FunctionButton fb1 = new FunctionButton("fb1");
            FunctionButton fb2 = new FunctionButton("fb2");

            CommandP c1 = new HelpCommand();
            CommandP c2 = new MinCommand();

            fb1.setCommand(c1);
            fb2.setCommand(c2);

            fbs.addbuttion(fb1);
            fbs.addbuttion(fb2);

            fbs.display();

            fb1.onclick();
            fb2.onclick();



            Console.ReadLine();
        }
    }
}
