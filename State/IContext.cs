using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public  interface IContext
    {
        double getBalance();
        void setBalance(double balance);
        void setState(State state);
        void withdraw(double amount);
        void deposit(double amount);
        void computeInterest();
    }
}
