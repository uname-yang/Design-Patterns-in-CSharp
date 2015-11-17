using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public class Director:Approver
    {
        public Director(string name)
            : base(name)
        {
        }
        public override void processRequest(PurchaseRequest request)
        {
            if (request.getAmount() < 50000)
            {
                Console.WriteLine("Director     " + request.getNumbers() + "    " + request.getAmount() + "     " + request.getPurpose());
            }
            else
            {
                this.successor.processRequest(request);
            }
        }
    }
}
