using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public  class RefinedAbstraction1:Abstraction
    {
        public override void parseFile(string filename)
        {
            string brush="RefinedAbstraction1";
            imp.doPaint(brush);
            Console.WriteLine(brush);
        }
    }

    public class RefinedAbstraction2 : Abstraction
    {
        public override void parseFile(string filename)
        {
            string brush = "RefinedAbstraction2";
            imp.doPaint(brush);
            Console.WriteLine(brush);
        }
    }

    public class RefinedAbstraction3 : Abstraction
    {
        public override void parseFile(string filename)
        {
            string brush = "RefinedAbstraction3";
            imp.doPaint(brush);
            Console.WriteLine(brush);
        }
    }
}
