using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class SpringButton:Button
    {
        public void display()
        {
            Console.WriteLine("springbutton");
        }
    }

    public class SummerButton : Button
    {
        public void display()
        {
            Console.WriteLine("Summebutton");
        }
    }

    public class SpringTextField : TextField
    {
        public void display()
        {
            Console.WriteLine("SpringTextField");
        }
    }

    public class SummerTextField : TextField
    {
        public void display()
        {
            Console.WriteLine("SummerTextField");
        }
    }
}
