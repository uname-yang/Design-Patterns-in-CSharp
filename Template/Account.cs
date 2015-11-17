using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    abstract class Account
    {
        public abstract void CalculateInterest();
        public void Display()
        {
            Console.WriteLine("Interest!");
        }

        public void Handle()
        {
            CalculateInterest();
            Display();
        }
    }
}
