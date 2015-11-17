using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("职责链模式：避免请求发送者与接收者后和在一起，让多个对象都有可能接受请求，将这些对象炼成一条链，并且沿着这条链传递请求，直到对象处理它为止。职责链模式是一种对象行为模式。");
            Approver d, c;
            d = new Director("D");
            c = new Congress("C");

            d.setSuccessor(c);

            PurchaseRequest p = new PurchaseRequest(4500,1,"sb");
            d.processRequest(p);

            PurchaseRequest pp = new PurchaseRequest(60000, 2, "SD");
            d.processRequest(pp);

            Console.ReadLine();

        }
    }
}
