using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("解释器模式：定义一个语言的文法，并且建立一个解释器来解释该语言中的句子，这里的语言是指使用规定格式和语法的代码。解释器模式是一种类型为模式。");
            string ins = "up move 6 and down run 100 and left move 2";
            InstructionHandler handler = new InstructionHandler();
            handler.handle(ins);
            string output = handler.output();
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
