using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    public class RealSearcher:ISearcher
    {
        public string DoSearch(string usr, string key)
        {
            Console.WriteLine(usr+" is Searching:"+key);
            return "SB";
        }
    }
}
