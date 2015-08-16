using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class StudentDiscount:IDisCount
    {
        public double calculate(double price)
        {
            Console.WriteLine("Student");
            return price * 0.8;
        }
    }
}
