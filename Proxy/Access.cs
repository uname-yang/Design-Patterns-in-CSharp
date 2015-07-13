using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    public class Access
    {
        public bool Validate(string usr)
        {
            Console.WriteLine("Access:"+usr);
            return true;
        }
    }
}
