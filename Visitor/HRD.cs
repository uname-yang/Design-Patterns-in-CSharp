using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class HRD:Department
    {
        public override void visit(FulltimeEmployee emp)
        {
            Console.WriteLine("HR Visit 正式员工：" + emp.name);
        }

        public override void visit(ParttimeEmployee emp)
        {
            Console.WriteLine("HR Visit 兼职员工：" + emp.name);
        }
    }
}
