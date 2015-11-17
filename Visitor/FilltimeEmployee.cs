using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
     class FulltimeEmployee:Employee
    {
        public string name { get; set; }

        public FulltimeEmployee(string name)
        {
            this.name = name;
        }

        public void accept(Department handler)
        {
            handler.visit(this);
        }
    }
}
