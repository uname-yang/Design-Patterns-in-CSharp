using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public interface  Observer
    {
        string name { get; set; }
        void help();
        void beAttacked(ControlCenter acc);
    }
}
