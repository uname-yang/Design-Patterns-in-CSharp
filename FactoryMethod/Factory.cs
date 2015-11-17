using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public interface  LoggerFactory
    {
         Logger createLogger();
    }
}
