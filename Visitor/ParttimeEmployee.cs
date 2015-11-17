using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class ParttimeEmployee:Employee
    {
        public string name { get; set; }
        public ParttimeEmployee(string name)
        {
            this.name = name;
        }
        public void accept(Department handler)
        {
            handler.visit(this);
        }
    }
}
