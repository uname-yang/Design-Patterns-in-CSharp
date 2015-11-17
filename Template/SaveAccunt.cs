using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    class SaveAccunt:Account
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("SaveAccunt Interest!");
        }
    }
}
