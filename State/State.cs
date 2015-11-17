using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public abstract class State
    {
        public  Context con;

        public abstract void deposit(double amount);
        public abstract void withdraw(double amount);
        public abstract void computeInterest();
        public abstract void statecheck();
    }
}
