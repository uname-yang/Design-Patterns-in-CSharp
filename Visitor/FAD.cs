using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class FAD:Department
    {
        public override void visit(FulltimeEmployee emp)
        {
            Console.WriteLine("FA Visit 正式员工："+emp.name);
        }

        public override void visit(ParttimeEmployee emp)
        {
            Console.WriteLine("FA Visit 兼职员工：" + emp.name);
        }
    }
}
