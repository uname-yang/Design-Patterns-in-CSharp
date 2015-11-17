using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public interface IDisCount
    {
        double calculate(double price);
    }
}
