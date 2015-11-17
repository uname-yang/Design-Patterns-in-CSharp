using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    abstract class Department
    {
        public abstract void visit(FulltimeEmployee emp);
        public abstract void visit(ParttimeEmployee emp);
    }
}
