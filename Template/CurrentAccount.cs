using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    class CurrentAccount:Account
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("CurrentAccount Interest!");
        }
    }
}
