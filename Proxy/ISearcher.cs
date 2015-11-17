using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    public interface ISearcher
    {
        string DoSearch(string usr,string key);
    }
}
