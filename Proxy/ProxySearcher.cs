using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    public class ProxySearcher:ISearcher
    {
        private RealSearcher searcher = new RealSearcher();
        private Access ac = new Access();
        private Logger log = new Logger();

        public string DoSearch(string usr, string key)
        {
            if (this.Validate(usr))
            {
                string data = searcher.DoSearch(usr,key);
                this.Log(usr);
                return data;
            }
            else
            {
                return null;
            }
        }

        public bool Validate(string usr)
        {
           return  ac.Validate(usr);
        }

        public void Log(string usr)
        {
             log.Log(usr);
        }

    }
}
