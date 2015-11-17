using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class ChildrenDiscount:IDisCount
    {
        public double calculate(double price)
        {
            Console.WriteLine("Children");
            return price * 0.5;
        }
    }
}
