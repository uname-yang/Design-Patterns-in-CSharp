using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public class Congress:Approver
    {
        public Congress(string name)
            : base(name)
        {
        }
        public override void processRequest(PurchaseRequest request)
        {
            Console.WriteLine("Congress     " + request.getNumbers() + "    " + request.getAmount() + "     " + request.getPurpose());
        }
    }
}
