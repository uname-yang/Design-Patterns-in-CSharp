using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class Context:IContext
    {
        private State state;
        private string owner;
        private double balance = 0;

        public Context(string owner ,double init)
        {
            this.owner = owner;
            this.balance = init;
            this.state = new NormalState(this);
            Console.WriteLine(this.owner+"KH,Account:"+init);
            Console.WriteLine("-------------------------------------------------");
        }

        public double getBalance()
        {
            return this.balance;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public void withdraw(double amount)
        {
            Console.WriteLine(this.owner+"QK:"+amount);
            state.withdraw(amount);
            Console.WriteLine("YE:"+this.balance);
            Console.WriteLine("STATE:"+state.GetType().Name);
            Console.WriteLine("-------------------------------------------------");
        }

        public void deposit(double amount)
        {
            Console.WriteLine(this.owner + "CK:" + amount);
            state.deposit(amount);
            Console.WriteLine("YE:" + this.balance);
            Console.WriteLine("STATE:" + state.GetType().Name);
            Console.WriteLine("-------------------------------------------------");
        }

        public void computeInterest()
        {
            state.computeInterest();
        }
    }
}
