using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class ConcreteState
    {
    }


    public class NormalState : State
    {
        public NormalState(Context con)
        {
            this.con = con;
        }

        public NormalState(State state)
        {
            this.con = state.con;
        }

        public override void deposit(double amount)
        {
            con.setBalance(con.getBalance() + amount);
            statecheck();
        }

        public override void withdraw(double amount)
        {
            con.setBalance(con.getBalance() - amount);
            statecheck();
        }

        public override void computeInterest()
        {
            Console.WriteLine("No Interest");
        }

        public override void statecheck()
        {
            if (con.getBalance() > -2000 && con.getBalance() <= 0)
            {
                con.setState(new OverdraftState(this));
            }
             else if (con.getBalance() == -2000)
            {
                con.setState(new RestrictedState(this));
            }
            else if (con.getBalance()<-2000)
            {
                Console.WriteLine("Fail");
            }
        }


    }

    public class OverdraftState : State
    {
        public OverdraftState(State state)
        {
            this.con = state.con;
        }

        public override void deposit(double amount)
        {
            con.setBalance(con.getBalance() + amount);
            statecheck();
        }

        public override void withdraw(double amount)
        {
            con.setBalance(con.getBalance() - amount);
            statecheck();
        }

        public override void computeInterest()
        {
            Console.WriteLine("Has Interest");
        }

        public override void statecheck()
        {
            if (con.getBalance() > 0)
            {
                con.setState(new NormalState(this));
            }
            else if (con.getBalance() == -2000)
            {
                con.setState(new RestrictedState(this));
            }
            else if (con.getBalance()<-2000)
            {
                Console.WriteLine("Fail");
            }
        }


    }

    public class RestrictedState : State
    {
        public RestrictedState(State state)
        {
            this.con = state.con;
        }

        public override void deposit(double amount)
        {
            con.setBalance(con.getBalance() + amount);
            statecheck();
        }

        public override void withdraw(double amount)
        {
            Console.WriteLine("Fail");
        }

        public override void computeInterest()
        {
            Console.WriteLine("Has Interest");
        }

        public override void statecheck()
        {
            if (con.getBalance() > 0)
            {
                con.setState(new NormalState(this));
            }
            else if (con.getBalance() > -2000)
            {
                con.setState(new OverdraftState(this));
            }
        }


    }
}
