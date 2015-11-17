using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver successor;
        protected string name;

        public Approver(string name)
        {
            this.name = name;
        }

        public void setSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void processRequest(PurchaseRequest request);
    }
}
